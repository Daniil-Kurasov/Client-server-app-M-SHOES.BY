
namespace M_SHOES.BY
{
    partial class ConfirmPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPassword));
            this.elipseConfirmPassword = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.enterPasswordL = new System.Windows.Forms.Label();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.confirmB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseConfirmPassword
            // 
            this.elipseConfirmPassword.BorderRadius = 40;
            this.elipseConfirmPassword.TargetControl = this;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderColor = System.Drawing.Color.DimGray;
            this.panel.BorderRadius = 16;
            this.panel.BorderThickness = 5;
            this.panel.Controls.Add(this.enterPasswordL);
            this.panel.Controls.Add(this.passwordTB);
            this.panel.Controls.Add(this.exitControlBox);
            this.panel.Controls.Add(this.confirmB);
            this.panel.CustomBorderColor = System.Drawing.Color.Black;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(531, 257);
            this.panel.TabIndex = 75;
            // 
            // enterPasswordL
            // 
            this.enterPasswordL.AutoSize = true;
            this.enterPasswordL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterPasswordL.ForeColor = System.Drawing.Color.Gray;
            this.enterPasswordL.Location = new System.Drawing.Point(21, 66);
            this.enterPasswordL.Name = "enterPasswordL";
            this.enterPasswordL.Size = new System.Drawing.Size(177, 30);
            this.enterPasswordL.TabIndex = 108;
            this.enterPasswordL.Text = "Введите пароль:";
            // 
            // passwordTB
            // 
            this.passwordTB.Animated = true;
            this.passwordTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.BorderRadius = 10;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.Parent = this.passwordTB;
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FillColor = System.Drawing.Color.Gainsboro;
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.FocusedState.Parent = this.passwordTB;
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.HoverState.Parent = this.passwordTB;
            this.passwordTB.IconLeftSize = new System.Drawing.Size(0, 0);
            this.passwordTB.IconRight = global::M_SHOES.BY.Properties.Resources.Hide;
            this.passwordTB.IconRightSize = new System.Drawing.Size(33, 33);
            this.passwordTB.Location = new System.Drawing.Point(12, 101);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(5, 5, 5, 27);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "пароль";
            this.passwordTB.SelectedText = "";
            this.passwordTB.ShadowDecoration.Parent = this.passwordTB;
            this.passwordTB.Size = new System.Drawing.Size(507, 47);
            this.passwordTB.TabIndex = 107;
            this.passwordTB.Tag = "";
            this.passwordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.passwordTB.IconRightClick += new System.EventHandler(this.PasswordTB_IconRightClick);
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTB_KeyPress);
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
            // confirmB
            // 
            this.confirmB.Animated = true;
            this.confirmB.BorderRadius = 10;
            this.confirmB.CheckedState.Parent = this.confirmB;
            this.confirmB.CustomImages.Parent = this.confirmB;
            this.confirmB.FillColor = System.Drawing.Color.Green;
            this.confirmB.FillColor2 = System.Drawing.Color.Teal;
            this.confirmB.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.confirmB.ForeColor = System.Drawing.Color.White;
            this.confirmB.HoverState.Parent = this.confirmB;
            this.confirmB.Location = new System.Drawing.Point(9, 187);
            this.confirmB.Name = "confirmB";
            this.confirmB.ShadowDecoration.Parent = this.confirmB;
            this.confirmB.Size = new System.Drawing.Size(513, 62);
            this.confirmB.TabIndex = 167;
            this.confirmB.Text = "Подтвердить";
            this.confirmB.Click += new System.EventHandler(this.ConfirmB_Click);
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this.panel;
            // 
            // ConfirmPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 257);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M-SHOES.BY";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseConfirmPassword;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.Label enterPasswordL;
        private Guna.UI2.WinForms.Guna2GradientButton confirmB;
    }
}