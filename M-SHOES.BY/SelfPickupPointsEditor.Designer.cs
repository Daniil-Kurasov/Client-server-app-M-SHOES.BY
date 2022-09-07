
namespace M_SHOES.BY
{
    partial class SelfPickupPointsEditor
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
            this.addressL = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.addressRTB = new System.Windows.Forms.RichTextBox();
            this.informationL = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.informationRTB = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.changeButton = new Guna.UI2.WinForms.Guna2Button();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.addressL);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanel1.Controls.Add(this.informationL);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(611, 949);
            this.flowLayoutPanel1.TabIndex = 112;
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.addressL.ForeColor = System.Drawing.Color.DimGray;
            this.addressL.Location = new System.Drawing.Point(5, 65);
            this.addressL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(123, 23);
            this.addressL.TabIndex = 132;
            this.addressL.Text = "адрес (0 / 500)";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.addressRTB);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(4, 92);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(593, 171);
            this.guna2Panel1.TabIndex = 133;
            // 
            // addressRTB
            // 
            this.addressRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.addressRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressRTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressRTB.ForeColor = System.Drawing.Color.Black;
            this.addressRTB.Location = new System.Drawing.Point(10, 10);
            this.addressRTB.MaxLength = 500;
            this.addressRTB.Name = "addressRTB";
            this.addressRTB.Size = new System.Drawing.Size(577, 149);
            this.addressRTB.TabIndex = 0;
            this.addressRTB.Text = "";
            this.addressRTB.TextChanged += new System.EventHandler(this.AddressRTB_TextChanged);
            // 
            // informationL
            // 
            this.informationL.AutoSize = true;
            this.informationL.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.informationL.ForeColor = System.Drawing.Color.DimGray;
            this.informationL.Location = new System.Drawing.Point(5, 278);
            this.informationL.Margin = new System.Windows.Forms.Padding(5, 0, 3, 0);
            this.informationL.Name = "informationL";
            this.informationL.Size = new System.Drawing.Size(189, 23);
            this.informationL.TabIndex = 134;
            this.informationL.Text = "информация (0 / 4000)";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.informationRTB);
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.ForeColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(4, 305);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(593, 611);
            this.guna2Panel2.TabIndex = 135;
            // 
            // informationRTB
            // 
            this.informationRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.informationRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationRTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.informationRTB.ForeColor = System.Drawing.Color.Black;
            this.informationRTB.Location = new System.Drawing.Point(10, 10);
            this.informationRTB.MaxLength = 4000;
            this.informationRTB.Name = "informationRTB";
            this.informationRTB.Size = new System.Drawing.Size(574, 589);
            this.informationRTB.TabIndex = 0;
            this.informationRTB.Text = "";
            this.informationRTB.TextChanged += new System.EventHandler(this.InformationRTB_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.addButton);
            this.flowLayoutPanel2.Controls.Add(this.deleteButton);
            this.flowLayoutPanel2.Controls.Add(this.changeButton);
            this.flowLayoutPanel2.Controls.Add(this.clearButton);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(11, 955);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(587, 57);
            this.flowLayoutPanel2.TabIndex = 142;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 137;
            this.label1.Text = "Пункт самовывоза";
            // 
            // SelfPickupPointsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "SelfPickupPointsEditor";
            this.Size = new System.Drawing.Size(611, 1014);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label addressL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.RichTextBox addressRTB;
        private System.Windows.Forms.Label informationL;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.RichTextBox informationRTB;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button changeButton;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private System.Windows.Forms.Label label1;
    }
}
