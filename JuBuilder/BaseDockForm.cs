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
    public partial class BaseDockForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public BaseDockForm()
        {
            InitializeComponent();
        }

        private void BaseDockForm_Load(object sender, EventArgs e)
        {
         
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlTop.Height = pnlTop.Height * 2;
        }
    }
}
