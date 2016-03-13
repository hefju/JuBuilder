using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JBuilder2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbDB.SelectedIndex = 0;
        }

        private DataTable  LoadSQLTableTree()
        {
            BLLSQL get = new BLLSQL();
            return get.GetSQLTableTree();
        }

        private void TreeADD()
        {
            DataTable dt = LoadSQLTableTree();
            foreach (DataRow dr in dt.Rows)
            {
                treeView1.Nodes.Add(new TreeNode(dr[0].ToString()));
            }
        }
    }
}
