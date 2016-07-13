using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder
{
    public class CsType
    {
        Dictionary<string, string> alias = new Dictionary<string, string>();
        public CsType()
        {
            alias["bigint"] = "long";
            alias["int"] = "int";
            alias["varchar"] = "string";
            alias["nvarchar"] = "string";
            alias["datetime"] = "DateTime";
            alias["float"] = "double";
            alias["decimal"] = "decimal";
            alias["bit"] = "bool";
            //  alias["datetime"] = "DateTime?";
          alias["datetime"] = "DateTime";
        }
        public string GetLower(string type)
        {
            if (alias.ContainsKey(type))
                return alias[type];
            else
                return type;
        }
    }
}
