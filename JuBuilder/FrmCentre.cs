using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuBuilder
{
    public partial class FrmCentre : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmCentre()
        {
            InitializeComponent();
        }

        private void FrmCentre_Load(object sender, EventArgs e)
        {
            loadConfig();
        }
        private void loadConfig(){
            //if (MainFrom.uicofing.ContainsKey("namespace_VIEW"))
            //    txtNamespace_VIEW.Text = MainFrom.uicofing["namespace_VIEW"];
            //if (MainFrom.uicofing.ContainsKey("namespace_MODEL"))
            //    txtNamespace_MODEL.Text = MainFrom.uicofing["namespace_MODEL"];
            //if (MainFrom.uicofing.ContainsKey("connectstring"))
            //    txtConnString.Text = MainFrom.uicofing["connectstring"];

            //txtConnString.Text = ConfigurationManager.AppSettings["connnectstring"];
            //txtNamespace_VIEW.Text = ConfigurationManager.AppSettings["namespace_VIEW"];
            //txtNamespace_MODEL.Text = ConfigurationManager.AppSettings["namespace_MODEL"];


            Default_connString = ConfigurationManager.AppSettings["Default_connString"];
            Default_database = ConfigurationManager.AppSettings["Default_database"];
            Default_tableName = ConfigurationManager.AppSettings["Default_tableName"];

            Default_Namespace_VIEW = ConfigurationManager.AppSettings["Default_Namespace_VIEW"];
            Default_Namespace_MODEL = ConfigurationManager.AppSettings["Default_Namespace_MODEL"];

            txtConnString.Text = Default_connString;
            txtNamespace_VIEW.Text = Default_Namespace_VIEW;
            txtNamespace_MODEL.Text = Default_Namespace_MODEL;
        }
       private  string Default_connString="";
        private string Default_database="";
        private string Default_tableName="";

        private string Default_Namespace_VIEW = "";
        private string Default_Namespace_MODEL = "";

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //server=ASUS-PC;uid =sa;pwd=123;database=charge
            try
            {
                string connString = this.txtConnString.Text;
                List<string> list = SqlQuery.GetDatabases(connString);
                this.treeView1.Nodes.Clear();
                this.treeView1.Nodes.AddRange(list.Select(item => new TreeNode { Text = item }).ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string connString = this.txtConnString.Text;
                TreeNode node = this.treeView1.SelectedNode;
             

                switch (node.Level)
                {
                    case 0:
                        node.Nodes.Clear();
                        node.Nodes.AddRange(SqlQuery.GetTables(connString, node.Text).Select(kv => new TreeNode { Text = kv.Key, Tag = kv.Value }).ToArray());
                        node.Expand();
                        break;
                    case 1:
                        txtTableName.Text = node.Tag.ToString();
                        this.gridColumns.DataSource = SqlQuery.GetColumns(connString, node.Parent.Text, node.Tag.ToString());
                      //  this.gridIndexs.DataSource = SqlQuery.GetIndexs(connString, node.Parent.Text, node.Tag.ToString());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message, "系统异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTableName.Text.Length < 1) return;
            this.Cursor = Cursors.WaitCursor;
            var tableName = txtTableName.Text;
            var namespace_view = txtNamespace_VIEW.Text;
            var namespace_model = txtNamespace_MODEL.Text;


            //Create_Edit_CS(tableName, namespace_view);     //生成编辑窗口
            Create_Edit_CS(tableName, namespace_view, namespace_model);
            Create_Edit_Designer(tableName, namespace_view);
            Create_CS(tableName, namespace_view);//生成查询窗口
            Create_Designer(tableName, namespace_view);

            Create_Entity(tableName, namespace_model);//生成实体类
            Create_Procedure_sp_Get(tableName);//生成读取存储过程
            Create_Procedure_sp_Save(tableName);//生成插入更新存储过程
            Create_Procedure_sp_Del(tableName);//生成删除存储过程
            this.Cursor = Cursors.Default;
        }
        private void Create_Procedure_sp_Del(string tableName)
        {
            var modelFileName = "model/sp_Del.sql";
            var newFileName = "output/sp_Del_" + tableName + ".sql";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);
            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else
                    outline = line;
                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        private void Create_Procedure_sp_Save(string tableName)
        {
            var modelFileName = "model/sp_Save.sql";
            var newFileName = "output/sp_Save_" + tableName + ".sql";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);
            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else if (line.Contains("__at_Field_type"))//@ID int,@Name varchar(10)
                    Write_at_Field_type(sWriter);
                else if (line.Contains("__Fileds_name"))//(ID,name)
                    Write_Fileds_name(sWriter);
                else if (line.Contains("__@Fields"))//@ID,@name
                    Write_at_Fields(sWriter);
                else if (line.Contains("__field=@field"))//ID=@ID,Name=@Name
                    Write_Field_at_Field(sWriter);
                else
                    outline = line;

                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        private void Write_Field_at_Field(StreamWriter sWriter)//ID=@ID,Name=@Name
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt" || field == "ID") continue;
                var outline = string.Format("{0}=@{0}", field);
                lst.Add(outline);
            }
            var msg = string.Join(",", lst);
           
            sWriter.Write("\t"+msg );//+ Environment.NewLine);
        }

        private void Write_at_Fields(StreamWriter sWriter)//@ID,@name
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt" || field == "ID") continue;
                var outline = string.Format("@{0}", field);
                lst.Add(outline);
            }
            var msg = string.Join(",", lst);
            msg = "(" + msg + ")";
            sWriter.Write("\t" + msg);//+ Environment.NewLine);
        }

        private void Write_Fileds_name(StreamWriter sWriter)//(ID,name)
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt" || field == "ID") continue;
                var outline = string.Format("{0}", field);
                lst.Add(outline);
            }
            var msg = string.Join(",", lst);
            msg = "(" + msg + ")";
            sWriter.Write("\t" + msg);//+ Environment.NewLine);
        }

        private void Write_at_Field_type(StreamWriter sWriter)//@ID int,@Name varchar(10)
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                var ftype = dr["ColumnType"].ToString();
                if (field == "CreateAt" ) continue;
                if (ftype == "varchar" || ftype == "nvarchar")
                    ftype += string.Format("({0})", dr["CharLength"]);
                if (ftype == "decimal") ftype = "float";//decimal需要写精度才行， 如果不写就只有整数没有小数。所以用float代替。
                var outline = string.Format("\t@{0} {1}," + Environment.NewLine, field, ftype);
                lst.Add(outline);
            }
            lst.Add("	@UserID int   ");
            var msg = string.Join("", lst);
            msg = msg.Remove(msg.Length - 3);
            sWriter.Write(msg);//+ Environment.NewLine);
        }

        private void Create_Procedure_sp_Get(string tableName)
        {
            var modelFileName = "model/sp_Get.sql";
            var newFileName = "output/sp_Get_" + tableName + ".sql";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);
            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else
                    outline = line;

                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        private void Create_Entity(string tableName, string namespace2)
        {
            var modelFileName = "model/Entity.cs";
            var newFileName = "output/" + tableName + ".cs";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);
            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__namespace"))
                    outline = line.Replace("__namespace", namespace2);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else if (line.Contains("int __Field_Members;"))
                    WriteField_Members(sWriter);
                else
                    outline = line;

                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        private void WriteField_Members(StreamWriter sWriter)
        {
            var table = (DataTable)this.gridColumns.DataSource;
            CsType cstype = new CsType();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                var ftype = dr["ColumnType"].ToString();
                if (field == "CreateAt") continue;
                var what = cstype.GetLower(ftype);
                var outline = string.Format("\t\tpublic {0} {1} {{ get; set; }}", what, field);
                sWriter.Write(outline + Environment.NewLine);
            }
        }

        private void Create_Designer(string tableName, string namespace2)
        {
            var modelFileName = "model/Frm.Designer.cs";
            var newFileName = "output/Frm" + tableName + ".Designer.cs";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);

            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__namespace"))
                    outline = line.Replace("__namespace", namespace2);
                else
                    outline = line;

                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        private void Create_CS(string tableName, string namespace2)
        {
            var modelFileName = "model/Frm.cs";
            var newFileName = "output/Frm" + tableName + ".cs";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);

            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__namespace"))
                    outline = line.Replace("__namespace", namespace2);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else
                    outline = line;

                sWriter.Write(outline + Environment.NewLine);
            }
            sWriter.Close();
        }

        #region Create_Edit_Designer
        private void Create_Edit_Designer(string tableName, string namespace2)
        {
            var modelFileName = "model/FrmEdit.Designer.cs";
            var newFileName = "output/FrmEdit_" + tableName + ".Designer.cs";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);

            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__namespace"))
                    outline = line.Replace("__namespace", namespace2);
                else
                    outline = line;

                if (line.Contains("int __Define_UI;"))
                    WriteDefine_UI(sWriter);
                else if (line.Contains("int __new_UI;"))
                    WriteNew_UI(sWriter);
                else if (line.Contains("__Set_Property;"))
                    Write_Property(sWriter);
                    
                else
                    sWriter.Write(outline + Environment.NewLine);

            }
            sWriter.Close();
        }

        private void Write_Property(StreamWriter sWriter)//"__Set_Property;"
        {
            var table = (DataTable)this.gridColumns.DataSource;
            int row1 = 30, col1 = 5,row2=100,col2=0,tabcount=0;

            List<string> lstPnlCenter = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
               // if (field == "CreateAt") continue;
                if (field == "CreateAt" || field == "ID" || field == "statu") continue;

                col1 += 30;
                col2 += 30;
                tabcount++;

                sWriter.Write("\t\t\t//" + Environment.NewLine);
                sWriter.Write("\t\t\t// lbl" + field + Environment.NewLine);
                sWriter.Write("\t\t\t//" + Environment.NewLine);
                     var area1 =  string.Format(
            "\t\t\tthis.lbl{0}.AutoSize = true;" + Environment.NewLine +
            "\t\t\tthis.lbl{0}.BackColor = System.Drawing.Color.Transparent;" + Environment.NewLine +
            "\t\t\tthis.lbl{0}.Location = new System.Drawing.Point({1}, {2});" + Environment.NewLine +
            "\t\t\tthis.lbl{0}.Name = \"lbl{0}\";" + Environment.NewLine +
            "\t\t\tthis.lbl{0}.Size = new System.Drawing.Size(123, 24);" + Environment.NewLine +
           // "this.lbl{0}.TabIndex = 0;" + Environment.NewLine +
            "\t\t\tthis.lbl{0}.Text = \"{0}\";", field, row1, col1);
                     sWriter.Write(area1 + Environment.NewLine);

                     

                     sWriter.Write("\t\t\t//" + Environment.NewLine);
                     sWriter.Write("\t\t\t// txt" + field + Environment.NewLine);
                     sWriter.Write("\t\t\t//" + Environment.NewLine);
                var area2 =  string.Format(
            "\t\t\tthis.txt{0}.Location = new System.Drawing.Point({1}, {2});" + Environment.NewLine +
            "\t\t\tthis.txt{0}.Name = \"txt{0}\";" + Environment.NewLine +
            "\t\t\tthis.txt{0}.Size = new System.Drawing.Size(221, 21);" + Environment.NewLine +
            "\t\t\tthis.txt{0}.TabIndex = {3};"
            , field, row2, col2, tabcount);
                sWriter.Write(area2 + Environment.NewLine);

                lstPnlCenter.Add(string.Format("\t\t\tthis.pnlCenter.AutoScroll = true;", field));//2015.11.27, 编辑界面的主界面的panel要自动添加滚动条
                lstPnlCenter.Add(string.Format("\t\t\tthis.pnlCenter.Controls.Add(this.lbl{0});", field));
                lstPnlCenter.Add(string.Format("\t\t\tthis.pnlCenter.Controls.Add(this.txt{0});", field));
            }

            var msg = string.Join(Environment.NewLine, lstPnlCenter);
            sWriter.Write(msg + Environment.NewLine);
        }

        private void WriteNew_UI(StreamWriter sWriter)//"int __new_UI;"
        {
            var table = (DataTable)this.gridColumns.DataSource;
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                var outline1 = string.Format("\t\t\tthis.lbl{0} = new System.Windows.Forms.Label();", field);
                var outline2 = string.Format("\t\t\tthis.txt{0} = new System.Windows.Forms.TextBox();", field);
                sWriter.Write(outline1 + Environment.NewLine);
                sWriter.Write(outline2 + Environment.NewLine);
            }
        }

        private void WriteDefine_UI(StreamWriter sWriter)//"int __Define_UI;"
        {
            var table = (DataTable)this.gridColumns.DataSource;
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                var outline1 = string.Format("\t\tprivate System.Windows.Forms.Label lbl{0};", field);
                var outline2 = string.Format("\t\tprivate System.Windows.Forms.TextBox txt{0};", field);
                sWriter.Write(outline1 + Environment.NewLine);
                sWriter.Write(outline2 + Environment.NewLine);
            }
        }
        #endregion

        #region Create_Edit_CS
        private void Create_Edit_CS(string tableName, string namespace2,string namespace_model)
        //private void Create_Edit_CS(string tableName, string namespace2)
        {
            var modelFileName = "model/FrmEdit.cs";
            var newFileName = "output/FrmEdit_" + tableName + ".cs";
            if (File.Exists(newFileName)) File.Delete(newFileName);
            var fileStream = File.Create(newFileName);

            StreamWriter sWriter = null;
            sWriter = new StreamWriter(fileStream);
            var lines = File.ReadAllLines(modelFileName, Encoding.UTF8);
            foreach (var line in lines)
            {
                string outline = string.Empty;
                if (line.Contains("__TableName"))
                    outline = line.Replace("__TableName", tableName);
                else if (line.Contains("__namespace_view"))
                    outline = line.Replace("__namespace_view", namespace2);
                else if (line.Contains("__namespace_model"))
                    outline = line.Replace("__namespace_model", namespace_model);
                else if (line.Contains("__datetime"))
                    outline = line.Replace("__datetime", DateTime.Now.ToString());
                else
                    outline = line;

                if (line.Contains("__UI_Field;"))//  txt类型.Text = info.类型;
                    WriteUI_Field(sWriter);
                else if (line.Contains("__Field_UI;"))//info.类型 = txt类型.Text;
                    WriteField_UI(sWriter);
                else if (line.Contains("__Fileds0"))//输出'{0}','{1}','{2}','{3}','{4}'
                    WriteFileds0(sWriter);
                else if (line.Contains("__info__Fileds"))//info.ID,info.Name
                    Write_info_Fileds(sWriter);
                else
                    sWriter.Write(outline + Environment.NewLine);

            }
            sWriter.Close();

        }

        private void Write_info_Fileds(StreamWriter sWriter)//info.ID,info.Name
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt") continue;
                lst.Add("info." + field);
            }
            lst.Add("User.UserID");
            var outmsg = string.Join(",", lst);
            outmsg = "\t\t\t\t" + outmsg + ");";
            sWriter.Write(outmsg + Environment.NewLine);
        }
        private void WriteFileds0(StreamWriter sWriter)//输出'{0}','{1}','{2}','{3}','{4}'
        {
            var table = (DataTable)this.gridColumns.DataSource;
            List<string> lst = new List<string>();
            int count = 0;
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt") continue;
                lst.Add("'{" + count.ToString() + "}'");
                count++;
            }
            lst.Add("'{" + count.ToString() + "}'");//UserID 2016.4.6
            var outmsg = string.Join(",", lst);
            outmsg = "\t\t\t\t\"" + outmsg + "\",";
            //sWriter.Write(outmsg + Environment.NewLine);
            sWriter.Write(outmsg + Environment.NewLine);
        }
        private void WriteUI_Field(StreamWriter sWriter)
        {
            var table = (DataTable)this.gridColumns.DataSource;
            CsType cstype = new CsType();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt") continue;
                var ftype = dr["ColumnType"].ToString();

                var fieldToString = field;
                var whatType = cstype.GetLower(ftype);
                if (whatType != "string") fieldToString += ".ToString()";
                var outline = string.Format("            txt{0}.Text = info.{1};", field, fieldToString);
                sWriter.Write(outline + Environment.NewLine);
            }
        }

        private void WriteField_UI(StreamWriter sWriter)
        {
            var table = (DataTable)this.gridColumns.DataSource;
            CsType cstype = new CsType();
            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt" || field == "ID" || field == "statu") continue;
                var ftype = dr["ColumnType"].ToString();

                var fieldParse = string.Format("txt{0}.Text;", field);
                var whatType = cstype.GetLower(ftype);
                if (whatType != "string")
                    fieldParse = string.Format("{0}.Parse(txt{1}.Text);", whatType, field);

                var outline = string.Format("            info.{0} = {1}", field, fieldParse);
                sWriter.Write(outline + Environment.NewLine);
            }
        }
        #endregion



        private void FrmCentre_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainFrom.uicofing.Clear();
            MainFrom.uicofing.Add("connectstring", txtConnString.Text);
            MainFrom.uicofing.Add("namespace_VIEW", txtNamespace_VIEW.Text);
            MainFrom.uicofing.Add("namespace_MODEL", txtNamespace_MODEL.Text);
            ObjectToFile.SaveToFile("serializeconfig.dat", MainFrom.uicofing);
        }

        private void btnReLoadConfig_Click(object sender, EventArgs e)
        {
            loadConfig();
        }

        //生成Update语句, 多表更新时候, a表的字段名和b表的字段名是一模一样的, mssql自带工具生成的等于号右边是空白. 我这个方法会补充好右边的.
        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            var tablename = txtTableName.Text;
            var table = (DataTable)this.gridColumns.DataSource;
            //CsType cstype = new CsType();
            var sb = new StringBuilder();
            sb.Append(string.Format("Update {0} set ",tablename));
            foreach (DataRow dr in table.Rows)
            {

                var field = dr["ColumnName"].ToString();
                if (field == "ID") continue;
                if (field == "CreateAt") continue;

                sb.Append(string.Format("{0}=b.{0},", field));
           
            }
            txtupdate.Text = sb.ToString();

            var sbInsert1 = new StringBuilder();
            var sbInsert2 = new StringBuilder();
            var sbInsert3 = new StringBuilder();
            sbInsert1.Append(string.Format("var sql = string.Format(\"INSERT INTO  {0} ( ", tablename));
            sbInsert2.Append(" VALUES (");
            string comma = "";
            int fIndex = 0;
            foreach (DataRow dr in table.Rows)
            {

                var field = dr["ColumnName"].ToString();
                if (field == "ID") continue;
                if (field == "CreateAt") continue;

                sbInsert1.Append(string.Format(comma+"{0}", field));
                sbInsert2.Append(string.Format(comma+"'[{0}]'", fIndex));
                sbInsert3.Append(string.Format(comma + "x.{0}", field));
                comma = ",";
                fIndex++;
            }
            sbInsert1.Append(")");
            sbInsert2.Append(")");
            //sbInsert3.Append(");");
            var strInsert2 = sbInsert2.ToString().Replace('[', '{').Replace(']', '}');
            txtupdate.AppendText("\r\n\r\n");

            txtupdate.AppendText(sbInsert1.ToString());
            txtupdate.AppendText(strInsert2);
            txtupdate.AppendText("\",");
            txtupdate.AppendText(sbInsert3.ToString() + ");");

            fIndex = 0;
            comma = "";
            var sbUpdate2 = new StringBuilder();
            sbUpdate2.Append(string.Format("var sql = string.Format(\"Update {0} set ", tablename));
            foreach (DataRow dr in table.Rows)
            {

                var field = dr["ColumnName"].ToString();
                if (field == "ID") continue;
                if (field == "CreateAt") continue;

                sbUpdate2.Append(string.Format(comma + "{0}='[{1}]'", field, fIndex));
                comma = ",";
                fIndex++;
            }
            var strUpdate2 = sbUpdate2.ToString().Replace('[', '{').Replace(']', '}');
            txtupdate.AppendText("\r\n\r\n");
            txtupdate.AppendText(strUpdate2);
            txtupdate.AppendText(string.Format(" where ID=[{0}]\",", fIndex).Replace('[', '{').Replace(']', '}'));
            txtupdate.AppendText(sbInsert3.ToString() + ",x.ID);");
        }

        //UI界面上的数据转换成实体类, 这个是针对DataGridViewRow来写的, 
        private void btn_Row_To_Entity_Click(object sender, EventArgs e)
        {
            var tablename = txtTableName.Text;
            var table = (DataTable)this.gridColumns.DataSource;
            CsType cstype = new CsType();
            var sb = new StringBuilder();
            sb.Append(string.Format(" {0} info = new {0}();\n", tablename));

            foreach (DataRow dr in table.Rows)
            {
                var field = dr["ColumnName"].ToString();
                if (field == "CreateAt" || field == "statu") continue;
                var ftype = dr["ColumnType"].ToString();

                var fieldParse = string.Format("dr.Cells[\"{0}\"].Value.ToString();", field);
                var whatType = cstype.GetLower(ftype);
                if (whatType != "string")
                    fieldParse = string.Format("{0}.Parse(dr.Cells[\"{1}\"].Value.ToString());", whatType, field);


                sb.Append(string.Format("info.{0} = {1}\n", field, fieldParse));
            }
            txtUI_Entity.Text = sb.ToString();
        }


        List<string> lstDef = new List<string>();
        Point lblpoint = new Point();
        Point txtpoint = new Point();
        int FiledCount = 0;
        int step = 10;
        private void btn生成设计代码_Click(object sender, EventArgs e)
        {
            lstDef.Clear();
            txtsjdm设计代码.Clear();
            txtDef.Clear();
            txtDataUI.Clear();
            txtUIData.Clear();

            lblpoint.X = 0;
            lblpoint.Y = 0;
            txtpoint.X = 80;
            txtpoint.Y = 0;

            foreach (DataGridViewRow dr in gridColumns.Rows)
            {
                var ColumnName = dr.Cells["ColumnName"].Value.ToString();
                CreateOneControl(ColumnName);//生成控件代码
                var ColumnType = dr.Cells["ColumnType"].Value.ToString();
                CreateUI_Data(ColumnName, ColumnType);//生成数据和UI互相取值
            }

            foreach (var item in lstDef)
            {
                 txtDef.AppendText(item);
            }

        }

        private void CreateUI_Data(string ColumnName, string ColumnType)
        {
            //throw new NotImplementedException();
        }

        private void CreateOneControl(string ColumnName)
        {
            FiledCount++;//根据字段个数计算出控件的位置

            var str_def_lbl = string.Format("private System.Windows.Forms.Label lbl{0};\r\n", ColumnName);
            var str_def_txt = string.Format("private System.Windows.Forms.TextBox txt{0};\r\n", ColumnName);

            var str_new_lbl = string.Format("this.lbl{0} = new System.Windows.Forms.Label();\r\n", ColumnName);
            var str_attr_lbl = string.Format(
            "this.lbl{0}.AutoSize = true;\r\n" +
            "this.lbl{0}.BackColor = System.Drawing.Color.Transparent;\r\n" +
            "this.lbl{0}.Location = new System.Drawing.Point({1}, {2});\r\n" +
            "this.lbl{0}.Name = \"lbl{0}\";\r\n" +
            "this.lbl{0}.Size = new System.Drawing.Size(123, 24);\r\n" +
            "this.lbl{0}.Text = \"{0}\";\r\n"+
            "this.Controls.Add(this.lbl{0});\r\n"
            , ColumnName, lblpoint.X, lblpoint.Y);
            lblpoint.Y = (FiledCount % step)* 30;
            lblpoint.X = (FiledCount / step) * 250;


            txtsjdm设计代码.AppendText(str_new_lbl);
            txtsjdm设计代码.AppendText(str_attr_lbl);

            var str_new_txt = string.Format("this.txt{0} = new System.Windows.Forms.TextBox();\r\n", ColumnName);
            var str_attr_txt = string.Format(
            "this.txt{0}.Location = new System.Drawing.Point({1}, {2});\r\n" +
			"this.txt{0}.Name = \"txt姓名\";\r\n" +
            "this.txt{0}.Size = new System.Drawing.Size(150, 21);\r\n" +
			"this.txt{0}.TabIndex = {3};\r\n"+
            "this.Controls.Add(this.txt{0});\r\n"
             , ColumnName, txtpoint.X, txtpoint.Y,   FiledCount);
            txtpoint.Y = (FiledCount % step) * 30;
            txtpoint.X = (FiledCount / step) * 250 + 80;


            txtsjdm设计代码.AppendText(str_new_txt);
            txtsjdm设计代码.AppendText(str_attr_txt);

            lstDef.Add(str_def_lbl);
            lstDef.Add(str_def_txt);
        
        }

        private void btnCheat_Click(object sender, EventArgs e)
        {
            var tableName = txtTableName.Text == "" ? Default_tableName : txtTableName.Text;
            this.gridColumns.DataSource = SqlQuery.GetColumns(Default_connString, Default_database, tableName);
        }

    
      

      
    }
}
