namespace M_SHOES.BY
{
    partial class OrderRealisation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRealisation));
            this.orderL = new System.Windows.Forms.Label();
            this.selfPickUpPointL = new System.Windows.Forms.Label();
            this.addressesCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateL = new System.Windows.Forms.Label();
            this.dateCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.elipseOrderRealisation = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.sendEmailL = new System.Windows.Forms.Label();
            this.sendIB = new Guna.UI2.WinForms.Guna2ImageButton();
            this.costL = new System.Windows.Forms.Label();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.orderB = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderL
            // 
            this.orderL.AutoSize = true;
            this.orderL.BackColor = System.Drawing.Color.Transparent;
            this.orderL.Font = new System.Drawing.Font("Montserrat", 20.25F);
            this.orderL.ForeColor = System.Drawing.Color.Black;
            this.orderL.Location = new System.Drawing.Point(21, 20);
            this.orderL.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.orderL.Name = "orderL";
            this.orderL.Size = new System.Drawing.Size(136, 40);
            this.orderL.TabIndex = 161;
            this.orderL.Text = "Заказать";
            this.orderL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.orderL.UseCompatibleTextRendering = true;
            // 
            // selfPickUpPointL
            // 
            this.selfPickUpPointL.AutoSize = true;
            this.selfPickUpPointL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selfPickUpPointL.ForeColor = System.Drawing.Color.Black;
            this.selfPickUpPointL.Location = new System.Drawing.Point(54, 82);
            this.selfPickUpPointL.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.selfPickUpPointL.Name = "selfPickUpPointL";
            this.selfPickUpPointL.Size = new System.Drawing.Size(163, 21);
            this.selfPickUpPointL.TabIndex = 153;
            this.selfPickUpPointL.Text = "Пункт самовывоза:  ";
            // 
            // addressesCB
            // 
            this.addressesCB.Animated = true;
            this.addressesCB.BackColor = System.Drawing.Color.Transparent;
            this.addressesCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.addressesCB.BorderRadius = 10;
            this.addressesCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.addressesCB.DropDownHeight = 150;
            this.addressesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addressesCB.FillColor = System.Drawing.Color.Gainsboro;
            this.addressesCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressesCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addressesCB.FocusedState.Parent = this.addressesCB;
            this.addressesCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressesCB.ForeColor = System.Drawing.Color.Black;
            this.addressesCB.HoverState.Parent = this.addressesCB;
            this.addressesCB.IntegralHeight = false;
            this.addressesCB.ItemHeight = 30;
            this.addressesCB.ItemsAppearance.Parent = this.addressesCB;
            this.addressesCB.Location = new System.Drawing.Point(55, 107);
            this.addressesCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.addressesCB.Name = "addressesCB";
            this.addressesCB.ShadowDecoration.Parent = this.addressesCB;
            this.addressesCB.Size = new System.Drawing.Size(392, 36);
            this.addressesCB.TabIndex = 154;
            // 
            // dateL
            // 
            this.dateL.AutoSize = true;
            this.dateL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateL.ForeColor = System.Drawing.Color.Black;
            this.dateL.Location = new System.Drawing.Point(54, 149);
            this.dateL.Name = "dateL";
            this.dateL.Size = new System.Drawing.Size(285, 21);
            this.dateL.TabIndex = 155;
            this.dateL.Text = "Дата доставки в пункт самовывоза:  ";
            // 
            // dateCB
            // 
            this.dateCB.Animated = true;
            this.dateCB.BackColor = System.Drawing.Color.Transparent;
            this.dateCB.BorderColor = System.Drawing.Color.Gainsboro;
            this.dateCB.BorderRadius = 10;
            this.dateCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dateCB.DropDownHeight = 150;
            this.dateCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateCB.FillColor = System.Drawing.Color.Gainsboro;
            this.dateCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dateCB.FocusedState.Parent = this.dateCB;
            this.dateCB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dateCB.ForeColor = System.Drawing.Color.Black;
            this.dateCB.HoverState.Parent = this.dateCB;
            this.dateCB.IntegralHeight = false;
            this.dateCB.ItemHeight = 30;
            this.dateCB.ItemsAppearance.Parent = this.dateCB;
            this.dateCB.Location = new System.Drawing.Point(55, 174);
            this.dateCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.dateCB.Name = "dateCB";
            this.dateCB.ShadowDecoration.Parent = this.dateCB;
            this.dateCB.Size = new System.Drawing.Size(392, 36);
            this.dateCB.TabIndex = 156;
            // 
            // elipseOrderRealisation
            // 
            this.elipseOrderRealisation.BorderRadius = 40;
            this.elipseOrderRealisation.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this.panel;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderColor = System.Drawing.Color.DimGray;
            this.panel.BorderRadius = 16;
            this.panel.BorderThickness = 5;
            this.panel.Controls.Add(this.sendEmailL);
            this.panel.Controls.Add(this.sendIB);
            this.panel.Controls.Add(this.costL);
            this.panel.Controls.Add(this.selfPickUpPointL);
            this.panel.Controls.Add(this.addressesCB);
            this.panel.Controls.Add(this.orderL);
            this.panel.Controls.Add(this.dateL);
            this.panel.Controls.Add(this.dateCB);
            this.panel.Controls.Add(this.exitControlBox);
            this.panel.Controls.Add(this.orderB);
            this.panel.CustomBorderColor = System.Drawing.Color.Black;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(493, 384);
            this.panel.TabIndex = 162;
            // 
            // sendEmailL
            // 
            this.sendEmailL.AutoSize = true;
            this.sendEmailL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.sendEmailL.ForeColor = System.Drawing.Color.Black;
            this.sendEmailL.Location = new System.Drawing.Point(93, 270);
            this.sendEmailL.Name = "sendEmailL";
            this.sendEmailL.Size = new System.Drawing.Size(200, 21);
            this.sendEmailL.TabIndex = 165;
            this.sendEmailL.Text = "Отправить заказ на почту";
            // 
            // sendIB
            // 
            this.sendIB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sendIB.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.sendIB.CheckedState.Parent = this.sendIB;
            this.sendIB.HoverState.ImageSize = new System.Drawing.Size(37, 37);
            this.sendIB.HoverState.Parent = this.sendIB;
            this.sendIB.Image = global::M_SHOES.BY.Properties.Resources.Yes;
            this.sendIB.ImageRotate = 0F;
            this.sendIB.ImageSize = new System.Drawing.Size(32, 32);
            this.sendIB.Location = new System.Drawing.Point(55, 262);
            this.sendIB.Name = "sendIB";
            this.sendIB.PressedState.ImageSize = new System.Drawing.Size(37, 37);
            this.sendIB.PressedState.Parent = this.sendIB;
            this.sendIB.Size = new System.Drawing.Size(40, 40);
            this.sendIB.TabIndex = 164;
            this.sendIB.Click += new System.EventHandler(this.SendIB_Click);
            // 
            // costL
            // 
            this.costL.AutoSize = true;
            this.costL.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costL.ForeColor = System.Drawing.Color.Black;
            this.costL.Location = new System.Drawing.Point(53, 226);
            this.costL.Name = "costL";
            this.costL.Size = new System.Drawing.Size(166, 23);
            this.costL.TabIndex = 162;
            this.costL.Text = "Стоимость заказа:  ";
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.BorderColor = System.Drawing.Color.White;
            this.exitControlBox.BorderRadius = 15;
            this.exitControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.exitControlBox.FillColor = System.Drawing.Color.DimGray;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(448, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 106;
            // 
            // orderB
            // 
            this.orderB.Animated = true;
            this.orderB.BorderRadius = 10;
            this.orderB.CheckedState.Parent = this.orderB;
            this.orderB.CustomImages.Parent = this.orderB;
            this.orderB.FillColor = System.Drawing.Color.Green;
            this.orderB.FillColor2 = System.Drawing.Color.Teal;
            this.orderB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.orderB.ForeColor = System.Drawing.Color.White;
            this.orderB.HoverState.Parent = this.orderB;
            this.orderB.Location = new System.Drawing.Point(55, 326);
            this.orderB.Name = "orderB";
            this.orderB.ShadowDecoration.Parent = this.orderB;
            this.orderB.Size = new System.Drawing.Size(392, 45);
            this.orderB.TabIndex = 166;
            this.orderB.Text = "Заказать";
            this.orderB.Click += new System.EventHandler(this.OrderB_Click);
            // 
            // OrderRealisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 384);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderRealisation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "M-SHOES.BY";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label orderL;
        private System.Windows.Forms.Label selfPickUpPointL;
        private Guna.UI2.WinForms.Guna2ComboBox addressesCB;
        private System.Windows.Forms.Label dateL;
        private Guna.UI2.WinForms.Guna2ComboBox dateCB;
        private Guna.UI2.WinForms.Guna2Elipse elipseOrderRealisation;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private System.Windows.Forms.Label costL;
        private Guna.UI2.WinForms.Guna2ImageButton sendIB;
        private System.Windows.Forms.Label sendEmailL;
        private Guna.UI2.WinForms.Guna2GradientButton orderB;
    }
}