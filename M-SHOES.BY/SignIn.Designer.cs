
namespace M_SHOES.BY
{
    partial class SignIn
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remindPasswordLabel = new System.Windows.Forms.Label();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.emailTB);
            this.flowLayoutPanel1.Controls.Add(this.passwordTB);
            this.flowLayoutPanel1.Controls.Add(this.signInButton);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 517);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.5F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 27);
            this.label1.TabIndex = 109;
            this.label1.Text = "Вход";
            // 
            // emailTB
            // 
            this.emailTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.emailTB.BorderRadius = 10;
            this.emailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTB.DefaultText = "";
            this.emailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.DisabledState.Parent = this.emailTB;
            this.emailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTB.FillColor = System.Drawing.Color.Gainsboro;
            this.emailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.FocusedState.Parent = this.emailTB;
            this.emailTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.emailTB.ForeColor = System.Drawing.Color.Black;
            this.emailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTB.HoverState.Parent = this.emailTB;
            this.emailTB.Location = new System.Drawing.Point(4, 51);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.emailTB.MaxLength = 350;
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.emailTB.PlaceholderText = "электронная почта";
            this.emailTB.SelectedText = "";
            this.emailTB.ShadowDecoration.Parent = this.emailTB;
            this.emailTB.Size = new System.Drawing.Size(300, 40);
            this.emailTB.TabIndex = 103;
            this.emailTB.Tag = "";
            this.emailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            this.emailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTB_KeyPress);
            // 
            // passwordTB
            // 
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
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.HoverState.Parent = this.passwordTB;
            this.passwordTB.IconRight = global::M_SHOES.BY.Properties.Resources.Hide;
            this.passwordTB.IconRightSize = new System.Drawing.Size(23, 23);
            this.passwordTB.Location = new System.Drawing.Point(4, 115);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "пароль";
            this.passwordTB.SelectedText = "";
            this.passwordTB.ShadowDecoration.Parent = this.passwordTB;
            this.passwordTB.Size = new System.Drawing.Size(300, 40);
            this.passwordTB.TabIndex = 104;
            this.passwordTB.Tag = "";
            this.passwordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.passwordTB.IconRightClick += new System.EventHandler(this.PasswordTB_IconRightClick);
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTB_KeyPress);
            // 
            // signInButton
            // 
            this.signInButton.Animated = true;
            this.signInButton.BorderRadius = 10;
            this.signInButton.CheckedState.Parent = this.signInButton;
            this.signInButton.CustomImages.Parent = this.signInButton;
            this.signInButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.HoverState.Parent = this.signInButton;
            this.signInButton.Location = new System.Drawing.Point(3, 178);
            this.signInButton.Name = "signInButton";
            this.signInButton.ShadowDecoration.Parent = this.signInButton;
            this.signInButton.Size = new System.Drawing.Size(301, 45);
            this.signInButton.TabIndex = 108;
            this.signInButton.Text = "Войти";
            this.signInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.remindPasswordLabel);
            this.panel1.Controls.Add(this.signUpLabel);
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 120);
            this.panel1.TabIndex = 110;
            // 
            // remindPasswordLabel
            // 
            this.remindPasswordLabel.AutoSize = true;
            this.remindPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remindPasswordLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline);
            this.remindPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.remindPasswordLabel.Location = new System.Drawing.Point(72, 25);
            this.remindPasswordLabel.Margin = new System.Windows.Forms.Padding(60, 25, 3, 3);
            this.remindPasswordLabel.Name = "remindPasswordLabel";
            this.remindPasswordLabel.Size = new System.Drawing.Size(169, 22);
            this.remindPasswordLabel.TabIndex = 91;
            this.remindPasswordLabel.Text = "Напомнить пароль";
            this.remindPasswordLabel.Click += new System.EventHandler(this.RemindPasswordLabel_Click);
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline);
            this.signUpLabel.ForeColor = System.Drawing.Color.Black;
            this.signUpLabel.Location = new System.Drawing.Point(96, 49);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(85, 0, 3, 3);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(119, 22);
            this.signUpLabel.TabIndex = 90;
            this.signUpLabel.Text = "Регистрация";
            this.signUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "SignIn";
            this.Size = new System.Drawing.Size(321, 517);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private Guna.UI2.WinForms.Guna2Button signInButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label remindPasswordLabel;
        private System.Windows.Forms.Label signUpLabel;
    }
}
