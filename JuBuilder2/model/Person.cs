using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuBuilder2.model
{
     //  [Table("Person")]
    class Person
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public DateTime registerDate { get; set; }
        public string address { set; get; }
    }
}
