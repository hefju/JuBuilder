using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JuBuilder
{
    /// <summary>
    /// 数据访问基础类
    /// </summary>
    public class DbHelperSQL
    {

        /// <summary>
        /// 超时时间(秒)
        /// </summary>
        private static int _CommandTimeOut = 100;

        /// <summary>
        /// 根据SQL语句查询记录数据
        /// </summary>
        /// <param name="sql">传入的SQL语句</param>
        /// <param name="parms">SQL参数</param>
        /// <returns>返回查询结果，以DataTable形式</returns>
        public static DataTable GetDataTable(string connString, string sql, params SqlParameter[] parms)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand comm = conn.CreateCommand();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                if (parms != null && parms.Length > 0)
                {
                    PrepareSqlParameter(parms);
                    comm.Parameters.AddRange(parms);
                }
                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                DataTable dt = new DataTable();
                try
                {
                    adapter.Fill(dt);
                    if (sql.IndexOf("@") > 0)
                    {
                        sql = sql.ToLower();
                        int index = sql.IndexOf("where ");
                        if (index < 0)
                        {
                            index = sql.IndexOf("\nwhere");
                        }
                        if (index > 0)
                        {
                            dt.ExtendedProperties.Add("SQL", sql.Substring(0, index - 1));  //将获取的语句保存在表的一个附属数组里，方便更新时生成CommandBuilder
                        }
                        else
                        {
                            dt.ExtendedProperties.Add("SQL", sql);  //将获取的语句保存在表的一个附属数组里，方便更新时生成CommandBuilder
                        }
                    }
                    else
                    {
                        dt.ExtendedProperties.Add("SQL", sql);  //将获取的语句保存在表的一个附属数组里，方便更新时生成CommandBuilder
                    }
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    adapter.Dispose();
                }
            }
        }

        /// <summary>
        /// 批量更新数据(每批次500)
        /// </summary>
        /// <param name="dtDataTables">数据表记录</param>
        public static void Update(string connString, DataTable table)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = conn.CreateCommand();
            comm.CommandTimeout = _CommandTimeOut;
            comm.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(comm);
            SqlCommandBuilder commandBulider = new SqlCommandBuilder(adapter);
            commandBulider.ConflictOption = ConflictOption.OverwriteChanges;
            try
            {
                conn.Open();
                //设置批量更新的每次处理条数
                adapter.UpdateBatchSize = 500;
                adapter.SelectCommand.Transaction = conn.BeginTransaction();/////////////////开始事务	
                if (table.ExtendedProperties["SQL"] != null)
                {
                    adapter.SelectCommand.CommandText = table.ExtendedProperties["SQL"].ToString();
                }
                adapter.Update(table);
                adapter.SelectCommand.Transaction.Commit();/////提交事务
            }
            catch (Exception ex)
            {
                if (adapter.SelectCommand != null && adapter.SelectCommand.Transaction != null)
                {
                    adapter.SelectCommand.Transaction.Rollback();
                }
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        /// <summary>
        /// 执行SQL语句，返回影响的记录数
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="parms">参数</param>
        /// <returns>影响记录数</returns>
        public static int ExecuteNonQuery(string connString, string sql, params SqlParameter[] parms)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.Connection = conn;
                if (parms != null && parms.Length > 0)
                {
                    PrepareSqlParameter(parms);
                    comm.Parameters.AddRange(parms);
                }

                return comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static int ExecuteNonQuery(SqlConnection conn, string sql, params SqlParameter[] parms)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand comm = new SqlCommand();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                comm.Connection = conn;
                if (parms != null && parms.Length > 0)
                {
                    PrepareSqlParameter(parms);
                    comm.Parameters.AddRange(parms);
                }

                return comm.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }


        /// <summary>
        /// 执行查询，并返回查询所返回的结果集中第一行的第一列。忽略其他列或行...
        /// </summary>
        /// <param name="tran">事物</param>
        /// <param name="sql">sql</param>
        /// <param name="parms">参数</param>
        /// <returns></returns>
        public static object ExecuteScalar(string connString, string sql, params SqlParameter[] parms)
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                SqlCommand comm = conn.CreateCommand();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                if (parms != null && parms.Length > 0)
                {
                    PrepareSqlParameter(parms);
                    comm.Parameters.AddRange(parms);
                }

                object value = comm.ExecuteScalar();
                comm.Parameters.Clear();
                return value;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        public static object ExecuteScalar(SqlConnection conn, string sql, params SqlParameter[] parms)
        {
            try
            {
                SqlCommand comm = conn.CreateCommand();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.CommandText = sql;
                if (parms != null && parms.Length > 0)
                {
                    PrepareSqlParameter(parms);
                    comm.Parameters.AddRange(parms);
                }

                object value = comm.ExecuteScalar();
                return value;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// 批量执行Sql语句(事物控制)
        /// </summary>
        /// <param name="sqls">SQL语句数组</param>
        public static void ExecuteSQL(string connString, params string[] sqls)
        {
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand comm = new SqlCommand();
            try
            {
                conn.Open();
                comm.CommandTimeout = _CommandTimeOut;
                comm.CommandType = CommandType.Text;
                comm.Connection = conn;
                comm.Transaction = conn.BeginTransaction();
                foreach (string sql in sqls)
                {
                    comm.CommandText = sql;
                    comm.ExecuteNonQuery();
                }
                comm.Transaction.Commit();
            }
            catch (Exception ex)
            {
                if (comm.Transaction != null)
                {
                    comm.Transaction.Rollback();
                    comm.Transaction.Dispose();
                }
                throw ex;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        /// <summary>
        /// 大批量插入数据
        /// </summary>
        /// <param name="connString">数据库链接字符串</param>
        /// <param name="tableName">数据库服务器上目标表名</param>
        /// <param name="dt">含有和目标数据库表结构完全一致(所包含的字段名完全一致即可)的DataTable</param>
        public static void BulkCopy(string connString, string tableName, DataTable dt)
        {
            using (SqlBulkCopy bulk = new SqlBulkCopy(connString))
            {
                bulk.BatchSize = 500;
                bulk.BulkCopyTimeout = _CommandTimeOut;
                bulk.DestinationTableName = tableName;
                foreach (DataColumn col in dt.Columns)
                {
                    bulk.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                }
                bulk.WriteToServer(dt);
                bulk.Close();
            }
        }

        /// <summary>
        /// 根据表名返回空DataTable
        /// </summary>
        /// <param name="tableName">表名</param>
        public static DataTable GetEmptyDataTable(string connString, string tableName)
        {
            return GetDataTable(connString, string.Format("select * from {0} where 1=-1", tableName));
        }

        /// <summary>
        /// 过滤空参数
        /// </summary>
        /// <param name="parms"></param>
        private static void PrepareSqlParameter(params SqlParameter[] parms)
        {
            if (parms != null)
            {
                foreach (SqlParameter parameter in parms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                }
            }
        }


    }
}