
namespace M_SHOES.BY
{
    partial class UsersEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.roleCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.emailL = new System.Windows.Forms.Label();
            this.emailTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordL = new System.Windows.Forms.Label();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.nameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.RBM_IB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LBM_IB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dragDropIB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.roleCB);
            this.flowLayoutPanel1.Controls.Add(this.emailL);
            this.flowLayoutPanel1.Controls.Add(this.emailTB);
            this.flowLayoutPanel1.Controls.Add(this.passwordL);
            this.flowLayoutPanel1.Controls.Add(this.passwordTB);
            this.flowLayoutPanel1.Controls.Add(this.nameL);
            this.flowLayoutPanel1.Controls.Add(this.nameTB);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.phoneTB);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(611, 794);
            this.flowLayoutPanel1.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 108;
            this.label2.Text = "роль";
            // 
            // roleCB
            // 
            this.roleCB.Animated = true;
            this.roleCB.BackColor = System.Drawing.Color.Transparent;
            this.roleCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.roleCB.BorderRadius = 10;
            this.roleCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.roleCB.DropDownHeight = 150;
            this.roleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleCB.FillColor = System.Drawing.Color.Gainsboro;
            this.roleCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roleCB.FocusedState.Parent = this.roleCB;
            this.roleCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.roleCB.ForeColor = System.Drawing.Color.Black;
            this.roleCB.HoverState.Parent = this.roleCB;
            this.roleCB.IntegralHeight = false;
            this.roleCB.ItemHeight = 34;
            this.roleCB.Items.AddRange(new object[] {
            "администратор",
            "пользователь"});
            this.roleCB.ItemsAppearance.Parent = this.roleCB;
            this.roleCB.Location = new System.Drawing.Point(4, 92);
            this.roleCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.roleCB.Name = "roleCB";
            this.roleCB.ShadowDecoration.Parent = this.roleCB;
            this.roleCB.Size = new System.Drawing.Size(593, 40);
            this.roleCB.TabIndex = 135;
            // 
            // emailL
            // 
            this.emailL.AutoSize = true;
            this.emailL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.emailL.ForeColor = System.Drawing.Color.DimGray;
            this.emailL.Location = new System.Drawing.Point(5, 152);
            this.emailL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(228, 23);
            this.emailL.TabIndex = 111;
            this.emailL.Text = "электронная почта (0 / 350)";
            // 
            // emailTB
            // 
            this.emailTB.Animated = true;
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
            this.emailTB.Location = new System.Drawing.Point(4, 179);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.emailTB.MaxLength = 350;
            this.emailTB.Name = "emailTB";
            this.emailTB.PasswordChar = '\0';
            this.emailTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.emailTB.PlaceholderText = "";
            this.emailTB.SelectedText = "";
            this.emailTB.ShadowDecoration.Parent = this.emailTB;
            this.emailTB.Size = new System.Drawing.Size(593, 40);
            this.emailTB.TabIndex = 112;
            this.emailTB.Tag = "";
            this.emailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            this.emailTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTB_KeyPress);
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.passwordL.ForeColor = System.Drawing.Color.DimGray;
            this.passwordL.Location = new System.Drawing.Point(5, 234);
            this.passwordL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(126, 23);
            this.passwordL.TabIndex = 113;
            this.passwordL.Text = "пароль (0 / 30)";
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
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.HoverState.Parent = this.passwordTB;
            this.passwordTB.Location = new System.Drawing.Point(4, 261);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.passwordTB.MaxLength = 30;
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '\0';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "";
            this.passwordTB.SelectedText = "";
            this.passwordTB.ShadowDecoration.Parent = this.passwordTB;
            this.passwordTB.Size = new System.Drawing.Size(593, 40);
            this.passwordTB.TabIndex = 114;
            this.passwordTB.Tag = "";
            this.passwordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            this.passwordTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTB_KeyPress);
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.nameL.ForeColor = System.Drawing.Color.DimGray;
            this.nameL.Location = new System.Drawing.Point(5, 316);
            this.nameL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(100, 23);
            this.nameL.TabIndex = 115;
            this.nameL.Text = "имя (0 / 20)";
            // 
            // nameTB
            // 
            this.nameTB.Animated = true;
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
            this.nameTB.Location = new System.Drawing.Point(4, 343);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.nameTB.MaxLength = 20;
            this.nameTB.Name = "nameTB";
            this.nameTB.PasswordChar = '\0';
            this.nameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameTB.PlaceholderText = "";
            this.nameTB.SelectedText = "";
            this.nameTB.ShadowDecoration.Parent = this.nameTB;
            this.nameTB.Size = new System.Drawing.Size(593, 40);
            this.nameTB.TabIndex = 116;
            this.nameTB.Tag = "";
            this.nameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            this.nameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTB_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(5, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 117;
            this.label6.Text = "телефон";
            // 
            // phoneTB
            // 
            this.phoneTB.Animated = true;
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
            this.phoneTB.Location = new System.Drawing.Point(4, 425);
            this.phoneTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.phoneTB.MaxLength = 13;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.PasswordChar = '\0';
            this.phoneTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.phoneTB.PlaceholderText = "+375XXXXXXXXX";
            this.phoneTB.SelectedText = "";
            this.phoneTB.ShadowDecoration.Parent = this.phoneTB;
            this.phoneTB.Size = new System.Drawing.Size(593, 40);
            this.phoneTB.TabIndex = 118;
            this.phoneTB.Tag = "";
            this.phoneTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneTB_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 480);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 119;
            this.label7.Text = "картинка";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.RBM_IB);
            this.guna2Panel1.Controls.Add(this.LBM_IB);
            this.guna2Panel1.Controls.Add(this.dragDropIB);
            this.guna2Panel1.Controls.Add(this.pictureBox);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 507);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(593, 265);
            this.guna2Panel1.TabIndex = 134;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(342, 166);
            this.label3.MaximumSize = new System.Drawing.Size(230, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 42);
            this.label3.TabIndex = 140;
            this.label3.Text = "ПКМ по области - удалить аватар";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(342, 99);
            this.label4.MaximumSize = new System.Drawing.Size(250, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 42);
            this.label4.TabIndex = 139;
            this.label4.Text = "ЛКМ по области - добавить аватар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(342, 36);
            this.label5.MaximumSize = new System.Drawing.Size(230, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 42);
            this.label5.TabIndex = 138;
            this.label5.Text = "Перенести картинку на область - добавить аватар";
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 10;
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.FillColor = System.Drawing.Color.RoyalBlue;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(139, 45);
            this.addButton.TabIndex = 123;
            this.addButton.Text = "Добавить";
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 10;
            this.deleteButton.CheckedState.Parent = this.deleteButton;
            this.deleteButton.CustomImages.Parent = this.deleteButton;
            this.deleteButton.FillColor = System.Drawing.Color.Gray;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.Parent = this.deleteButton;
            this.deleteButton.Location = new System.Drawing.Point(148, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ShadowDecoration.Parent = this.deleteButton;
            this.deleteButton.Size = new System.Drawing.Size(139, 45);
            this.deleteButton.TabIndex = 124;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.Animated = true;
            this.changeButton.BorderRadius = 10;
            this.changeButton.CheckedState.Parent = this.changeButton;
            this.changeButton.CustomImages.Parent = this.changeButton;
            this.changeButton.FillColor = System.Drawing.Color.Gray;
            this.changeButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.HoverState.Parent = this.changeButton;
            this.changeButton.Location = new System.Drawing.Point(293, 3);
            this.changeButton.Name = "changeButton";
            this.changeButton.ShadowDecoration.Parent = this.changeButton;
            this.changeButton.Size = new System.Drawing.Size(139, 45);
            this.changeButton.TabIndex = 125;
            this.changeButton.Text = "Изменить";
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.addButton);
            this.flowLayoutPanel2.Controls.Add(this.deleteButton);
            this.flowLayoutPanel2.Controls.Add(this.changeButton);
            this.flowLayoutPanel2.Controls.Add(this.clearButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 800);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(582, 55);
            this.flowLayoutPanel2.TabIndex = 128;
            // 
            // clearButton
            // 
            this.clearButton.Animated = true;
            this.clearButton.BorderRadius = 10;
            this.clearButton.CheckedState.Parent = this.clearButton;
            this.clearButton.CustomImages.Parent = this.clearButton;
            this.clearButton.FillColor = System.Drawing.Color.Gray;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.HoverState.Parent = this.clearButton;
            this.clearButton.Location = new System.Drawing.Point(438, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.ShadowDecoration.Parent = this.clearButton;
            this.clearButton.Size = new System.Drawing.Size(139, 45);
            this.clearButton.TabIndex = 126;
            this.clearButton.Text = "Очистить";
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // guna2HtmlToolTip1
            // 
            this.guna2HtmlToolTip1.AllowLinksHandling = true;
            this.guna2HtmlToolTip1.AutoPopDelay = 20000;
            this.guna2HtmlToolTip1.BackColor = System.Drawing.Color.SlateBlue;
            this.guna2HtmlToolTip1.BorderColor = System.Drawing.Color.SlateBlue;
            this.guna2HtmlToolTip1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.guna2HtmlToolTip1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlToolTip1.InitialDelay = 10;
            this.guna2HtmlToolTip1.MaximumSize = new System.Drawing.Size(0, 0);
            this.guna2HtmlToolTip1.ReshowDelay = 10;
            this.guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.Black;
            // 
            // RBM_IB
            // 
            this.RBM_IB.BackColor = System.Drawing.Color.Transparent;
            this.RBM_IB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.RBM_IB.CheckedState.Parent = this.RBM_IB;
            this.RBM_IB.HoverState.ImageSize = new System.Drawing.Size(79, 77);
            this.RBM_IB.HoverState.Parent = this.RBM_IB;
            this.RBM_IB.Image = global::M_SHOES.BY.Properties.Resources.LeftClick;
            this.RBM_IB.ImageRotate = 0F;
            this.RBM_IB.ImageSize = new System.Drawing.Size(49, 47);
            this.RBM_IB.Location = new System.Drawing.Point(260, 156);
            this.RBM_IB.Name = "RBM_IB";
            this.RBM_IB.PressedState.ImageSize = new System.Drawing.Size(79, 77);
            this.RBM_IB.PressedState.Parent = this.RBM_IB;
            this.RBM_IB.Size = new System.Drawing.Size(87, 82);
            this.RBM_IB.TabIndex = 137;
            // 
            // LBM_IB
            // 
            this.LBM_IB.BackColor = System.Drawing.Color.Transparent;
            this.LBM_IB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LBM_IB.CheckedState.Parent = this.LBM_IB;
            this.LBM_IB.HoverState.ImageSize = new System.Drawing.Size(79, 77);
            this.LBM_IB.HoverState.Parent = this.LBM_IB;
            this.LBM_IB.Image = global::M_SHOES.BY.Properties.Resources.RightClick;
            this.LBM_IB.ImageRotate = 0F;
            this.LBM_IB.ImageSize = new System.Drawing.Size(49, 47);
            this.LBM_IB.Location = new System.Drawing.Point(260, 90);
            this.LBM_IB.Name = "LBM_IB";
            this.LBM_IB.PressedState.ImageSize = new System.Drawing.Size(79, 77);
            this.LBM_IB.PressedState.Parent = this.LBM_IB;
            this.LBM_IB.Size = new System.Drawing.Size(87, 82);
            this.LBM_IB.TabIndex = 136;
            // 
            // dragDropIB
            // 
            this.dragDropIB.BackColor = System.Drawing.Color.Transparent;
            this.dragDropIB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.dragDropIB.CheckedState.Parent = this.dragDropIB;
            this.dragDropIB.HoverState.ImageSize = new System.Drawing.Size(79, 70);
            this.dragDropIB.HoverState.Parent = this.dragDropIB;
            this.dragDropIB.Image = global::M_SHOES.BY.Properties.Resources.DragAndDrop;
            this.dragDropIB.ImageRotate = 0F;
            this.dragDropIB.ImageSize = new System.Drawing.Size(49, 40);
            this.dragDropIB.Location = new System.Drawing.Point(260, 23);
            this.dragDropIB.Name = "dragDropIB";
            this.dragDropIB.PressedState.ImageSize = new System.Drawing.Size(79, 70);
            this.dragDropIB.PressedState.Parent = this.dragDropIB;
            this.dragDropIB.Size = new System.Drawing.Size(87, 82);
            this.dragDropIB.TabIndex = 135;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::M_SHOES.BY.Properties.Resources.Add;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(29, 40);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(200, 184);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 128;
            this.pictureBox.TabStop = false;
            this.guna2HtmlToolTip1.SetToolTip(this.pictureBox, "Область для аватара");
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 40);
            this.label1.TabIndex = 136;
            this.label1.Text = "Пользователь";
            // 
            // UsersEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.DoubleBuffered = true;
            this.Name = "UsersEditor";
            this.Size = new System.Drawing.Size(611, 856);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label emailL;
        private Guna.UI2.WinForms.Guna2TextBox emailTB;
        private System.Windows.Forms.Label passwordL;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private System.Windows.Forms.Label nameL;
        private Guna.UI2.WinForms.Guna2TextBox nameTB;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox phoneTB;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ImageButton RBM_IB;
        private Guna.UI2.WinForms.Guna2ImageButton LBM_IB;
        private Guna.UI2.WinForms.Guna2ImageButton dragDropIB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox roleCB;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBox;
        private System.Windows.Forms.Label label1;
    }
}
