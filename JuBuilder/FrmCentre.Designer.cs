namespace JuBuilder
{
    partial class FrmCentre
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtConnString = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamespace_VIEW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridIndexs = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamespace_MODEL = new System.Windows.Forms.TextBox();
            this.btnReLoadConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIndexs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(413, 2);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 29);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(8, 3);
            this.txtConnString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(403, 25);
            this.txtConnString.TabIndex = 3;
            this.txtConnString.Text = "server=ASUS-PC;uid =sa;pwd=123;database=charge";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnReLoadConfig);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtNamespace_MODEL);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtNamespace_VIEW);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtTableName);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreate);
            this.splitContainer1.Panel1.Controls.Add(this.txtConnString);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1579, 701);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Namespace_VIEW";
            // 
            // txtNamespace_VIEW
            // 
            this.txtNamespace_VIEW.Location = new System.Drawing.Point(640, 4);
            this.txtNamespace_VIEW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNamespace_VIEW.Name = "txtNamespace_VIEW";
            this.txtNamespace_VIEW.Size = new System.Drawing.Size(285, 25);
            this.txtNamespace_VIEW.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "TableName";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(214, 29);
            this.txtTableName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(197, 25);
            this.txtTableName.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1425, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(931, 1);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 29);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "输出到文件";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1579, 636);
            this.splitContainer2.SplitterDistance = 280;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(280, 636);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1294, 636);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1286, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "表字段";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridColumns
            // 
            this.gridColumns.AllowUserToAddRows = false;
            this.gridColumns.AllowUserToDeleteRows = false;
            this.gridColumns.AllowUserToOrderColumns = true;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColumns.Location = new System.Drawing.Point(4, 4);
            this.gridColumns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.ReadOnly = true;
            this.gridColumns.RowTemplate.Height = 23;
            this.gridColumns.Size = new System.Drawing.Size(1278, 599);
            this.gridColumns.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridIndexs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1192, 630);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "表索引";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridIndexs
            // 
            this.gridIndexs.AllowUserToAddRows = false;
            this.gridIndexs.AllowUserToDeleteRows = false;
            this.gridIndexs.AllowUserToOrderColumns = true;
            this.gridIndexs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIndexs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIndexs.Location = new System.Drawing.Point(4, 4);
            this.gridIndexs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridIndexs.Name = "gridIndexs";
            this.gridIndexs.ReadOnly = true;
            this.gridIndexs.RowTemplate.Height = 23;
            this.gridIndexs.Size = new System.Drawing.Size(1184, 622);
            this.gridIndexs.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Namespace_MODEL";
            // 
            // txtNamespace_MODEL
            // 
            this.txtNamespace_MODEL.Location = new System.Drawing.Point(640, 29);
            this.txtNamespace_MODEL.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamespace_MODEL.Name = "txtNamespace_MODEL";
            this.txtNamespace_MODEL.Size = new System.Drawing.Size(285, 25);
            this.txtNamespace_MODEL.TabIndex = 11;
            // 
            // btnReLoadConfig
            // 
            this.btnReLoadConfig.Location = new System.Drawing.Point(1108, 1);
            this.btnReLoadConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnReLoadConfig.Name = "btnReLoadConfig";
            this.btnReLoadConfig.Size = new System.Drawing.Size(150, 29);
            this.btnReLoadConfig.TabIndex = 13;
            this.btnReLoadConfig.Text = "重新加载配置文件";
            this.btnReLoadConfig.UseVisualStyleBackColor = true;
            this.btnReLoadConfig.Click += new System.EventHandler(this.btnReLoadConfig_Click);
            // 
            // FrmCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 701);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCentre";
            this.Text = "FrmCentre";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCentre_FormClosing);
            this.Load += new System.EventHandler(this.FrmCentre_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIndexs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtConnString;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.DataGridView gridIndexs;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamespace_VIEW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamespace_MODEL;
        private System.Windows.Forms.Button btnReLoadConfig;
    }
}