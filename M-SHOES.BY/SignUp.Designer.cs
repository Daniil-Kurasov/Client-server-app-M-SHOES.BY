
namespace M_SHOES.BY
{
    partial class SignUp
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
            this.reenterPasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remindPasswordLabel = new System.Windows.Forms.Label();
            this.signInLabel = new System.Windows.Forms.Label();
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
            this.flowLayoutPanel1.Controls.Add(this.reenterPasswordTB);
            this.flowLayoutPanel1.Controls.Add(this.nameTB);
            this.flowLayoutPanel1.Controls.Add(this.phoneTB);
            this.flowLayoutPanel1.Controls.Add(this.signUpButton);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 517);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.5F);
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 109;
            this.label1.Text = "Регистрация";
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
            // reenterPasswordTB
            // 
            this.reenterPasswordTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.reenterPasswordTB.BorderRadius = 10;
            this.reenterPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reenterPasswordTB.DefaultText = "";
            this.reenterPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.reenterPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.reenterPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reenterPasswordTB.DisabledState.Parent = this.reenterPasswordTB;
            this.reenterPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.reenterPasswordTB.FillColor = System.Drawing.Color.Gainsboro;
            this.reenterPasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reenterPasswordTB.FocusedState.Parent = this.reenterPasswordTB;
            this.reenterPasswordTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.reenterPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.reenterPasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.reenterPasswordTB.HoverState.Parent = this.reenterPasswordTB;
            this.reenterPasswordTB.IconLeftSize = new System.Drawing.Size(23, 23);
            this.reenterPasswordTB.IconRight = global::M_SHOES.BY.Properties.Resources.Hide;
            this.reenterPasswordTB.IconRightSize = new System.Drawing.Size(23, 23);
            this.reenterPasswordTB.Location = new System.Drawing.Point(4, 179);
            this.reenterPasswordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.reenterPasswordTB.MaxLength = 30;
            this.reenterPasswordTB.Name = "reenterPasswordTB";
            this.reenterPasswordTB.PasswordChar = '●';
            this.reenterPasswordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.reenterPasswordTB.PlaceholderText = "повторно введите пароль";
            this.reenterPasswordTB.SelectedText = "";
            this.reenterPasswordTB.ShadowDecoration.Parent = this.reenterPasswordTB;
            this.reenterPasswordTB.Size = new System.Drawing.Size(300, 40);
            this.reenterPasswordTB.TabIndex = 105;
            this.reenterPasswordTB.Tag = "";
            this.reenterPasswordTB.TextChanged += new System.EventHandler(this.ReenterPasswordTB_TextChanged);
            this.reenterPasswordTB.IconRightClick += new System.EventHandler(this.ReenterPasswordTB_IconRightClick);
            this.reenterPasswordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReenterPasswordTB_KeyPress);
            // 
            // nameTB
            // 
            this.nameTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.nameTB.BorderRadius = 10;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.DefaultText = "";
            this.nameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.DisabledState.Parent = this.nameTB;
            this.nameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTB.FillColor = System.Drawing.Color.Gainsboro;
            this.nameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.FocusedState.Parent = this.nameTB;
            this.nameTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.nameTB.ForeColor = System.Drawing.Color.Black;
            this.nameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTB.HoverState.Parent = this.nameTB;
            this.nameTB.Location = new System.Drawing.Point(4, 243);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.nameTB.MaxLength = 20;
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameTB.PlaceholderText = "имя";
            this.nameTB.SelectedText = "";
            this.nameTB.ShadowDecoration.Parent = this.nameTB;
            this.nameTB.Size = new System.Drawing.Size(300, 40);
            this.nameTB.TabIndex = 106;
            this.nameTB.Tag = "";
            this.nameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTB_KeyPress);
            // 
            // phoneTB
            // 
            this.phoneTB.BorderColor = System.Drawing.Color.Gainsboro;
            this.phoneTB.BorderRadius = 10;
            this.phoneTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTB.DefaultText = "";
            this.phoneTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTB.DisabledState.Parent = this.phoneTB;
            this.phoneTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTB.FillColor = System.Drawing.Color.Gainsboro;
            this.phoneTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTB.FocusedState.Parent = this.phoneTB;
            this.phoneTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phoneTB.ForeColor = System.Drawing.Color.Black;
            this.phoneTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTB.HoverState.Parent = this.phoneTB;
            this.phoneTB.Location = new System.Drawing.Point(4, 307);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 20);
            this.phoneTB.MaxLength = 13;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.PasswordChar = '\0';
            this.phoneTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneTB.PlaceholderText = "+375XXXXXXXXX";
            this.phoneTB.SelectedText = "";
            this.phoneTB.ShadowDecoration.Parent = this.phoneTB;
            this.phoneTB.Size = new System.Drawing.Size(300, 40);
            this.phoneTB.TabIndex = 107;
            this.phoneTB.Tag = "";
            this.phoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB_KeyPress);
            // 
            // signUpButton
            // 
            this.signUpButton.Animated = true;
            this.signUpButton.BorderRadius = 10;
            this.signUpButton.CheckedState.Parent = this.signUpButton;
            this.signUpButton.CustomImages.Parent = this.signUpButton;
            this.signUpButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.HoverState.Parent = this.signUpButton;
            this.signUpButton.Location = new System.Drawing.Point(3, 370);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.ShadowDecoration.Parent = this.signUpButton;
            this.signUpButton.Size = new System.Drawing.Size(301, 45);
            this.signUpButton.TabIndex = 108;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.remindPasswordLabel);
            this.panel1.Controls.Add(this.signInLabel);
            this.panel1.Location = new System.Drawing.Point(0, 418);
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
            this.remindPasswordLabel.Location = new System.Drawing.Point(70, 25);
            this.remindPasswordLabel.Margin = new System.Windows.Forms.Padding(60, 25, 3, 3);
            this.remindPasswordLabel.Name = "remindPasswordLabel";
            this.remindPasswordLabel.Size = new System.Drawing.Size(169, 22);
            this.remindPasswordLabel.TabIndex = 91;
            this.remindPasswordLabel.Text = "Напомнить пароль";
            this.remindPasswordLabel.Click += new System.EventHandler(this.RemindPasswordLabel_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline);
            this.signInLabel.ForeColor = System.Drawing.Color.Black;
            this.signInLabel.Location = new System.Drawing.Point(125, 49);
            this.signInLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(50, 22);
            this.signInLabel.TabIndex = 92;
            this.signInLabel.Text = "Вход";
            this.signInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "SignUp";
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
        private Guna.UI2.WinForms.Guna2TextBox reenterPasswordTB;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private Guna.UI2.WinForms.Guna2TextBox phoneTB;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label remindPasswordLabel;
        private System.Windows.Forms.Label signInLabel;
    }
}
