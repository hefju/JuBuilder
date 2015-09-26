namespace JuBuilder
{
    partial class BaseDockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlBottom = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgv = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.pnlTop = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.cbField = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbKey = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnAdvancedSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnExport = new DevComponents.DotNetBar.ButtonX();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.PnlBottom.Controls.Add(this.btnExport);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 531);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(784, 30);
            // 
            // 
            // 
            this.PnlBottom.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.PnlBottom.Style.BackColorGradientAngle = 90;
            this.PnlBottom.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.PnlBottom.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlBottom.Style.BorderBottomWidth = 1;
            this.PnlBottom.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.PnlBottom.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlBottom.Style.BorderLeftWidth = 1;
            this.PnlBottom.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlBottom.Style.BorderRightWidth = 1;
            this.PnlBottom.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.PnlBottom.Style.BorderTopWidth = 1;
            this.PnlBottom.Style.CornerDiameter = 4;
            this.PnlBottom.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.PnlBottom.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.PnlBottom.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.PnlBottom.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.PnlBottom.TabIndex = 4;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgv.Location = new System.Drawing.Point(0, 50);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(784, 511);
            this.dgv.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlTop.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlTop.Controls.Add(this.btnAdvancedSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.cbKey);
            this.pnlTop.Controls.Add(this.cbField);
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(784, 50);
            // 
            // 
            // 
            this.pnlTop.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlTop.Style.BackColorGradientAngle = 90;
            this.pnlTop.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlTop.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTop.Style.BorderBottomWidth = 1;
            this.pnlTop.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlTop.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTop.Style.BorderLeftWidth = 1;
            this.pnlTop.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTop.Style.BorderRightWidth = 1;
            this.pnlTop.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlTop.Style.BorderTopWidth = 1;
            this.pnlTop.Style.CornerDiameter = 4;
            this.pnlTop.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlTop.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlTop.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlTop.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.pnlTop.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(701, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "新  建";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // cbField
            // 
            this.cbField.DisplayMember = "Text";
            this.cbField.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbField.FormattingEnabled = true;
            this.cbField.Location = new System.Drawing.Point(185, 19);
            this.cbField.Name = "cbField";
            this.cbField.Size = new System.Drawing.Size(121, 22);
            this.cbField.TabIndex = 1;
            // 
            // cbKey
            // 
            this.cbKey.DisplayMember = "Text";
            this.cbKey.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKey.FormattingEnabled = true;
            this.cbKey.Location = new System.Drawing.Point(322, 19);
            this.cbKey.Name = "cbKey";
            this.cbKey.Size = new System.Drawing.Size(121, 22);
            this.cbKey.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(464, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查  询";
            // 
            // btnAdvancedSearch
            // 
            this.btnAdvancedSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdvancedSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdvancedSearch.Location = new System.Drawing.Point(594, 18);
            this.btnAdvancedSearch.Name = "btnAdvancedSearch";
            this.btnAdvancedSearch.Size = new System.Drawing.Size(75, 23);
            this.btnAdvancedSearch.TabIndex = 4;
            this.btnAdvancedSearch.Text = "高级查询";
            // 
            // btnExport
            // 
            this.btnExport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExport.Location = new System.Drawing.Point(701, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "导  出";
            // 
            // BaseDockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "BaseDockForm";
            this.Text = "BaseDockForm";
            this.Load += new System.EventHandler(this.BaseDockForm_Load);
            this.PnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.Controls.GroupPanel PnlBottom;
        protected DevComponents.DotNetBar.Controls.DataGridViewX dgv;
        protected DevComponents.DotNetBar.Controls.GroupPanel pnlTop;
        protected DevComponents.DotNetBar.ButtonX btnNew;
        protected DevComponents.DotNetBar.ButtonX btnSearch;
        protected DevComponents.DotNetBar.Controls.ComboBoxEx cbKey;
        protected DevComponents.DotNetBar.Controls.ComboBoxEx cbField;
        protected DevComponents.DotNetBar.ButtonX btnAdvancedSearch;
        protected DevComponents.DotNetBar.ButtonX btnExport;
    }
}