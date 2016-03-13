using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2
{
    //普通工厂模式, 返回相应的数据库,但这不怎么好
    public interface IDatabase
    {
        bool Connect(string ConnectString);

        bool Open();

        bool Command(string SQL);

        void Close();
    }

    public class SqlServer : IDatabase
    {
        SqlConnection conn;
        SqlCommand command;

        public bool Connect(string ConnectString)
        {
            try
            {
                conn = new SqlConnection(ConnectString);
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }


        public bool Open()
        {
            try
            {
                conn.Open();
                return true;
            }

            catch (SqlException)
            {
                return false;
            }
        }

        public bool Command(string SQL)
        {
            try
            {
                command = new SqlCommand(SQL, conn);
                command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public void Close()
        {
            conn.Close();
            conn.Dispose();
        }
    }

    public class Oracle : IDatabase
    {
        public Oracle()
        {
        }
        public bool Connect(string ConnectString)
        {
            return true;
        }
        public bool Open()
        {
            return true;
        }
        public bool Command(string SQL)
        {
            return true;
        }

        public void Close()
        {
        }
    }

    public class Factory
    {
        public static IDatabase SelectDatabase(string DatabaseType)
        {
            switch (DatabaseType)
            {
                case "SqlServer":
                    return new SqlServer();
                case "Oracle":
                    return new Oracle();
                default:
                    return new SqlServer();
            }
        }
    }
}
