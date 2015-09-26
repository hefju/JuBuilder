using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuBuilder
{
    class WinUI
    {
        public static void SetRowNum(DataGridView dgv)
        {
            dgv.RowPostPaint += (s, e) =>
            {
                using (SolidBrush b = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 6);
                }
            };
        }
        public static void SetRowNum(DevComponents.DotNetBar.Controls.DataGridViewX dgv)
        {
            dgv.RowPostPaint += (s, e) =>
            {
                using (SolidBrush b = new SolidBrush(Color.Black))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 12, e.RowBounds.Location.Y + 6);
                }
            };
        }
    }
}
