using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuBuilder
{
    public partial class FrmTxt2Field : Form
    {
        public FrmTxt2Field()
        {
            InitializeComponent();
        }

        List<fields> TableFields = new List<fields>();
        private void btn2Field_Click(object sender, EventArgs e)
        {
            TableFields.Clear();
            var split = rb1.Text;
            var origin = txtRequire.Text.Trim();
            var sp = origin.Split(new string[] { split }, StringSplitOptions.RemoveEmptyEntries);
            List<fields> fs = TableFields;
            foreach (var item in sp)
            {
                fs.Add(new fields { fname=item});
            }
            dgv.DataSource = null;
            dgv.DataSource = TableFields;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtRequire.Text = "ID、" + txtRequire.Text;
            txtRequire.Text += "、CreateAt、";
            txtRequire.Text += "statu";
            //TableFields.Insert(0, new fields {fname="ID" });
            //TableFields.Insert(0, new fields { fname = "CreateAt" });
            //TableFields.Insert(0, new fields { fname = "statu" });   
        }

        private void btnSetType_Click(object sender, EventArgs e)
        {
            var type = cbtype.Text;
            var cells = dgv.SelectedCells;
            foreach (DataGridViewCell c in cells)
            {
                c.Value = type;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CREATE table T_table(");
            var ph = "";
            foreach (var item in TableFields)
            {
                var fieldname = getfieldname(item.fname);
                sb.Append(ph + fieldname);//item.fname + " int");
                ph = ",";
            }
               sb.Append(")");
               var msg = sb.ToString();
               txtOutput.Text = msg;
        }

        private string getfieldname(string fname)
        {
            var nametype = "";
            switch (fname)
            {
                case "ID":
                    nametype = "ID int primary key identity";
                    break;
                case "CreateAt":
                    nametype = "CreateAt datetime default getdate()";
                    break;
                case "statu":
                    nametype = "statu int DEFAULT 0";
                    break;
                default:
                    nametype = fname + " int";
                    break;
            }
            return nametype;
        }
    }

    class fields
    {
        public string fname { get; set; }
        public string ftype { get; set; }
    }
}
