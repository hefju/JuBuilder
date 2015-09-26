using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JuBuilder
{
    /// <summary>
    /// ���ݷ��ʻ�����
    /// </summary>
    public class DbHelperSQL
    {

        /// <summary>
        /// ��ʱʱ��(��)
        /// </summary>
        private static int _CommandTimeOut = 100;

        /// <summary>
        /// ����SQL����ѯ��¼����
        /// </summary>
        /// <param name="sql">�����SQL���</param>
        /// <param name="parms">SQL����</param>
        /// <returns>���ز�ѯ�������DataTable��ʽ</returns>
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
                            dt.ExtendedProperties.Add("SQL", sql.Substring(0, index - 1));  //����ȡ����䱣���ڱ��һ������������������ʱ����CommandBuilder
                        }
                        else
                        {
                            dt.ExtendedProperties.Add("SQL", sql);  //����ȡ����䱣���ڱ��һ������������������ʱ����CommandBuilder
                        }
                    }
                    else
                    {
                        dt.ExtendedProperties.Add("SQL", sql);  //����ȡ����䱣���ڱ��һ������������������ʱ����CommandBuilder
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
        /// ������������(ÿ����500)
        /// </summary>
        /// <param name="dtDataTables">���ݱ��¼</param>
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
                //�����������µ�ÿ�δ�������
                adapter.UpdateBatchSize = 500;
                adapter.SelectCommand.Transaction = conn.BeginTransaction();/////////////////��ʼ����	
                if (table.ExtendedProperties["SQL"] != null)
                {
                    adapter.SelectCommand.CommandText = table.ExtendedProperties["SQL"].ToString();
                }
                adapter.Update(table);
                adapter.SelectCommand.Transaction.Commit();/////�ύ����
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
        /// ִ��SQL��䣬����Ӱ��ļ�¼��
        /// </summary>
        /// <param name="sql">SQL���</param>
        /// <param name="parms">����</param>
        /// <returns>Ӱ���¼��</returns>
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
        /// ִ�в�ѯ�������ز�ѯ�����صĽ�����е�һ�еĵ�һ�С����������л���...
        /// </summary>
        /// <param name="tran">����</param>
        /// <param name="sql">sql</param>
        /// <param name="parms">����</param>
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
        /// ����ִ��Sql���(�������)
        /// </summary>
        /// <param name="sqls">SQL�������</param>
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
        /// ��������������
        /// </summary>
        /// <param name="connString">���ݿ������ַ���</param>
        /// <param name="tableName">���ݿ��������Ŀ�����</param>
        /// <param name="dt">���к�Ŀ�����ݿ��ṹ��ȫһ��(���������ֶ�����ȫһ�¼���)��DataTable</param>
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
        /// ���ݱ������ؿ�DataTable
        /// </summary>
        /// <param name="tableName">����</param>
        public static DataTable GetEmptyDataTable(string connString, string tableName)
        {
            return GetDataTable(connString, string.Format("select * from {0} where 1=-1", tableName));
        }

        /// <summary>
        /// ���˿ղ���
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