using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

namespace JBuilder2
{
    class ToClass
    {
        private void 生成实体类()
        {
            #region 准备一个代码编译器单元
            CodeCompileUnit unit = new CodeCompileUnit();
            #endregion

            #region 命名空间
            CodeNamespace CurrentNameSpace = new CodeNamespace("生成代码的实验");
            CurrentNameSpace.Imports.Add(new CodeNamespaceImport("System"));
            CurrentNameSpace.Imports.Add(new CodeNamespaceImport("System.Text"));
            //CodeTypeDeclaration ctd = new CodeTypeDeclaration(Name); 
            //return CurrentNameSpace;
            #endregion

            #region  类
            CodeTypeDeclaration ctd = new CodeTypeDeclaration("T_AJ_INSURE");
            ctd.IsClass = true;
            ctd.Attributes = MemberAttributes.Public;
            #endregion

            #region 声明方法(程序入口点)?
            //CodeEntryPointMethod method = new CodeEntryPointMethod();
            //method.Attributes = MemberAttributes.Public;
            #endregion

            #region 声明方法？
            CodeMemberProperty property = new CodeMemberProperty();
            property.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            property.Name = "ID";
            property.HasGet = true;
            property.HasSet = true;
            property.Type = new CodeTypeReference(typeof(System.Int32));
            property.Comments.Add(new CodeCommentStatement("这是ID属性"));
            #endregion

            #region 把类放在命名空间里面
            CurrentNameSpace.Types.Add(ctd);
            #endregion

            #region 把该命名空间加入到编译器单元的命名空间集合中
            unit.Namespaces.Add(CurrentNameSpace);
            #endregion

            #region 把该命名空间加入到编译器单元的命名空间集合中
            unit.Namespaces.Add(CurrentNameSpace);
            #endregion

            #region 加入这种方法
            ctd.Members.Add(property);
            #endregion

            #region 添加字段
            //CodeMemberField field = new CodeMemberField(typeof(System.String), "_Id");
            //field.Attributes = MemberAttributes.Private;
            //ctd.Members.Add(field);
            #endregion

            string outputFile = "\\Customer.cs";
            string path = Application.StartupPath;

            #region 生成代码
            //生成代码

            CodeDomProvider provider = CodeDomProvider.CreateProvider("C#");

            CodeGeneratorOptions options = new CodeGeneratorOptions();

            options.BracingStyle = "C";

            options.BlankLinesBetweenMembers = true;

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(path + outputFile))
            {


                provider.GenerateCodeFromCompileUnit(unit, sw, options);

            }
            #endregion
        }
    }
    
}
