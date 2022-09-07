namespace M_SHOES.BY
{
    partial class BasketItem
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
            this.orderP = new Guna.UI2.WinForms.Guna2Panel();
            this.basketFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.nameL = new System.Windows.Forms.Label();
            this.idShoesL = new System.Windows.Forms.Label();
            this.sizeL = new System.Windows.Forms.Label();
            this.colorL = new System.Windows.Forms.Label();
            this.amountL = new System.Windows.Forms.Label();
            this.amountFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.amountNUD = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.remainderL = new System.Windows.Forms.Label();
            this.costL = new System.Windows.Forms.Label();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.deleteIB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.orderP.SuspendLayout();
            this.basketFLP.SuspendLayout();
            this.amountFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // orderP
            // 
            this.orderP.BackColor = System.Drawing.Color.White;
            this.orderP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderP.BorderColor = System.Drawing.Color.DarkGray;
            this.orderP.BorderRadius = 15;
            this.orderP.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.orderP.BorderThickness = 3;
            this.orderP.Controls.Add(this.basketFLP);
            this.orderP.Controls.Add(this.pictureBox);
            this.orderP.Controls.Add(this.deleteIB);
            this.orderP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderP.Location = new System.Drawing.Point(0, 0);
            this.orderP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 45);
            this.orderP.Name = "orderP";
            this.orderP.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.orderP.ShadowDecoration.Parent = this.orderP;
            this.orderP.Size = new System.Drawing.Size(1068, 242);
            this.orderP.TabIndex = 160;
            // 
            // basketFLP
            // 
            this.basketFLP.BackColor = System.Drawing.Color.White;
            this.basketFLP.Controls.Add(this.nameL);
            this.basketFLP.Controls.Add(this.idShoesL);
            this.basketFLP.Controls.Add(this.sizeL);
            this.basketFLP.Controls.Add(this.colorL);
            this.basketFLP.Controls.Add(this.amountL);
            this.basketFLP.Controls.Add(this.amountFLP);
            this.basketFLP.Controls.Add(this.costL);
            this.basketFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.basketFLP.Location = new System.Drawing.Point(171, 15);
            this.basketFLP.Name = "basketFLP";
            this.basketFLP.Size = new System.Drawing.Size(812, 213);
            this.basketFLP.TabIndex = 3;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold);
            this.nameL.ForeColor = System.Drawing.Color.Black;
            this.nameL.Location = new System.Drawing.Point(3, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(206, 25);
            this.nameL.TabIndex = 2;
            this.nameL.Text = "Название и бренд:  ";
            // 
            // idShoesL
            // 
            this.idShoesL.AutoSize = true;
            this.idShoesL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idShoesL.ForeColor = System.Drawing.Color.DimGray;
            this.idShoesL.Location = new System.Drawing.Point(3, 32);
            this.idShoesL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.idShoesL.Name = "idShoesL";
            this.idShoesL.Size = new System.Drawing.Size(101, 21);
            this.idShoesL.TabIndex = 7;
            this.idShoesL.Text = "Код обуви:  ";
            // 
            // sizeL
            // 
            this.sizeL.AutoSize = true;
            this.sizeL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeL.ForeColor = System.Drawing.Color.DimGray;
            this.sizeL.Location = new System.Drawing.Point(3, 60);
            this.sizeL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(127, 21);
            this.sizeL.TabIndex = 5;
            this.sizeL.Text = "Размер обуви:  ";
            // 
            // colorL
            // 
            this.colorL.AutoSize = true;
            this.colorL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorL.ForeColor = System.Drawing.Color.DimGray;
            this.colorL.Location = new System.Drawing.Point(3, 88);
            this.colorL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.colorL.Name = "colorL";
            this.colorL.Size = new System.Drawing.Size(59, 21);
            this.colorL.TabIndex = 6;
            this.colorL.Text = "Цвет:  ";
            // 
            // amountL
            // 
            this.amountL.AutoSize = true;
            this.amountL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountL.ForeColor = System.Drawing.Color.DimGray;
            this.amountL.Location = new System.Drawing.Point(3, 116);
            this.amountL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.amountL.Name = "amountL";
            this.amountL.Size = new System.Drawing.Size(113, 21);
            this.amountL.TabIndex = 9;
            this.amountL.Text = "Количество:  ";
            // 
            // amountFLP
            // 
            this.amountFLP.Controls.Add(this.amountNUD);
            this.amountFLP.Controls.Add(this.remainderL);
            this.amountFLP.Location = new System.Drawing.Point(3, 144);
            this.amountFLP.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.amountFLP.Name = "amountFLP";
            this.amountFLP.Size = new System.Drawing.Size(324, 36);
            this.amountFLP.TabIndex = 11;
            // 
            // amountNUD
            // 
            this.amountNUD.BackColor = System.Drawing.Color.Transparent;
            this.amountNUD.BorderColor = System.Drawing.Color.Black;
            this.amountNUD.BorderRadius = 10;
            this.amountNUD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountNUD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amountNUD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amountNUD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amountNUD.DisabledState.Parent = this.amountNUD;
            this.amountNUD.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.amountNUD.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.amountNUD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.amountNUD.FocusedState.Parent = this.amountNUD;
            this.amountNUD.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountNUD.ForeColor = System.Drawing.Color.Black;
            this.amountNUD.Location = new System.Drawing.Point(0, 0);
            this.amountNUD.Margin = new System.Windows.Forms.Padding(0);
            this.amountNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.amountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNUD.Name = "amountNUD";
            this.amountNUD.ShadowDecoration.Parent = this.amountNUD;
            this.amountNUD.Size = new System.Drawing.Size(99, 35);
            this.amountNUD.TabIndex = 10;
            this.amountNUD.UpDownButtonFillColor = System.Drawing.Color.Black;
            this.amountNUD.UpDownButtonForeColor = System.Drawing.Color.White;
            this.amountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.amountNUD.ValueChanged += new System.EventHandler(this.AmountNUD_ValueChanged);
            // 
            // remainderL
            // 
            this.remainderL.AutoSize = true;
            this.remainderL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainderL.ForeColor = System.Drawing.Color.Tomato;
            this.remainderL.Location = new System.Drawing.Point(107, 6);
            this.remainderL.Margin = new System.Windows.Forms.Padding(8, 6, 3, 0);
            this.remainderL.Name = "remainderL";
            this.remainderL.Size = new System.Drawing.Size(120, 21);
            this.remainderL.TabIndex = 11;
            this.remainderL.Text = "Осталось 0 шт.";
            this.remainderL.Visible = false;
            // 
            // costL
            // 
            this.costL.AutoSize = true;
            this.costL.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.costL.ForeColor = System.Drawing.Color.DimGray;
            this.costL.Location = new System.Drawing.Point(3, 187);
            this.costL.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(120, 25);
            this.costL.TabIndex = 8;
            this.costL.Text = "Стоимость:  ";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 10;
            this.pictureBox.FillColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(12, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(154, 213);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // deleteIB
            // 
            this.deleteIB.BackColor = System.Drawing.Color.Transparent;
            this.deleteIB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.deleteIB.CheckedState.Parent = this.deleteIB;
            this.deleteIB.HoverState.Image = global::M_SHOES.BY.Properties.Resources.DeleteRed;
            this.deleteIB.HoverState.ImageSize = new System.Drawing.Size(70, 70);
            this.deleteIB.HoverState.Parent = this.deleteIB;
            this.deleteIB.Image = global::M_SHOES.BY.Properties.Resources.DeleteBlack;
            this.deleteIB.ImageRotate = 0F;
            this.deleteIB.ImageSize = new System.Drawing.Size(55, 55);
            this.deleteIB.Location = new System.Drawing.Point(989, 87);
            this.deleteIB.Name = "deleteIB";
            this.deleteIB.PressedState.Image = global::M_SHOES.BY.Properties.Resources.DeleteRed;
            this.deleteIB.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.deleteIB.PressedState.Parent = this.deleteIB;
            this.deleteIB.Size = new System.Drawing.Size(70, 70);
            this.deleteIB.TabIndex = 11;
            this.deleteIB.UseTransparentBackground = true;
            this.deleteIB.Click += new System.EventHandler(this.DeleteIB_Click);
            // 
            // BasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.orderP);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.Name = "BasketItem";
            this.Size = new System.Drawing.Size(1068, 242);
            this.orderP.ResumeLayout(false);
            this.basketFLP.ResumeLayout(false);
            this.basketFLP.PerformLayout();
            this.amountFLP.ResumeLayout(false);
            this.amountFLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel orderP;
        private FlowLayoutPanelDoubleBuffered basketFLP;
        private System.Windows.Forms.Label nameL;
        private System.Windows.Forms.Label idShoesL;
        private System.Windows.Forms.Label sizeL;
        private System.Windows.Forms.Label colorL;
        private System.Windows.Forms.Label costL;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Label amountL;
        private Guna.UI2.WinForms.Guna2NumericUpDown amountNUD;
        private FlowLayoutPanelDoubleBuffered amountFLP;
        private System.Windows.Forms.Label remainderL;
        private Guna.UI2.WinForms.Guna2ImageButton deleteIB;
    }
}
