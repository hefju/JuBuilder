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
            TreeADD();
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

        private void GetColumnsType(string TableName)
        {
            BLLSQL get = new BLLSQL();
            dataGridView1.DataSource= get.GetSQLTableColumns(TableName);
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
               GetColumnsType(treeView1.SelectedNode.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
