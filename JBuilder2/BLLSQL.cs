using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace JBuilder2
{
    
    class BLLSQL
    {
        private JBuilder2.DALSQL SQLServer =new DALSQL();
        /// <summary>
        /// 获取数据库所有表
        /// </summary>
        /// <returns>返回数据库表树</returns>
        public DataTable GetSQLTableTree()
        {
            string sql = string.Format("SELECT NAME FROM SYS.TABLES GO");
            DataTable dt= SQLServer.ExecutTable(sql);
            return dt;
        }
        /// <summary>
        /// 返回字段的
        /// </summary>
        /// <param name="TableName">表的名称</param>
        /// <returns>字段的表格</returns>
        public DataTable GetSQLTableColumns(string TableName)
        {
            string sql = string.Format("select * from information_schema.columns  AS A INNER JOIN SYSCOLUMNS AS B ON B.NAME=A.COLUMN_NAME  where table_name = '{0}' AND ID=OBJECT_ID('{0}' )",TableName);
            DataTable dt = SQLServer.ExecutTable(sql);
            return new DataTable();
        }

        //private DataTable GetSQLTableType(string TableName)
        //{
        //    string sql = string.Format("select name from syscolumns where id=(select max(id) from sysobjects where xtype='u' and name='{0}')",TableName);
        //    return new DataTable();
        //}
    }
}
