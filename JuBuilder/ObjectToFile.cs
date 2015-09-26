using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder
{
    class ObjectToFile
    {
        public static void SaveToFile(string filename, object obj)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, obj);
            fs.Close();
        }

        public static object ObjectFromFile(string filename)
        {
            if (!File.Exists(filename)) return null;
            //反序列化List
            FileStream fs = new FileStream(filename, FileMode.Open);//"serializeconfig.dat"
            BinaryFormatter bf = new BinaryFormatter();
            object uicofing = bf.Deserialize(fs) as Dictionary<string, string>;
            fs.Close();
            return uicofing;
        }
    }
}
