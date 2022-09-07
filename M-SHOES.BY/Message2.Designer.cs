
namespace M_SHOES.BY
{
    partial class Message2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message2));
            this.elipseMessage2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.infoRTB = new M_SHOES.BY.RichTextBoxCustom();
            this.yesB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.notB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseMessage2
            // 
            this.elipseMessage2.BorderRadius = 40;
            this.elipseMessage2.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this.panel;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderColor = System.Drawing.Color.DimGray;
            this.panel.BorderRadius = 16;
            this.panel.BorderThickness = 5;
            this.panel.Controls.Add(this.iconPB);
            this.panel.Controls.Add(this.infoRTB);
            this.panel.Controls.Add(this.yesB);
            this.panel.Controls.Add(this.notB);
            this.panel.CustomBorderColor = System.Drawing.Color.Black;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(531, 271);
            this.panel.TabIndex = 74;
            // 
            // iconPB
            // 
            this.iconPB.Image = ((System.Drawing.Image)(resources.GetObject("iconPB.Image")));
            this.iconPB.Location = new System.Drawing.Point(239, 12);
            this.iconPB.Name = "iconPB";
            this.iconPB.ShadowDecoration.Parent = this.iconPB;
            this.iconPB.Size = new System.Drawing.Size(50, 46);
            this.iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPB.TabIndex = 72;
            this.iconPB.TabStop = false;
            // 
            // infoRTB
            // 
            this.infoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRTB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoRTB.ForeColor = System.Drawing.Color.DimGray;
            this.infoRTB.Location = new System.Drawing.Point(23, 73);
            this.infoRTB.Name = "infoRTB";
            this.infoRTB.ReadOnly = true;
            this.infoRTB.Size = new System.Drawing.Size(486, 111);
            this.infoRTB.TabIndex = 71;
            this.infoRTB.TabStop = false;
            this.infoRTB.Text = "";
            // 
            // yesB
            // 
            this.yesB.Animated = true;
            this.yesB.BorderRadius = 20;
            this.yesB.CheckedState.Parent = this.yesB;
            this.yesB.CustomImages.Parent = this.yesB;
            this.yesB.FillColor = System.Drawing.Color.SlateBlue;
            this.yesB.FillColor2 = System.Drawing.Color.Teal;
            this.yesB.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.yesB.ForeColor = System.Drawing.Color.White;
            this.yesB.HoverState.Parent = this.yesB;
            this.yesB.Location = new System.Drawing.Point(9, 200);
            this.yesB.Name = "yesB";
            this.yesB.ShadowDecoration.Parent = this.yesB;
            this.yesB.Size = new System.Drawing.Size(256, 62);
            this.yesB.TabIndex = 169;
            this.yesB.Text = "Да";
            this.yesB.Click += new System.EventHandler(this.YesB_Click);
            // 
            // notB
            // 
            this.notB.Animated = true;
            this.notB.BorderRadius = 20;
            this.notB.CheckedState.Parent = this.notB;
            this.notB.CustomImages.Parent = this.notB;
            this.notB.FillColor = System.Drawing.Color.Teal;
            this.notB.FillColor2 = System.Drawing.Color.SlateBlue;
            this.notB.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.notB.ForeColor = System.Drawing.Color.White;
            this.notB.HoverState.Parent = this.notB;
            this.notB.Location = new System.Drawing.Point(265, 200);
            this.notB.Name = "notB";
            this.notB.ShadowDecoration.Parent = this.notB;
            this.notB.Size = new System.Drawing.Size(256, 62);
            this.notB.TabIndex = 170;
            this.notB.Text = "Нет";
            this.notB.Click += new System.EventHandler(this.NotB_Click);
            // 
            // Message2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 271);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M-SHOES.BY";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseMessage2;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private RichTextBoxCustom infoRTB;
        private Guna.UI2.WinForms.Guna2PictureBox iconPB;
        private Guna.UI2.WinForms.Guna2GradientButton notB;
        private Guna.UI2.WinForms.Guna2GradientButton yesB;
    }
}