using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2.DAL
{
    class DALFactory
    {
        public static IDatabase GetDatabase(string DatabaseType)
        {
            //IDatabase
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
