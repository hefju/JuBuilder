using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuBuilder
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
       public static Dictionary<string, string> uicofing = new Dictionary<string, string>();
        private void MainFrom_Load(object sender, EventArgs e)
        {
            LoadConfig();
            //FrmTop ftop = new FrmTop();
            //ftop.Show(dockPanel1);
            //ftop.DockTo(dockPanel1, DockStyle.Top);

            //FrmLeftMenu frm = new FrmLeftMenu();
            //frm.Show(dockPanel1);
            //frm.DockTo(dockPanel1, DockStyle.Left);

            FrmCentre fc = new FrmCentre();
            fc.Show(dockPanel1);
            //fc.DockTo(dockPanel1, DockStyle.Fill);
        }

        private void LoadConfig()
        {
            if (File.Exists("serializeconfig.dat"))
                uicofing = ObjectToFile.ObjectFromFile("serializeconfig.dat") as Dictionary<string, string>;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }
        
        private void 初始化配置文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uicofing.Clear();
            uicofing.Add("connectstring", "server=USERMIC-VN0AUET;uid =sa;pwd=123;database=CcbaDB");
            uicofing.Add("namespace_VIEW", "CcbaSystem.Sys.views");
            uicofing.Add("namespace_MODEL", "CcbaSystem.Model.SYS");
            ObjectToFile.SaveToFile("serializeconfig.dat", uicofing);
            MessageBox.Show("保存成功.");
            //FileStream fs = new FileStream(@"serializeconfig.dat", FileMode.Create);
            //BinaryFormatter bf = new BinaryFormatter();

            //bf.Serialize(fs, uicofing);
            //fs.Close();

        }

        private void 测试BaseFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // BaseEditForm frm = new BaseEditForm();
          //  BaseDockForm frm = new BaseDockForm();
            //Form2 frm = new Form2();
            //frm.Show(dockPanel1);
        }
    }
}
