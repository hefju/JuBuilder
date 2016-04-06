using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2.DAL
{
    public interface IDatabase
    {
        bool Connect(string ConnectString);

        //bool Command(string SQL);

        void ExecuteNonQuery(string connectionString, string sql);

        object ExecuteScalar(string connectionString, string sql);

        DataTable GetTable(string connectionString, string sql);

        //DataSet ExecuteDataSet(string connectionString, string sql);
    }


}
