namespace M_SHOES.BY
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.orderP = new Guna.UI2.WinForms.Guna2Panel();
            this.sendToEmail = new Guna.UI2.WinForms.Guna2ImageButton();
            this.detailsB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.downloadIB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.orderFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.orderNumberL = new System.Windows.Forms.Label();
            this.statusL = new System.Windows.Forms.Label();
            this.addressL = new System.Windows.Forms.Label();
            this.deliveryDateL = new System.Windows.Forms.Label();
            this.costL = new System.Windows.Forms.Label();
            this.guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.orderP.SuspendLayout();
            this.orderFLP.SuspendLayout();
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
            this.orderP.Controls.Add(this.sendToEmail);
            this.orderP.Controls.Add(this.detailsB);
            this.orderP.Controls.Add(this.downloadIB);
            this.orderP.Controls.Add(this.orderFLP);
            this.orderP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderP.FillColor = System.Drawing.Color.White;
            this.orderP.Location = new System.Drawing.Point(0, 0);
            this.orderP.Margin = new System.Windows.Forms.Padding(3, 3, 3, 45);
            this.orderP.Name = "orderP";
            this.orderP.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.orderP.ShadowDecoration.Parent = this.orderP;
            this.orderP.Size = new System.Drawing.Size(1070, 215);
            this.orderP.TabIndex = 160;
            // 
            // sendToEmail
            // 
            this.sendToEmail.BackColor = System.Drawing.Color.White;
            this.sendToEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendToEmail.CheckedState.Image = global::M_SHOES.BY.Properties.Resources.Download;
            this.sendToEmail.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sendToEmail.CheckedState.Parent = this.sendToEmail;
            this.sendToEmail.HoverState.ImageSize = new System.Drawing.Size(43, 43);
            this.sendToEmail.HoverState.Parent = this.sendToEmail;
            this.sendToEmail.Image = global::M_SHOES.BY.Properties.Resources.SendEmail;
            this.sendToEmail.ImageRotate = 0F;
            this.sendToEmail.ImageSize = new System.Drawing.Size(37, 37);
            this.sendToEmail.Location = new System.Drawing.Point(1011, 69);
            this.sendToEmail.Name = "sendToEmail";
            this.sendToEmail.PressedState.ImageSize = new System.Drawing.Size(43, 43);
            this.sendToEmail.PressedState.Parent = this.sendToEmail;
            this.sendToEmail.Size = new System.Drawing.Size(43, 43);
            this.sendToEmail.TabIndex = 164;
            this.guna2HtmlToolTip1.SetToolTip(this.sendToEmail, "Отправить \r\nна почту");
            this.sendToEmail.Click += new System.EventHandler(this.SendToEmail_Click);
            // 
            // detailsB
            // 
            this.detailsB.BackColor = System.Drawing.Color.White;
            this.detailsB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.detailsB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.detailsB.CheckedState.Parent = this.detailsB;
            this.detailsB.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.detailsB.HoverState.Parent = this.detailsB;
            this.detailsB.Image = global::M_SHOES.BY.Properties.Resources.Open;
            this.detailsB.ImageRotate = 0F;
            this.detailsB.ImageSize = new System.Drawing.Size(35, 35);
            this.detailsB.Location = new System.Drawing.Point(1014, 141);
            this.detailsB.Name = "detailsB";
            this.detailsB.PressedState.ImageSize = new System.Drawing.Size(40, 40);
            this.detailsB.PressedState.Parent = this.detailsB;
            this.detailsB.Size = new System.Drawing.Size(40, 40);
            this.detailsB.TabIndex = 163;
            this.guna2HtmlToolTip1.SetToolTip(this.detailsB, "Раскрыть");
            this.detailsB.Click += new System.EventHandler(this.DetailsB_Click);
            // 
            // downloadIB
            // 
            this.downloadIB.BackColor = System.Drawing.Color.White;
            this.downloadIB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.downloadIB.CheckedState.Image = global::M_SHOES.BY.Properties.Resources.Download;
            this.downloadIB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.downloadIB.CheckedState.Parent = this.downloadIB;
            this.downloadIB.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.downloadIB.HoverState.Parent = this.downloadIB;
            this.downloadIB.Image = ((System.Drawing.Image)(resources.GetObject("downloadIB.Image")));
            this.downloadIB.ImageRotate = 0F;
            this.downloadIB.ImageSize = new System.Drawing.Size(40, 40);
            this.downloadIB.Location = new System.Drawing.Point(1013, 15);
            this.downloadIB.Name = "downloadIB";
            this.downloadIB.PressedState.ImageSize = new System.Drawing.Size(45, 45);
            this.downloadIB.PressedState.Parent = this.downloadIB;
            this.downloadIB.Size = new System.Drawing.Size(40, 40);
            this.downloadIB.TabIndex = 162;
            this.guna2HtmlToolTip1.SetToolTip(this.downloadIB, "Сохранить");
            this.downloadIB.Click += new System.EventHandler(this.DownloadIB_Click);
            // 
            // orderFLP
            // 
            this.orderFLP.BackColor = System.Drawing.Color.White;
            this.orderFLP.Controls.Add(this.orderNumberL);
            this.orderFLP.Controls.Add(this.statusL);
            this.orderFLP.Controls.Add(this.addressL);
            this.orderFLP.Controls.Add(this.deliveryDateL);
            this.orderFLP.Controls.Add(this.costL);
            this.orderFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.orderFLP.Location = new System.Drawing.Point(4, 15);
            this.orderFLP.Name = "orderFLP";
            this.orderFLP.Size = new System.Drawing.Size(1003, 187);
            this.orderFLP.TabIndex = 3;
            // 
            // orderNumberL
            // 
            this.orderNumberL.AutoSize = true;
            this.orderNumberL.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderNumberL.ForeColor = System.Drawing.Color.LightSlateGray;
            this.orderNumberL.Location = new System.Drawing.Point(15, 0);
            this.orderNumberL.Margin = new System.Windows.Forms.Padding(15, 0, 3, 0);
            this.orderNumberL.Name = "orderNumberL";
            this.orderNumberL.Size = new System.Drawing.Size(218, 33);
            this.orderNumberL.TabIndex = 2;
            this.orderNumberL.Text = "Номер заказа:  ";
            // 
            // statusL
            // 
            this.statusL.AutoSize = true;
            this.statusL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.statusL.ForeColor = System.Drawing.Color.DimGray;
            this.statusL.Location = new System.Drawing.Point(15, 45);
            this.statusL.Margin = new System.Windows.Forms.Padding(15, 12, 3, 0);
            this.statusL.Name = "statusL";
            this.statusL.Size = new System.Drawing.Size(74, 25);
            this.statusL.TabIndex = 9;
            this.statusL.Text = "Статус: ";
            // 
            // addressL
            // 
            this.addressL.AutoSize = true;
            this.addressL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.addressL.ForeColor = System.Drawing.Color.DimGray;
            this.addressL.Location = new System.Drawing.Point(15, 77);
            this.addressL.Margin = new System.Windows.Forms.Padding(15, 7, 3, 0);
            this.addressL.Name = "addressL";
            this.addressL.Size = new System.Drawing.Size(248, 25);
            this.addressL.TabIndex = 3;
            this.addressL.Text = "Адрес пункта самовывоза:  ";
            // 
            // deliveryDateL
            // 
            this.deliveryDateL.AutoSize = true;
            this.deliveryDateL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.deliveryDateL.ForeColor = System.Drawing.Color.DimGray;
            this.deliveryDateL.Location = new System.Drawing.Point(15, 109);
            this.deliveryDateL.Margin = new System.Windows.Forms.Padding(15, 7, 3, 0);
            this.deliveryDateL.Name = "deliveryDateL";
            this.deliveryDateL.Size = new System.Drawing.Size(317, 25);
            this.deliveryDateL.TabIndex = 4;
            this.deliveryDateL.Text = "Дата доставки в пункт самовывоза: ";
            // 
            // costL
            // 
            this.costL.AutoSize = true;
            this.costL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.costL.ForeColor = System.Drawing.Color.DimGray;
            this.costL.Location = new System.Drawing.Point(15, 141);
            this.costL.Margin = new System.Windows.Forms.Padding(15, 7, 3, 20);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(178, 25);
            this.costL.TabIndex = 8;
            this.costL.Text = "Общая стоимость:  ";
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
            // OrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.orderP);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.Name = "OrderItem";
            this.Size = new System.Drawing.Size(1070, 215);
            this.orderP.ResumeLayout(false);
            this.orderFLP.ResumeLayout(false);
            this.orderFLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel orderP;
        private System.Windows.Forms.Label orderNumberL;
        private System.Windows.Forms.Label addressL;
        private System.Windows.Forms.Label deliveryDateL;
        private System.Windows.Forms.Label costL;
        public FlowLayoutPanelDoubleBuffered orderFLP;
        private Guna.UI2.WinForms.Guna2ImageButton downloadIB;
        private Guna.UI2.WinForms.Guna2ImageButton detailsB;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
        private Guna.UI2.WinForms.Guna2ImageButton sendToEmail;
        private System.Windows.Forms.Label statusL;
    }
}
