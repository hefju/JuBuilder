﻿namespace JuBuilder
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
            this.btnCheat = new System.Windows.Forms.Button();
            this.btnReLoadConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamespace_MODEL = new System.Windows.Forms.TextBox();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtupdate = new System.Windows.Forms.RichTextBox();
            this.btnCreateUpdate = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtUI_Entity = new System.Windows.Forms.RichTextBox();
            this.btn_Row_To_Entity = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUIData = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDataUI = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDef = new System.Windows.Forms.RichTextBox();
            this.btn生成设计代码 = new System.Windows.Forms.Button();
            this.txtsjdm设计代码 = new System.Windows.Forms.RichTextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txtBindSource = new System.Windows.Forms.RichTextBox();
            this.btnBindingSource = new System.Windows.Forms.Button();
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
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(310, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtConnString
            // 
            this.txtConnString.Location = new System.Drawing.Point(6, 2);
            this.txtConnString.Name = "txtConnString";
            this.txtConnString.Size = new System.Drawing.Size(303, 21);
            this.txtConnString.TabIndex = 3;
            this.txtConnString.Text = "server=ASUS-PC;uid =sa;pwd=123;database=charge";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnCheat);
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
            this.splitContainer1.Size = new System.Drawing.Size(1283, 561);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnCheat
            // 
            this.btnCheat.Location = new System.Drawing.Point(223, 22);
            this.btnCheat.Name = "btnCheat";
            this.btnCheat.Size = new System.Drawing.Size(162, 23);
            this.btnCheat.TabIndex = 14;
            this.btnCheat.Text = "不用选择,直接打开数据表";
            this.btnCheat.UseVisualStyleBackColor = true;
            this.btnCheat.Click += new System.EventHandler(this.btnCheat_Click);
            // 
            // btnReLoadConfig
            // 
            this.btnReLoadConfig.Location = new System.Drawing.Point(831, 1);
            this.btnReLoadConfig.Name = "btnReLoadConfig";
            this.btnReLoadConfig.Size = new System.Drawing.Size(112, 23);
            this.btnReLoadConfig.TabIndex = 13;
            this.btnReLoadConfig.Text = "重新加载配置文件";
            this.btnReLoadConfig.UseVisualStyleBackColor = true;
            this.btnReLoadConfig.Click += new System.EventHandler(this.btnReLoadConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Namespace_MODEL";
            // 
            // txtNamespace_MODEL
            // 
            this.txtNamespace_MODEL.Location = new System.Drawing.Point(480, 23);
            this.txtNamespace_MODEL.Name = "txtNamespace_MODEL";
            this.txtNamespace_MODEL.Size = new System.Drawing.Size(215, 21);
            this.txtNamespace_MODEL.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Namespace_VIEW";
            // 
            // txtNamespace_VIEW
            // 
            this.txtNamespace_VIEW.Location = new System.Drawing.Point(480, 3);
            this.txtNamespace_VIEW.Name = "txtNamespace_VIEW";
            this.txtNamespace_VIEW.Size = new System.Drawing.Size(215, 21);
            this.txtNamespace_VIEW.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "TableName";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(73, 23);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(149, 21);
            this.txtTableName.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1069, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "连接";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(698, 1);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
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
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(1283, 509);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(25, 509);
            this.treeView1.TabIndex = 0;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1254, 509);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridColumns);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 483);
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
            this.gridColumns.Location = new System.Drawing.Point(3, 3);
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.ReadOnly = true;
            this.gridColumns.RowTemplate.Height = 23;
            this.gridColumns.Size = new System.Drawing.Size(1240, 477);
            this.gridColumns.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridIndexs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 483);
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
            this.gridIndexs.Location = new System.Drawing.Point(3, 3);
            this.gridIndexs.Name = "gridIndexs";
            this.gridIndexs.ReadOnly = true;
            this.gridIndexs.RowTemplate.Height = 23;
            this.gridIndexs.Size = new System.Drawing.Size(1240, 477);
            this.gridIndexs.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtupdate);
            this.tabPage3.Controls.Add(this.btnCreateUpdate);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1246, 483);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "生成sql语句";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(22, 75);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(797, 359);
            this.txtupdate.TabIndex = 2;
            this.txtupdate.Text = "";
            // 
            // btnCreateUpdate
            // 
            this.btnCreateUpdate.Location = new System.Drawing.Point(22, 17);
            this.btnCreateUpdate.Name = "btnCreateUpdate";
            this.btnCreateUpdate.Size = new System.Drawing.Size(122, 23);
            this.btnCreateUpdate.TabIndex = 0;
            this.btnCreateUpdate.Text = "生成更新语句";
            this.btnCreateUpdate.UseVisualStyleBackColor = true;
            this.btnCreateUpdate.Click += new System.EventHandler(this.btnCreateUpdate_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtUI_Entity);
            this.tabPage4.Controls.Add(this.btn_Row_To_Entity);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1246, 483);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "UI转成实体";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtUI_Entity
            // 
            this.txtUI_Entity.Location = new System.Drawing.Point(22, 66);
            this.txtUI_Entity.Name = "txtUI_Entity";
            this.txtUI_Entity.Size = new System.Drawing.Size(797, 359);
            this.txtUI_Entity.TabIndex = 3;
            this.txtUI_Entity.Text = "";
            // 
            // btn_Row_To_Entity
            // 
            this.btn_Row_To_Entity.Location = new System.Drawing.Point(18, 11);
            this.btn_Row_To_Entity.Name = "btn_Row_To_Entity";
            this.btn_Row_To_Entity.Size = new System.Drawing.Size(203, 23);
            this.btn_Row_To_Entity.TabIndex = 0;
            this.btn_Row_To_Entity.Text = "DataGridViewRow 转实体";
            this.btn_Row_To_Entity.UseVisualStyleBackColor = true;
            this.btn_Row_To_Entity.Click += new System.EventHandler(this.btn_Row_To_Entity_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.txtUIData);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.txtDataUI);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txtDef);
            this.tabPage5.Controls.Add(this.btn生成设计代码);
            this.tabPage5.Controls.Add(this.txtsjdm设计代码);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1246, 483);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "直接生成代码";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "UI->数据";
            // 
            // txtUIData
            // 
            this.txtUIData.Location = new System.Drawing.Point(500, 259);
            this.txtUIData.Name = "txtUIData";
            this.txtUIData.Size = new System.Drawing.Size(486, 189);
            this.txtUIData.TabIndex = 6;
            this.txtUIData.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "数据->UI";
            // 
            // txtDataUI
            // 
            this.txtDataUI.Location = new System.Drawing.Point(8, 259);
            this.txtDataUI.Name = "txtDataUI";
            this.txtDataUI.Size = new System.Drawing.Size(486, 189);
            this.txtDataUI.TabIndex = 4;
            this.txtDataUI.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "定义";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "设置属性和位置";
            // 
            // txtDef
            // 
            this.txtDef.Location = new System.Drawing.Point(500, 36);
            this.txtDef.Name = "txtDef";
            this.txtDef.Size = new System.Drawing.Size(486, 189);
            this.txtDef.TabIndex = 2;
            this.txtDef.Text = "";
            // 
            // btn生成设计代码
            // 
            this.btn生成设计代码.Location = new System.Drawing.Point(410, 4);
            this.btn生成设计代码.Name = "btn生成设计代码";
            this.btn生成设计代码.Size = new System.Drawing.Size(75, 23);
            this.btn生成设计代码.TabIndex = 1;
            this.btn生成设计代码.Text = "生成代码";
            this.btn生成设计代码.UseVisualStyleBackColor = true;
            this.btn生成设计代码.Click += new System.EventHandler(this.btn生成设计代码_Click);
            // 
            // txtsjdm设计代码
            // 
            this.txtsjdm设计代码.Location = new System.Drawing.Point(8, 36);
            this.txtsjdm设计代码.Name = "txtsjdm设计代码";
            this.txtsjdm设计代码.Size = new System.Drawing.Size(486, 189);
            this.txtsjdm设计代码.TabIndex = 0;
            this.txtsjdm设计代码.Text = "";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnBindingSource);
            this.tabPage6.Controls.Add(this.txtBindSource);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1246, 483);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "BindingSource";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txtBindSource
            // 
            this.txtBindSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBindSource.Location = new System.Drawing.Point(6, 33);
            this.txtBindSource.Name = "txtBindSource";
            this.txtBindSource.Size = new System.Drawing.Size(968, 442);
            this.txtBindSource.TabIndex = 1;
            this.txtBindSource.Text = "";
            // 
            // btnBindingSource
            // 
            this.btnBindingSource.Location = new System.Drawing.Point(6, 6);
            this.btnBindingSource.Name = "btnBindingSource";
            this.btnBindingSource.Size = new System.Drawing.Size(122, 23);
            this.btnBindingSource.TabIndex = 2;
            this.btnBindingSource.Text = "生成bindsource";
            this.btnBindingSource.UseVisualStyleBackColor = true;
            this.btnBindingSource.Click += new System.EventHandler(this.btnBindingSource_Click);
            // 
            // FrmCentre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 561);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnCreateUpdate;
        private System.Windows.Forms.RichTextBox txtupdate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_Row_To_Entity;
        private System.Windows.Forms.RichTextBox txtUI_Entity;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.RichTextBox txtsjdm设计代码;
        private System.Windows.Forms.Button btn生成设计代码;
        private System.Windows.Forms.RichTextBox txtDef;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtUIData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDataUI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheat;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.RichTextBox txtBindSource;
        private System.Windows.Forms.Button btnBindingSource;
    }
}