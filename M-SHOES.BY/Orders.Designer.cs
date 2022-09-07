
namespace M_SHOES.BY
{
    partial class Orders
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
            this.ordersFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.basketPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.countOrdersL = new System.Windows.Forms.Label();
            this.ordersFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersFLP
            // 
            this.ordersFLP.AutoScroll = true;
            this.ordersFLP.Controls.Add(this.basketPB);
            this.ordersFLP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ordersFLP.Location = new System.Drawing.Point(0, 146);
            this.ordersFLP.Name = "ordersFLP";
            this.ordersFLP.Size = new System.Drawing.Size(1100, 746);
            this.ordersFLP.TabIndex = 0;
            // 
            // basketPB
            // 
            this.basketPB.Image = global::M_SHOES.BY.Properties.Resources.Order;
            this.basketPB.Location = new System.Drawing.Point(250, 120);
            this.basketPB.Margin = new System.Windows.Forms.Padding(250, 120, 3, 3);
            this.basketPB.Name = "basketPB";
            this.basketPB.ShadowDecoration.Parent = this.basketPB;
            this.basketPB.Size = new System.Drawing.Size(512, 512);
            this.basketPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.basketPB.TabIndex = 105;
            this.basketPB.TabStop = false;
            // 
            // countOrdersL
            // 
            this.countOrdersL.AutoSize = true;
            this.countOrdersL.BackColor = System.Drawing.Color.Transparent;
            this.countOrdersL.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.countOrdersL.ForeColor = System.Drawing.Color.DimGray;
            this.countOrdersL.Location = new System.Drawing.Point(45, 45);
            this.countOrdersL.Name = "countOrdersL";
            this.countOrdersL.Size = new System.Drawing.Size(235, 49);
            this.countOrdersL.TabIndex = 104;
            this.countOrdersL.Text = "Заказы (0):";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.countOrdersL);
            this.Controls.Add(this.ordersFLP);
            this.DoubleBuffered = true;
            this.Name = "Orders";
            this.Size = new System.Drawing.Size(1100, 892);
            this.ordersFLP.ResumeLayout(false);
            this.ordersFLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.basketPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanelDoubleBuffered ordersFLP;
        private System.Windows.Forms.Label countOrdersL;
        private Guna.UI2.WinForms.Guna2PictureBox basketPB;
    }
}
