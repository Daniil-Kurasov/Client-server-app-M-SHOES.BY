
namespace M_SHOES.BY
{
    partial class ConfirmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmail));
            this.elipseConfirmEmail = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.confirmTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.infoRTB = new M_SHOES.BY.RichTextBoxCustom();
            this.iconPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.confirmB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).BeginInit();
            this.SuspendLayout();
            // 
            // elipseConfirmEmail
            // 
            this.elipseConfirmEmail.BorderRadius = 40;
            this.elipseConfirmEmail.TargetControl = this;
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
            this.panel.Controls.Add(this.exitControlBox);
            this.panel.Controls.Add(this.confirmTB);
            this.panel.Controls.Add(this.infoRTB);
            this.panel.Controls.Add(this.iconPB);
            this.panel.Controls.Add(this.confirmB);
            this.panel.CustomBorderColor = System.Drawing.Color.Bisque;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(531, 351);
            this.panel.TabIndex = 74;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.BorderColor = System.Drawing.Color.White;
            this.exitControlBox.BorderRadius = 15;
            this.exitControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.exitControlBox.FillColor = System.Drawing.Color.DimGray;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(486, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 105;
            // 
            // confirmTB
            // 
            this.confirmTB.Animated = true;
            this.confirmTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.confirmTB.BorderRadius = 20;
            this.confirmTB.BorderThickness = 2;
            this.confirmTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmTB.DefaultText = "";
            this.confirmTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmTB.DisabledState.Parent = this.confirmTB;
            this.confirmTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmTB.FillColor = System.Drawing.Color.Gainsboro;
            this.confirmTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmTB.FocusedState.Parent = this.confirmTB;
            this.confirmTB.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.confirmTB.ForeColor = System.Drawing.Color.Black;
            this.confirmTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmTB.HoverState.Parent = this.confirmTB;
            this.confirmTB.Location = new System.Drawing.Point(108, 148);
            this.confirmTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.confirmTB.MaxLength = 5;
            this.confirmTB.Name = "confirmTB";
            this.confirmTB.PasswordChar = '\0';
            this.confirmTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.confirmTB.PlaceholderText = "введите код";
            this.confirmTB.SelectedText = "";
            this.confirmTB.ShadowDecoration.Parent = this.confirmTB;
            this.confirmTB.Size = new System.Drawing.Size(300, 77);
            this.confirmTB.TabIndex = 104;
            this.confirmTB.Tag = "";
            this.confirmTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmTB_KeyPress);
            // 
            // infoRTB
            // 
            this.infoRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRTB.Enabled = false;
            this.infoRTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoRTB.ForeColor = System.Drawing.Color.DimGray;
            this.infoRTB.Location = new System.Drawing.Point(108, 22);
            this.infoRTB.Name = "infoRTB";
            this.infoRTB.ReadOnly = true;
            this.infoRTB.Size = new System.Drawing.Size(313, 76);
            this.infoRTB.TabIndex = 72;
            this.infoRTB.Text = "На почту был выслан код подтверждения";
            // 
            // iconPB
            // 
            this.iconPB.Image = global::M_SHOES.BY.Properties.Resources.Error;
            this.iconPB.Location = new System.Drawing.Point(12, 12);
            this.iconPB.Name = "iconPB";
            this.iconPB.ShadowDecoration.Parent = this.iconPB;
            this.iconPB.Size = new System.Drawing.Size(90, 86);
            this.iconPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPB.TabIndex = 71;
            this.iconPB.TabStop = false;
            // 
            // confirmB
            // 
            this.confirmB.Animated = true;
            this.confirmB.BorderRadius = 10;
            this.confirmB.CheckedState.Parent = this.confirmB;
            this.confirmB.CustomImages.Parent = this.confirmB;
            this.confirmB.FillColor = System.Drawing.Color.Green;
            this.confirmB.FillColor2 = System.Drawing.Color.Teal;
            this.confirmB.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.confirmB.ForeColor = System.Drawing.Color.White;
            this.confirmB.HoverState.Parent = this.confirmB;
            this.confirmB.Location = new System.Drawing.Point(9, 280);
            this.confirmB.Name = "confirmB";
            this.confirmB.ShadowDecoration.Parent = this.confirmB;
            this.confirmB.Size = new System.Drawing.Size(513, 62);
            this.confirmB.TabIndex = 168;
            this.confirmB.Text = "Подтвердить";
            this.confirmB.Click += new System.EventHandler(this.ConfirmB_Click);
            // 
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 351);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M-SHOES.BY";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseConfirmEmail;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2PictureBox iconPB;
        private RichTextBoxCustom infoRTB;
        private Guna.UI2.WinForms.Guna2TextBox confirmTB;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private Guna.UI2.WinForms.Guna2GradientButton confirmB;
    }
}