
namespace M_SHOES.BY
{
    partial class ShoesList
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
            this.shoesListP = new Guna.UI2.WinForms.Guna2Panel();
            this.starPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ratingL = new System.Windows.Forms.Label();
            this.priceAndDiscountFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.priceL = new System.Windows.Forms.Label();
            this.discountL = new System.Windows.Forms.Label();
            this.brandAndNameL = new System.Windows.Forms.Label();
            this.likedIB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.shoesListP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPB)).BeginInit();
            this.priceAndDiscountFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // shoesListP
            // 
            this.shoesListP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.shoesListP.BorderColor = System.Drawing.Color.Gray;
            this.shoesListP.BorderRadius = 10;
            this.shoesListP.BorderThickness = 1;
            this.shoesListP.Controls.Add(this.starPB);
            this.shoesListP.Controls.Add(this.ratingL);
            this.shoesListP.Controls.Add(this.priceAndDiscountFLP);
            this.shoesListP.Controls.Add(this.brandAndNameL);
            this.shoesListP.Controls.Add(this.likedIB);
            this.shoesListP.Controls.Add(this.pictureBox);
            this.shoesListP.Location = new System.Drawing.Point(3, 3);
            this.shoesListP.Name = "shoesListP";
            this.shoesListP.Padding = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.shoesListP.ShadowDecoration.Parent = this.shoesListP;
            this.shoesListP.Size = new System.Drawing.Size(209, 331);
            this.shoesListP.TabIndex = 1;
            this.shoesListP.Click += new System.EventHandler(this.ShoesListP_Click);
            // 
            // starPB
            // 
            this.starPB.BackColor = System.Drawing.Color.Transparent;
            this.starPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.starPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.starPB.FillColor = System.Drawing.Color.Transparent;
            this.starPB.Image = global::M_SHOES.BY.Properties.Resources.Star;
            this.starPB.Location = new System.Drawing.Point(6, 6);
            this.starPB.Name = "starPB";
            this.starPB.ShadowDecoration.Parent = this.starPB;
            this.starPB.Size = new System.Drawing.Size(26, 26);
            this.starPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.starPB.TabIndex = 7;
            this.starPB.TabStop = false;
            this.starPB.MouseLeave += new System.EventHandler(this.StarPB_MouseLeave);
            this.starPB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StarPB_MouseMove);
            // 
            // ratingL
            // 
            this.ratingL.AutoSize = true;
            this.ratingL.BackColor = System.Drawing.Color.Transparent;
            this.ratingL.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.ratingL.ForeColor = System.Drawing.Color.DimGray;
            this.ratingL.Location = new System.Drawing.Point(30, 8);
            this.ratingL.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.ratingL.Name = "ratingL";
            this.ratingL.Size = new System.Drawing.Size(19, 21);
            this.ratingL.TabIndex = 150;
            this.ratingL.Text = "5";
            this.ratingL.MouseLeave += new System.EventHandler(this.RatingL_MouseLeave);
            this.ratingL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RatingL_MouseMove);
            // 
            // priceAndDiscountFLP
            // 
            this.priceAndDiscountFLP.Controls.Add(this.priceL);
            this.priceAndDiscountFLP.Controls.Add(this.discountL);
            this.priceAndDiscountFLP.Location = new System.Drawing.Point(12, 272);
            this.priceAndDiscountFLP.Name = "priceAndDiscountFLP";
            this.priceAndDiscountFLP.Size = new System.Drawing.Size(193, 21);
            this.priceAndDiscountFLP.TabIndex = 4;
            this.priceAndDiscountFLP.Click += new System.EventHandler(this.PriceAndDiscountFLP_Click);
            this.priceAndDiscountFLP.MouseLeave += new System.EventHandler(this.PriceAndDiscountFLP_MouseLeave);
            this.priceAndDiscountFLP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PriceAndDiscountFLP_MouseMove);
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.ForeColor = System.Drawing.Color.Black;
            this.priceL.Location = new System.Drawing.Point(3, 0);
            this.priceL.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(86, 21);
            this.priceL.TabIndex = 1;
            this.priceL.Text = "9999,99 р.";
            this.priceL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.priceL.UseCompatibleTextRendering = true;
            this.priceL.Click += new System.EventHandler(this.PriceL_Click);
            this.priceL.MouseLeave += new System.EventHandler(this.PriceL_MouseLeave);
            this.priceL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PriceL_MouseMove);
            // 
            // discountL
            // 
            this.discountL.AutoSize = true;
            this.discountL.BackColor = System.Drawing.Color.Red;
            this.discountL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountL.ForeColor = System.Drawing.Color.White;
            this.discountL.Location = new System.Drawing.Point(89, 0);
            this.discountL.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.discountL.MaximumSize = new System.Drawing.Size(0, 20);
            this.discountL.MinimumSize = new System.Drawing.Size(30, 20);
            this.discountL.Name = "discountL";
            this.discountL.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.discountL.Size = new System.Drawing.Size(39, 20);
            this.discountL.TabIndex = 3;
            this.discountL.Text = "15 %";
            this.discountL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.discountL.UseCompatibleTextRendering = true;
            this.discountL.Visible = false;
            this.discountL.Click += new System.EventHandler(this.DiscountL_Click);
            this.discountL.MouseLeave += new System.EventHandler(this.DiscountL_MouseLeave);
            this.discountL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DiscountL_MouseMove);
            // 
            // brandAndNameL
            // 
            this.brandAndNameL.AutoSize = true;
            this.brandAndNameL.BackColor = System.Drawing.Color.Transparent;
            this.brandAndNameL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.brandAndNameL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brandAndNameL.ForeColor = System.Drawing.Color.DimGray;
            this.brandAndNameL.Location = new System.Drawing.Point(1, 293);
            this.brandAndNameL.Margin = new System.Windows.Forms.Padding(0);
            this.brandAndNameL.MaximumSize = new System.Drawing.Size(207, 38);
            this.brandAndNameL.MinimumSize = new System.Drawing.Size(207, 38);
            this.brandAndNameL.Name = "brandAndNameL";
            this.brandAndNameL.Size = new System.Drawing.Size(207, 38);
            this.brandAndNameL.TabIndex = 2;
            this.brandAndNameL.Text = "Кроссовки WMNS VENTURE\r\n\r\n\r\n\r\n\r\n";
            this.brandAndNameL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.brandAndNameL.UseCompatibleTextRendering = true;
            this.brandAndNameL.Click += new System.EventHandler(this.BrandAndNameL_Click);
            this.brandAndNameL.MouseLeave += new System.EventHandler(this.BrandAndNameL_MouseLeave);
            this.brandAndNameL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BrandAndNameL_MouseMove);
            // 
            // likedIB
            // 
            this.likedIB.BackColor = System.Drawing.Color.Transparent;
            this.likedIB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.likedIB.CheckedState.Parent = this.likedIB;
            this.likedIB.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.likedIB.HoverState.Parent = this.likedIB;
            this.likedIB.Image = global::M_SHOES.BY.Properties.Resources.HeartTransparent;
            this.likedIB.ImageRotate = 0F;
            this.likedIB.ImageSize = new System.Drawing.Size(25, 25);
            this.likedIB.Location = new System.Drawing.Point(2, 32);
            this.likedIB.Name = "likedIB";
            this.likedIB.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.likedIB.PressedState.Parent = this.likedIB;
            this.likedIB.Size = new System.Drawing.Size(33, 33);
            this.likedIB.TabIndex = 2;
            this.likedIB.Click += new System.EventHandler(this.LikedIB_Click);
            this.likedIB.MouseLeave += new System.EventHandler(this.LikedIB_MouseLeave);
            this.likedIB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LikedIB_MouseMove);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 10;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox.FillColor = System.Drawing.Color.Gray;
            this.pictureBox.Location = new System.Drawing.Point(1, 1);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.ShadowDecoration.Parent = this.pictureBox;
            this.pictureBox.Size = new System.Drawing.Size(207, 270);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.PictureBox_Click);
            this.pictureBox.MouseLeave += new System.EventHandler(this.PictureBox_MouseLeave);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // ShoesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.shoesListP);
            this.Margin = new System.Windows.Forms.Padding(47, 30, 0, 0);
            this.Name = "ShoesList";
            this.Size = new System.Drawing.Size(215, 337);
            this.shoesListP.ResumeLayout(false);
            this.shoesListP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.starPB)).EndInit();
            this.priceAndDiscountFLP.ResumeLayout(false);
            this.priceAndDiscountFLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Panel shoesListP;
        private System.Windows.Forms.Label brandAndNameL;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label discountL;
        private System.Windows.Forms.FlowLayoutPanel priceAndDiscountFLP;
        private Guna.UI2.WinForms.Guna2PictureBox starPB;
        private System.Windows.Forms.Label ratingL;
        private Guna.UI2.WinForms.Guna2ImageButton likedIB;
    }
}
