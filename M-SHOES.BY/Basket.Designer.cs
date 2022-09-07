namespace M_SHOES.BY
{
    partial class Basket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Basket));
            this.countBasketL = new System.Windows.Forms.Label();
            this.menuP = new Guna.UI2.WinForms.Guna2Panel();
            this.clearBasketB = new Guna.UI2.WinForms.Guna2Button();
            this.orderB = new Guna.UI2.WinForms.Guna2Button();
            this.menuB = new Guna.UI2.WinForms.Guna2Button();
            this.menuAnimate = new System.Windows.Forms.Timer(this.components);
            this.basketFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.basketPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuP.SuspendLayout();
            this.basketFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketPB)).BeginInit();
            this.SuspendLayout();
            // 
            // countBasketL
            // 
            this.countBasketL.AutoSize = true;
            this.countBasketL.BackColor = System.Drawing.Color.Transparent;
            this.countBasketL.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.countBasketL.ForeColor = System.Drawing.Color.DimGray;
            this.countBasketL.Location = new System.Drawing.Point(90, 45);
            this.countBasketL.Name = "countBasketL";
            this.countBasketL.Size = new System.Drawing.Size(325, 49);
            this.countBasketL.TabIndex = 105;
            this.countBasketL.Text = "Корзина (0/10):";
            // 
            // menuP
            // 
            this.menuP.BorderRadius = 10;
            this.menuP.Controls.Add(this.clearBasketB);
            this.menuP.Controls.Add(this.orderB);
            this.menuP.Controls.Add(this.menuB);
            this.menuP.FillColor = System.Drawing.Color.LightSlateGray;
            this.menuP.Location = new System.Drawing.Point(-15, 39);
            this.menuP.Name = "menuP";
            this.menuP.ShadowDecoration.Parent = this.menuP;
            this.menuP.Size = new System.Drawing.Size(90, 68);
            this.menuP.TabIndex = 108;
            // 
            // clearBasketB
            // 
            this.clearBasketB.Animated = true;
            this.clearBasketB.CheckedState.Parent = this.clearBasketB;
            this.clearBasketB.CustomImages.Parent = this.clearBasketB;
            this.clearBasketB.FillColor = System.Drawing.Color.LightSlateGray;
            this.clearBasketB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.clearBasketB.ForeColor = System.Drawing.Color.White;
            this.clearBasketB.HoverState.Parent = this.clearBasketB;
            this.clearBasketB.Location = new System.Drawing.Point(320, 3);
            this.clearBasketB.Name = "clearBasketB";
            this.clearBasketB.ShadowDecoration.Parent = this.clearBasketB;
            this.clearBasketB.Size = new System.Drawing.Size(140, 62);
            this.clearBasketB.TabIndex = 112;
            this.clearBasketB.Text = "Очистить корзину";
            this.clearBasketB.Click += new System.EventHandler(this.ClearBasketB_Click);
            // 
            // orderB
            // 
            this.orderB.Animated = true;
            this.orderB.CheckedState.Parent = this.orderB;
            this.orderB.CustomImages.Parent = this.orderB;
            this.orderB.FillColor = System.Drawing.Color.LightSlateGray;
            this.orderB.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.orderB.ForeColor = System.Drawing.Color.White;
            this.orderB.HoverState.Parent = this.orderB;
            this.orderB.Location = new System.Drawing.Point(147, 3);
            this.orderB.Name = "orderB";
            this.orderB.ShadowDecoration.Parent = this.orderB;
            this.orderB.Size = new System.Drawing.Size(140, 62);
            this.orderB.TabIndex = 111;
            this.orderB.Text = "Заказать";
            this.orderB.Click += new System.EventHandler(this.OrderB_Click);
            // 
            // menuB
            // 
            this.menuB.Animated = true;
            this.menuB.BackColor = System.Drawing.Color.Transparent;
            this.menuB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuB.BorderRadius = 7;
            this.menuB.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.menuB.CheckedState.FillColor = System.Drawing.Color.LightSlateGray;
            this.menuB.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("menuB.CheckedState.Image")));
            this.menuB.CheckedState.Parent = this.menuB;
            this.menuB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuB.CustomImages.Parent = this.menuB;
            this.menuB.FillColor = System.Drawing.Color.LightSlateGray;
            this.menuB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuB.ForeColor = System.Drawing.Color.White;
            this.menuB.HoverState.FillColor = System.Drawing.Color.LightSlateGray;
            this.menuB.HoverState.Parent = this.menuB;
            this.menuB.Image = ((System.Drawing.Image)(resources.GetObject("menuB.Image")));
            this.menuB.ImageSize = new System.Drawing.Size(40, 40);
            this.menuB.Location = new System.Drawing.Point(34, 14);
            this.menuB.Name = "menuB";
            this.menuB.PressedColor = System.Drawing.Color.LightSlateGray;
            this.menuB.PressedDepth = 0;
            this.menuB.ShadowDecoration.Parent = this.menuB;
            this.menuB.Size = new System.Drawing.Size(40, 40);
            this.menuB.TabIndex = 109;
            this.menuB.Click += new System.EventHandler(this.MenuB_Click);
            // 
            // menuAnimate
            // 
            this.menuAnimate.Interval = 1;
            this.menuAnimate.Tick += new System.EventHandler(this.MenuAnimate_Tick);
            // 
            // basketFLP
            // 
            this.basketFLP.AutoScroll = true;
            this.basketFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.basketFLP.Controls.Add(this.basketPB);
            this.basketFLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basketFLP.Location = new System.Drawing.Point(0, 146);
            this.basketFLP.Name = "basketFLP";
            this.basketFLP.Size = new System.Drawing.Size(1100, 746);
            this.basketFLP.TabIndex = 106;
            // 
            // basketPB
            // 
            this.basketPB.Image = global::M_SHOES.BY.Properties.Resources.Basket1;
            this.basketPB.Location = new System.Drawing.Point(250, 120);
            this.basketPB.Margin = new System.Windows.Forms.Padding(250, 120, 3, 3);
            this.basketPB.Name = "basketPB";
            this.basketPB.ShadowDecoration.Parent = this.basketPB;
            this.basketPB.Size = new System.Drawing.Size(575, 502);
            this.basketPB.TabIndex = 0;
            this.basketPB.TabStop = false;
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basketFLP);
            this.Controls.Add(this.countBasketL);
            this.Controls.Add(this.menuP);
            this.Name = "Basket";
            this.Size = new System.Drawing.Size(1100, 892);
            this.menuP.ResumeLayout(false);
            this.basketFLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.basketPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countBasketL;
        private FlowLayoutPanelDoubleBuffered basketFLP;
        private Guna.UI2.WinForms.Guna2Panel menuP;
        private System.Windows.Forms.Timer menuAnimate;
        private Guna.UI2.WinForms.Guna2Button menuB;
        private Guna.UI2.WinForms.Guna2Button orderB;
        private Guna.UI2.WinForms.Guna2Button clearBasketB;
        private Guna.UI2.WinForms.Guna2PictureBox basketPB;
    }
}
