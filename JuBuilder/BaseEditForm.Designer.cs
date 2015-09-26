namespace JuBuilder
{
    partial class BaseEditForm
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
            this.pnlCenter = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.PnlBottom = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCenter
            // 
            this.pnlCenter.CanvasColor = System.Drawing.SystemColors.Control;
            this.pnlCenter.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.pnlCenter.Controls.Add(this.btnSave);
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(784, 561);
            // 
            // 
            // 
            this.pnlCenter.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.pnlCenter.Style.BackColorGradientAngle = 90;
            this.pnlCenter.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.pnlCenter.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCenter.Style.BorderBottomWidth = 1;
            this.pnlCenter.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.pnlCenter.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCenter.Style.BorderLeftWidth = 1;
            this.pnlCenter.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCenter.Style.BorderRightWidth = 1;
            this.pnlCenter.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.pnlCenter.Style.BorderTopWidth = 1;
            this.pnlCenter.Style.CornerDiameter = 4;
            this.pnlCenter.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.pnlCenter.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.pnlCenter.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.pnlCenter.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.pnlCenter.TabIndex = 0;
            // 
            // PnlBottom
            // 
            this.PnlBottom.CanvasColor = System.Drawing.SystemColors.Control;
            this.PnlBottom.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
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
            this.PnlBottom.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(690, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保  存";
            // 
            // BaseEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.PnlBottom);
            this.Controls.Add(this.pnlCenter);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "BaseEditForm";
            this.Text = "BaseEditForm";
            this.Load += new System.EventHandler(this.BaseEditForm_Load);
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected DevComponents.DotNetBar.Controls.GroupPanel pnlCenter;
        protected DevComponents.DotNetBar.Controls.GroupPanel PnlBottom;
        protected DevComponents.DotNetBar.ButtonX btnSave;
    }
}