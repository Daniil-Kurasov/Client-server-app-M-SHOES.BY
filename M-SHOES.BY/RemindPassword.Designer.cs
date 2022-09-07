
namespace M_SHOES.BY
{
    partial class RemindPassword
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
            this.confirmButton = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.signInLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.emailTB);
            this.flowLayoutPanel1.Controls.Add(this.confirmButton);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(321, 517);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.5F);
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 109;
            this.label1.Text = "Напоминание пароля";
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
            // confirmButton
            // 
            this.confirmButton.Animated = true;
            this.confirmButton.BorderRadius = 10;
            this.confirmButton.CheckedState.Parent = this.confirmButton;
            this.confirmButton.CustomImages.Parent = this.confirmButton;
            this.confirmButton.FillColor = System.Drawing.Color.CornflowerBlue;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.HoverState.Parent = this.confirmButton;
            this.confirmButton.Location = new System.Drawing.Point(3, 114);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.ShadowDecoration.Parent = this.confirmButton;
            this.confirmButton.Size = new System.Drawing.Size(301, 45);
            this.confirmButton.TabIndex = 108;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.signUpLabel);
            this.panel1.Controls.Add(this.signInLabel);
            this.panel1.Location = new System.Drawing.Point(0, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 120);
            this.panel1.TabIndex = 110;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpLabel.ForeColor = System.Drawing.Color.Black;
            this.signUpLabel.Location = new System.Drawing.Point(94, 25);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(85, 0, 3, 3);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(119, 22);
            this.signUpLabel.TabIndex = 90;
            this.signUpLabel.Text = "Регистрация";
            this.signUpLabel.Click += new System.EventHandler(this.SignUpLabel_Click);
            // 
            // signInLabel
            // 
            this.signInLabel.AutoSize = true;
            this.signInLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLabel.ForeColor = System.Drawing.Color.Black;
            this.signInLabel.Location = new System.Drawing.Point(125, 49);
            this.signInLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.signInLabel.Name = "signInLabel";
            this.signInLabel.Size = new System.Drawing.Size(50, 22);
            this.signInLabel.TabIndex = 92;
            this.signInLabel.Text = "Вход";
            this.signInLabel.Click += new System.EventHandler(this.SignInLabel_Click);
            // 
            // RemindPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "RemindPassword";
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
        private Guna.UI2.WinForms.Guna2Button confirmButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label signInLabel;
    }
}
