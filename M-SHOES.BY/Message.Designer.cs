
namespace M_SHOES.BY
{
    partial class Message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.elipseMessage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.okB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.iconPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.infoRTB = new M_SHOES.BY.RichTextBoxCustom();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseMessage
            // 
            this.elipseMessage.BorderRadius = 40;
            this.elipseMessage.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this.panel;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderColor = System.Drawing.Color.DimGray;
            this.panel.BorderRadius = 16;
            this.panel.BorderThickness = 5;
            this.panel.Controls.Add(this.okB);
            this.panel.Controls.Add(this.iconPB);
            this.panel.CustomBorderColor = System.Drawing.Color.Black;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(531, 351);
            this.panel.TabIndex = 73;
            // 
            // okB
            // 
            this.okB.Animated = true;
            this.okB.BorderRadius = 10;
            this.okB.CheckedState.Parent = this.okB;
            this.okB.CustomImages.Parent = this.okB;
            this.okB.FillColor = System.Drawing.Color.DarkOrchid;
            this.okB.FillColor2 = System.Drawing.Color.Teal;
            this.okB.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.okB.ForeColor = System.Drawing.Color.White;
            this.okB.HoverState.Parent = this.okB;
            this.okB.Location = new System.Drawing.Point(9, 280);
            this.okB.Name = "okB";
            this.okB.ShadowDecoration.Parent = this.okB;
            this.okB.Size = new System.Drawing.Size(513, 62);
            this.okB.TabIndex = 169;
            this.okB.Text = "ОК";
            this.okB.Click += new System.EventHandler(this.OkB_Click);
            // 
            // iconPB
            // 
            this.iconPB.Image = ((System.Drawing.Image)(resources.GetObject("iconPB.Image")));
            this.iconPB.Location = new System.Drawing.Point(219, 22);
            this.iconPB.Name = "iconPB";
            this.iconPB.ShadowDecoration.Parent = this.iconPB;
            this.iconPB.Size = new System.Drawing.Size(90, 86);
            this.iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPB.TabIndex = 71;
            this.iconPB.TabStop = false;
            // 
            // infoRTB
            // 
            this.infoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRTB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoRTB.ForeColor = System.Drawing.Color.DimGray;
            this.infoRTB.Location = new System.Drawing.Point(22, 137);
            this.infoRTB.Name = "infoRTB";
            this.infoRTB.ReadOnly = true;
            this.infoRTB.Size = new System.Drawing.Size(484, 115);
            this.infoRTB.TabIndex = 70;
            this.infoRTB.TabStop = false;
            this.infoRTB.Text = "";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.infoRTB);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M-SHOES.BY";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseMessage;
        private RichTextBoxCustom infoRTB;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2PictureBox iconPB;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2GradientButton okB;
    }
}