using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder
{
    public static class SqlQuery
    {

        public static List<string> GetDatabases(string connString)
        {
            string sql = "select name from sys.databases where name not in ('master','model','msdb','tempdb')";
            DataTable dt = DbHelperSQL.GetDataTable(connString, sql);
            return dt.Rows.Cast<DataRow>().Select(row => row["name"].ToString()).ToList();
        }

        public static Dictionary<string, string> GetTables(string connString, string database)
        {
            string sql = string.Format(@"select
                                        a.name+'('+ltrim(str(rows))+')' showname,
                                        a.name                                        
                                        from {0}.sys.objects  as a
                                        inner join {0}.dbo.sysindexes b on a.object_id=b.id and b.indid<=1
                                        where type='U' 
                                        order by a.name", database);
            DataTable dt = DbHelperSQL.GetDataTable(connString.Replace("master", database), sql);
            return dt.Rows.Cast<DataRow>().ToDictionary(row => row["showname"].ToString(), row => row["name"].ToString());
        }

        public static DataTable GetColumns(string connString, string database, string tableName)
        {
            string sql = string.Format(@"select 
                                        a.name ColumnName,
                                        b.name ColumnType,
                                        a.is_identity IsIdentity,
                                        a.is_nullable IsNullable,
                                        cast(a.max_length as int) ByteLength,
                                        (
	                                        case 
		                                        when b.name='nvarchar' and a.max_length>0 then a.max_length/2 
		                                        when b.name='nchar' and a.max_length>0 then a.max_length/2
                                                when b.name='ntext' and a.max_length>0 then a.max_length/2 
		                                        else a.max_length
	                                        end
                                        ) CharLength,
                                        cast(a.scale as int) Scale,
                                        c.value Remark
                                        from {0}.sys.columns a
                                        inner join {0}.sys.types b on a.system_type_id=b.system_type_id and a.user_type_id=b.user_type_id
                                        left join {0}.sys.extended_properties c on a.object_id=c.major_id and a.column_id=c.minor_id
                                        where object_id=OBJECT_ID(@tableName)
                                        order by a.column_id", database);
            SqlParameter param = new SqlParameter("@tableName", SqlDbType.NVarChar, 100) { Value = database + ".dbo." + tableName };
            DataTable dt = DbHelperSQL.GetDataTable(connString, sql, param);
            return dt;
        }

        public static DataTable GetIndexs(string connString, string database, string tableName)
        {
            #region SQL
            string sql = string.Format(@"with IndexCTE as
                                        (
                                            select 
                                            indexes.object_id,
                                            indexes.index_id,
                                            indexes.name IndexName,
                                            indexes.type_desc IndexType,
                                            indexes.is_primary_key IsPrimaryKey,
                                            indexes.is_unique IsUnique,
                                            indexes.is_unique_constraint IsUniqueConstraint
                                            from {0}.sys.indexes
                                            where object_id =OBJECT_ID(@tableName)
                                        )
                                        ,IndexColumnTempCTE as
                                        (
                                            select 
                                            ic.object_id,
                                            ic.index_id,
                                            ic.column_id,
                                            ic.index_column_id,
                                            ic.is_included_column,
                                            cast(c.name as nvarchar(max)) columnname,
                                            CAST(null as nvarchar(max)) includekey
                                            from {0}.sys.index_columns ic
                                            inner join {0}.sys.columns c on ic.column_id=c.column_id and ic.object_id=c.object_id
                                            where ic.index_column_id=1 and ic.object_id =OBJECT_ID(@tableName)
                                            union all
                                            select
                                            ic.object_id,
                                            ic.index_id,
                                            ic.column_id,
                                            ic.index_column_id,
                                            ic.is_included_column, 
                                            case ic.is_included_column when 0 then columnname+','+c.name end,
                                            case 
                                            when ic.is_included_column = 1 and includekey is null then c.name
                                            when ic.is_included_column = 1 and includekey is not null then includekey+','+c.name
                                            end
                                            from {0}.sys.index_columns ic
                                            inner join IndexColumnTempCTE cte on cte.index_id=ic.index_id and cte.index_column_id+1=ic.index_column_id and cte.object_id=ic.object_id
                                            inner join {0}.sys.columns c on ic.column_id=c.column_id and ic.object_id=c.object_id
                                        ),
                                        IndexColumnCTE as
                                        (
                                            select
                                            object_id,
                                            index_id,
                                            max(columnname) IndexColumns,
                                            max(includekey) IndexIncludeColumns
                                            from IndexColumnTempCTE
                                            group by object_id,index_id
                                        )
                                        select 
                                        IndexCTE.IndexName,
                                         IndexCTE.IndexType,
                                         IndexCTE.IsPrimaryKey,
                                         IndexCTE.IsUnique,
                                         IndexCTE.IsUniqueConstraint,
                                        IndexColumnCTE.IndexColumns,
                                        IndexColumnCTE.IndexIncludeColumns
                                        from IndexCTE
                                        inner join IndexColumnCTE on IndexCTE.object_id=IndexColumnCTE.object_id and IndexCTE.index_id=IndexColumnCTE.index_id
                                        order by IndexCTE.object_id", database);
            #endregion
            SqlParameter param = new SqlParameter("@tableName", SqlDbType.NVarChar, 100) { Value = database + ".dbo." + tableName };
            return DbHelperSQL.GetDataTable(connString, sql, param);
        }
    }
}
