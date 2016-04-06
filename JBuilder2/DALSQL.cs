using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace JBuilder2
{
    /// <summary>
    /// ���ݷ��ʻ�����
    /// </summary>
     class DALSQL
    {

        public string strconn = System.Configuration.ConfigurationManager.ConnectionStrings["conn"].ToString();
        /// <summary>
        /// ִ�в�ѯ������DataSet
        /// </summary>
        /// <param name="strcmd">����</param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string strcmd)
        {
            using (SqlConnection sqlconn = new SqlConnection(strconn))
            {
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlcmd;
                DataSet ds = new DataSet();
                sda.Fill(ds);
                sqlconn.Close();
                return ds;
            }
        }
        /// <summary>
        /// ִ�в�ѯ������Table
        /// </summary>
        /// <param name="strcmd">����</param>
        /// <returns></returns>
        public DataTable ExecutTable(string strcmd)
        {
            using (SqlConnection sqlconn = new SqlConnection(strconn))
            {
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlcmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlconn.Close();
                return dt;
            }
        }
        /// <summary>
        /// ����Ӱ������
        /// </summary>
        /// <param name="strcmd">����</param>
        /// <returns></returns>
        public int ExecutSQL(string strcmd)
        {
            using (SqlConnection sqlconn = new SqlConnection(strconn))
            {
                sqlconn.Open();
                SqlCommand sqlcmd = new SqlCommand(strcmd, sqlconn);
                sqlcmd.CommandType = CommandType.Text;
                int Impact = sqlcmd.ExecuteNonQuery();
                sqlconn.Close();
                return Impact;
            }
        }
        /// <summary>
        /// ����Ӱ���һ������
        /// </summary>
        /// <param name="strcmd">����</param>
        /// <returns></returns>
        public object ExecutSQLobject(string strcmd)
        {
            using (SqlConnection sqlconn = new SqlConnection(strconn))
            {
                SqlCommand cmd = new SqlCommand(strcmd, sqlconn);
                sqlconn.Open();
                object Impact = cmd.ExecuteScalar();
                sqlconn.Close();
                return Impact;
            }
        }
        #region DataReader��ʵ��
        /// <summary>
        ///  ����һ��һ�ж�ȡ����
        /// </summary>
        /// <param name="strcmd"></param>
        private void ExecutDataReader(string strcmd)
        {
            using (SqlConnection sqlconn = new SqlConnection(strconn))
            {
                //������
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(strcmd, sqlconn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                }
                dr.Close();
                sqlconn.Close();
            }
        }
        #endregion
    }
}