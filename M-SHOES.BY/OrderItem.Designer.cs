
namespace M_SHOES.BY
{
    partial class OrderItem
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel1 = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.nameL = new System.Windows.Forms.Label();
            this.idShoesL = new System.Windows.Forms.Label();
            this.sizeL = new System.Windows.Forms.Label();
            this.colorL = new System.Windows.Forms.Label();
            this.amountL = new System.Windows.Forms.Label();
            this.costL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 35;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 15;
            this.pictureBox.FillColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(10, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(134, 168);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.nameL);
            this.flowLayoutPanel1.Controls.Add(this.idShoesL);
            this.flowLayoutPanel1.Controls.Add(this.sizeL);
            this.flowLayoutPanel1.Controls.Add(this.colorL);
            this.flowLayoutPanel1.Controls.Add(this.amountL);
            this.flowLayoutPanel1.Controls.Add(this.costL);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(149, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(816, 170);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.ForeColor = System.Drawing.Color.Black;
            this.nameL.Location = new System.Drawing.Point(3, 7);
            this.nameL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(148, 20);
            this.nameL.TabIndex = 15;
            this.nameL.Text = "Название и бренд:  ";
            // 
            // idShoesL
            // 
            this.idShoesL.AutoSize = true;
            this.idShoesL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idShoesL.ForeColor = System.Drawing.Color.Black;
            this.idShoesL.Location = new System.Drawing.Point(3, 34);
            this.idShoesL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.idShoesL.Name = "idShoesL";
            this.idShoesL.Size = new System.Drawing.Size(92, 20);
            this.idShoesL.TabIndex = 12;
            this.idShoesL.Text = "Код обуви:  ";
            // 
            // sizeL
            // 
            this.sizeL.AutoSize = true;
            this.sizeL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeL.ForeColor = System.Drawing.Color.Black;
            this.sizeL.Location = new System.Drawing.Point(3, 61);
            this.sizeL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(117, 20);
            this.sizeL.TabIndex = 10;
            this.sizeL.Text = "Размер обуви:  ";
            // 
            // colorL
            // 
            this.colorL.AutoSize = true;
            this.colorL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorL.ForeColor = System.Drawing.Color.Black;
            this.colorL.Location = new System.Drawing.Point(3, 88);
            this.colorL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.colorL.Name = "colorL";
            this.colorL.Size = new System.Drawing.Size(53, 20);
            this.colorL.TabIndex = 11;
            this.colorL.Text = "Цвет:  ";
            // 
            // amountL
            // 
            this.amountL.AutoSize = true;
            this.amountL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountL.ForeColor = System.Drawing.Color.Black;
            this.amountL.Location = new System.Drawing.Point(3, 115);
            this.amountL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.amountL.Name = "amountL";
            this.amountL.Size = new System.Drawing.Size(101, 20);
            this.amountL.TabIndex = 14;
            this.amountL.Text = "Количество:  ";
            // 
            // costL
            // 
            this.costL.AutoSize = true;
            this.costL.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costL.ForeColor = System.Drawing.Color.Black;
            this.costL.Location = new System.Drawing.Point(3, 142);
            this.costL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(94, 20);
            this.costL.TabIndex = 13;
            this.costL.Text = "Стоимость:  ";
            // 
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.Name = "OrderItem";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(980, 188);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private FlowLayoutPanelDoubleBuffered flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Label idShoesL;
        private System.Windows.Forms.Label sizeL;
        private System.Windows.Forms.Label colorL;
        private System.Windows.Forms.Label amountL;
        private System.Windows.Forms.Label costL;
        private System.Windows.Forms.Label nameL;
    }
}
