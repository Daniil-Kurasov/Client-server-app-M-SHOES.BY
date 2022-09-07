
namespace M_SHOES.BY
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.elipseMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.foldingControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuP = new Guna.UI2.WinForms.Guna2Panel();
            this.menuFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.avatarPB = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.nameL = new System.Windows.Forms.Label();
            this.accountSettingsB = new Guna.UI2.WinForms.Guna2Button();
            this.shoesB = new Guna.UI2.WinForms.Guna2Button();
            this.basketB = new Guna.UI2.WinForms.Guna2Button();
            this.likedB = new Guna.UI2.WinForms.Guna2Button();
            this.selfPickUpPointsB = new Guna.UI2.WinForms.Guna2Button();
            this.ordersB = new Guna.UI2.WinForms.Guna2Button();
            this.workspaceB = new Guna.UI2.WinForms.Guna2Button();
            this.exitB = new Guna.UI2.WinForms.Guna2Button();
            this.mainP = new Guna.UI2.WinForms.Guna2Panel();
            this.mainFLP = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            this.elipseMainFLP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseMenuFLP = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.menuP.SuspendLayout();
            this.menuFLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).BeginInit();
            this.mainP.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseMain
            // 
            this.elipseMain.BorderRadius = 35;
            this.elipseMain.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this;
            // 
            // foldingControlBox
            // 
            this.foldingControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.foldingControlBox.Animated = true;
            this.foldingControlBox.BackColor = System.Drawing.Color.Transparent;
            this.foldingControlBox.BorderColor = System.Drawing.Color.White;
            this.foldingControlBox.BorderRadius = 15;
            this.foldingControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.foldingControlBox.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.foldingControlBox.FillColor = System.Drawing.Color.Black;
            this.foldingControlBox.HoverState.Parent = this.foldingControlBox;
            this.foldingControlBox.IconColor = System.Drawing.Color.White;
            this.foldingControlBox.Location = new System.Drawing.Point(1286, 12);
            this.foldingControlBox.Name = "foldingControlBox";
            this.foldingControlBox.ShadowDecoration.Parent = this.foldingControlBox;
            this.foldingControlBox.Size = new System.Drawing.Size(33, 32);
            this.foldingControlBox.TabIndex = 91;
            // 
            // exitControlBox
            // 
            this.exitControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitControlBox.Animated = true;
            this.exitControlBox.BackColor = System.Drawing.Color.Transparent;
            this.exitControlBox.BorderColor = System.Drawing.Color.White;
            this.exitControlBox.BorderRadius = 15;
            this.exitControlBox.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.exitControlBox.FillColor = System.Drawing.Color.Black;
            this.exitControlBox.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.exitControlBox.HoverState.Parent = this.exitControlBox;
            this.exitControlBox.IconColor = System.Drawing.Color.White;
            this.exitControlBox.Location = new System.Drawing.Point(1325, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 90;
            this.exitControlBox.Click += new System.EventHandler(this.ExitControlBox_Click);
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.Image = global::M_SHOES.BY.Properties.Resources.Logo;
            this.logoPB.Location = new System.Drawing.Point(582, -2);
            this.logoPB.Name = "logoPB";
            this.logoPB.ShadowDecoration.Parent = this.logoPB;
            this.logoPB.Size = new System.Drawing.Size(177, 89);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 126;
            this.logoPB.TabStop = false;
            // 
            // menuP
            // 
            this.menuP.BackColor = System.Drawing.Color.Transparent;
            this.menuP.BorderRadius = 20;
            this.menuP.Controls.Add(this.menuFLP);
            this.menuP.FillColor = System.Drawing.Color.White;
            this.menuP.Location = new System.Drawing.Point(12, 105);
            this.menuP.Name = "menuP";
            this.menuP.ShadowDecoration.Parent = this.menuP;
            this.menuP.Size = new System.Drawing.Size(227, 902);
            this.menuP.TabIndex = 132;
            // 
            // menuFLP
            // 
            this.menuFLP.BackColor = System.Drawing.Color.White;
            this.menuFLP.Controls.Add(this.avatarPB);
            this.menuFLP.Controls.Add(this.nameL);
            this.menuFLP.Controls.Add(this.accountSettingsB);
            this.menuFLP.Controls.Add(this.shoesB);
            this.menuFLP.Controls.Add(this.basketB);
            this.menuFLP.Controls.Add(this.likedB);
            this.menuFLP.Controls.Add(this.selfPickUpPointsB);
            this.menuFLP.Controls.Add(this.ordersB);
            this.menuFLP.Controls.Add(this.workspaceB);
            this.menuFLP.Controls.Add(this.exitB);
            this.menuFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.menuFLP.Location = new System.Drawing.Point(5, 3);
            this.menuFLP.Name = "menuFLP";
            this.menuFLP.Size = new System.Drawing.Size(219, 896);
            this.menuFLP.TabIndex = 130;
            // 
            // avatarPB
            // 
            this.avatarPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatarPB.ErrorImage = null;
            this.avatarPB.FillColor = System.Drawing.Color.Transparent;
            this.avatarPB.Image = global::M_SHOES.BY.Properties.Resources.Avatar;
            this.avatarPB.Location = new System.Drawing.Point(33, 20);
            this.avatarPB.Margin = new System.Windows.Forms.Padding(33, 20, 3, 3);
            this.avatarPB.Name = "avatarPB";
            this.avatarPB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatarPB.ShadowDecoration.Parent = this.avatarPB;
            this.avatarPB.Size = new System.Drawing.Size(149, 143);
            this.avatarPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatarPB.TabIndex = 2;
            this.avatarPB.TabStop = false;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameL.ForeColor = System.Drawing.Color.Black;
            this.nameL.Location = new System.Drawing.Point(33, 181);
            this.nameL.Margin = new System.Windows.Forms.Padding(33, 15, 3, 30);
            this.nameL.MaximumSize = new System.Drawing.Size(149, 0);
            this.nameL.MinimumSize = new System.Drawing.Size(149, 0);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(149, 25);
            this.nameL.TabIndex = 3;
            this.nameL.Text = "User";
            this.nameL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // accountSettingsB
            // 
            this.accountSettingsB.BackColor = System.Drawing.Color.Transparent;
            this.accountSettingsB.CheckedState.Parent = this.accountSettingsB;
            this.accountSettingsB.CustomImages.Parent = this.accountSettingsB;
            this.accountSettingsB.FillColor = System.Drawing.Color.White;
            this.accountSettingsB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.accountSettingsB.ForeColor = System.Drawing.Color.Black;
            this.accountSettingsB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.accountSettingsB.HoverState.Parent = this.accountSettingsB;
            this.accountSettingsB.Image = global::M_SHOES.BY.Properties.Resources.AccountSettings;
            this.accountSettingsB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountSettingsB.ImageSize = new System.Drawing.Size(40, 40);
            this.accountSettingsB.Location = new System.Drawing.Point(0, 242);
            this.accountSettingsB.Margin = new System.Windows.Forms.Padding(0, 6, 0, 5);
            this.accountSettingsB.Name = "accountSettingsB";
            this.accountSettingsB.PressedColor = System.Drawing.Color.Gainsboro;
            this.accountSettingsB.PressedDepth = 0;
            this.accountSettingsB.ShadowDecoration.Parent = this.accountSettingsB;
            this.accountSettingsB.Size = new System.Drawing.Size(219, 60);
            this.accountSettingsB.TabIndex = 3;
            this.accountSettingsB.Text = "Настройки аккаунта";
            this.accountSettingsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.accountSettingsB.Click += new System.EventHandler(this.AccountSettingsB_Click);
            // 
            // shoesB
            // 
            this.shoesB.BackColor = System.Drawing.Color.Transparent;
            this.shoesB.CheckedState.Parent = this.shoesB;
            this.shoesB.CustomImages.Parent = this.shoesB;
            this.shoesB.FillColor = System.Drawing.Color.White;
            this.shoesB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.shoesB.ForeColor = System.Drawing.Color.Black;
            this.shoesB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.shoesB.HoverState.Parent = this.shoesB;
            this.shoesB.Image = global::M_SHOES.BY.Properties.Resources.Shoes;
            this.shoesB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shoesB.ImageSize = new System.Drawing.Size(40, 40);
            this.shoesB.Location = new System.Drawing.Point(0, 307);
            this.shoesB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.shoesB.Name = "shoesB";
            this.shoesB.PressedColor = System.Drawing.Color.Gainsboro;
            this.shoesB.PressedDepth = 0;
            this.shoesB.ShadowDecoration.Parent = this.shoesB;
            this.shoesB.Size = new System.Drawing.Size(219, 60);
            this.shoesB.TabIndex = 7;
            this.shoesB.Text = "Обувь";
            this.shoesB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.shoesB.Click += new System.EventHandler(this.ShoesB_Click);
            // 
            // basketB
            // 
            this.basketB.BackColor = System.Drawing.Color.Transparent;
            this.basketB.CheckedState.Parent = this.basketB;
            this.basketB.CustomImages.Parent = this.basketB;
            this.basketB.FillColor = System.Drawing.Color.White;
            this.basketB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.basketB.ForeColor = System.Drawing.Color.Black;
            this.basketB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.basketB.HoverState.Parent = this.basketB;
            this.basketB.Image = global::M_SHOES.BY.Properties.Resources.Basket;
            this.basketB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.basketB.ImageSize = new System.Drawing.Size(40, 40);
            this.basketB.Location = new System.Drawing.Point(0, 372);
            this.basketB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.basketB.Name = "basketB";
            this.basketB.PressedColor = System.Drawing.Color.Gainsboro;
            this.basketB.PressedDepth = 0;
            this.basketB.ShadowDecoration.Parent = this.basketB;
            this.basketB.Size = new System.Drawing.Size(219, 60);
            this.basketB.TabIndex = 9;
            this.basketB.Text = "Корзина";
            this.basketB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.basketB.Click += new System.EventHandler(this.BasketB_Click);
            // 
            // likedB
            // 
            this.likedB.BackColor = System.Drawing.Color.Transparent;
            this.likedB.CheckedState.Parent = this.likedB;
            this.likedB.CustomImages.Parent = this.likedB;
            this.likedB.FillColor = System.Drawing.Color.White;
            this.likedB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.likedB.ForeColor = System.Drawing.Color.Black;
            this.likedB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.likedB.HoverState.Parent = this.likedB;
            this.likedB.Image = global::M_SHOES.BY.Properties.Resources.Liked;
            this.likedB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.likedB.ImageSize = new System.Drawing.Size(40, 40);
            this.likedB.Location = new System.Drawing.Point(0, 437);
            this.likedB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.likedB.Name = "likedB";
            this.likedB.PressedColor = System.Drawing.Color.Gainsboro;
            this.likedB.PressedDepth = 0;
            this.likedB.ShadowDecoration.Parent = this.likedB;
            this.likedB.Size = new System.Drawing.Size(219, 60);
            this.likedB.TabIndex = 10;
            this.likedB.Text = "Понравившиеся";
            this.likedB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.likedB.Click += new System.EventHandler(this.LikedB_Click);
            // 
            // selfPickUpPointsB
            // 
            this.selfPickUpPointsB.BackColor = System.Drawing.Color.Transparent;
            this.selfPickUpPointsB.CheckedState.Parent = this.selfPickUpPointsB;
            this.selfPickUpPointsB.CustomImages.Parent = this.selfPickUpPointsB;
            this.selfPickUpPointsB.FillColor = System.Drawing.Color.White;
            this.selfPickUpPointsB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.selfPickUpPointsB.ForeColor = System.Drawing.Color.Black;
            this.selfPickUpPointsB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.selfPickUpPointsB.HoverState.Parent = this.selfPickUpPointsB;
            this.selfPickUpPointsB.Image = global::M_SHOES.BY.Properties.Resources.SelfPickUpPoints;
            this.selfPickUpPointsB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.selfPickUpPointsB.ImageSize = new System.Drawing.Size(40, 40);
            this.selfPickUpPointsB.Location = new System.Drawing.Point(0, 502);
            this.selfPickUpPointsB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.selfPickUpPointsB.Name = "selfPickUpPointsB";
            this.selfPickUpPointsB.PressedColor = System.Drawing.Color.Gainsboro;
            this.selfPickUpPointsB.PressedDepth = 0;
            this.selfPickUpPointsB.ShadowDecoration.Parent = this.selfPickUpPointsB;
            this.selfPickUpPointsB.Size = new System.Drawing.Size(219, 60);
            this.selfPickUpPointsB.TabIndex = 4;
            this.selfPickUpPointsB.Text = "Пункты самовывоза";
            this.selfPickUpPointsB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.selfPickUpPointsB.Click += new System.EventHandler(this.SelfPickUpPointsB_Click);
            // 
            // ordersB
            // 
            this.ordersB.BackColor = System.Drawing.Color.Transparent;
            this.ordersB.CheckedState.Parent = this.ordersB;
            this.ordersB.CustomImages.Parent = this.ordersB;
            this.ordersB.FillColor = System.Drawing.Color.White;
            this.ordersB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ordersB.ForeColor = System.Drawing.Color.Black;
            this.ordersB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.ordersB.HoverState.Parent = this.ordersB;
            this.ordersB.Image = global::M_SHOES.BY.Properties.Resources.Orders;
            this.ordersB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordersB.ImageSize = new System.Drawing.Size(40, 40);
            this.ordersB.Location = new System.Drawing.Point(0, 567);
            this.ordersB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ordersB.Name = "ordersB";
            this.ordersB.PressedColor = System.Drawing.Color.Gainsboro;
            this.ordersB.PressedDepth = 0;
            this.ordersB.ShadowDecoration.Parent = this.ordersB;
            this.ordersB.Size = new System.Drawing.Size(219, 60);
            this.ordersB.TabIndex = 8;
            this.ordersB.Text = "Заказы";
            this.ordersB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ordersB.Click += new System.EventHandler(this.OrdersB_Click);
            // 
            // workspaceB
            // 
            this.workspaceB.BackColor = System.Drawing.Color.Transparent;
            this.workspaceB.CheckedState.Parent = this.workspaceB;
            this.workspaceB.CustomImages.Parent = this.workspaceB;
            this.workspaceB.FillColor = System.Drawing.Color.White;
            this.workspaceB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.workspaceB.ForeColor = System.Drawing.Color.Black;
            this.workspaceB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.workspaceB.HoverState.Parent = this.workspaceB;
            this.workspaceB.Image = global::M_SHOES.BY.Properties.Resources.Workspace;
            this.workspaceB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.workspaceB.ImageSize = new System.Drawing.Size(40, 40);
            this.workspaceB.Location = new System.Drawing.Point(0, 632);
            this.workspaceB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.workspaceB.Name = "workspaceB";
            this.workspaceB.PressedColor = System.Drawing.Color.Gainsboro;
            this.workspaceB.PressedDepth = 0;
            this.workspaceB.ShadowDecoration.Parent = this.workspaceB;
            this.workspaceB.Size = new System.Drawing.Size(219, 60);
            this.workspaceB.TabIndex = 6;
            this.workspaceB.Text = "Рабочая среда";
            this.workspaceB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.workspaceB.Visible = false;
            this.workspaceB.Click += new System.EventHandler(this.WorkspaceB_Click);
            // 
            // exitB
            // 
            this.exitB.BackColor = System.Drawing.Color.Transparent;
            this.exitB.CheckedState.Parent = this.exitB;
            this.exitB.CustomImages.Parent = this.exitB;
            this.exitB.FillColor = System.Drawing.Color.White;
            this.exitB.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.exitB.ForeColor = System.Drawing.Color.Black;
            this.exitB.HoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.exitB.HoverState.Parent = this.exitB;
            this.exitB.Image = global::M_SHOES.BY.Properties.Resources.Exit;
            this.exitB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitB.ImageSize = new System.Drawing.Size(40, 40);
            this.exitB.Location = new System.Drawing.Point(0, 697);
            this.exitB.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.exitB.Name = "exitB";
            this.exitB.PressedColor = System.Drawing.Color.Gainsboro;
            this.exitB.PressedDepth = 0;
            this.exitB.ShadowDecoration.Parent = this.exitB;
            this.exitB.Size = new System.Drawing.Size(219, 60);
            this.exitB.TabIndex = 5;
            this.exitB.Text = "Выход";
            this.exitB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitB.Click += new System.EventHandler(this.ExitB_Click);
            // 
            // mainP
            // 
            this.mainP.BackColor = System.Drawing.Color.Transparent;
            this.mainP.BorderRadius = 20;
            this.mainP.Controls.Add(this.mainFLP);
            this.mainP.FillColor = System.Drawing.Color.White;
            this.mainP.Location = new System.Drawing.Point(245, 105);
            this.mainP.Name = "mainP";
            this.mainP.ShadowDecoration.Parent = this.mainP;
            this.mainP.Size = new System.Drawing.Size(1112, 902);
            this.mainP.TabIndex = 133;
            // 
            // mainFLP
            // 
            this.mainFLP.BackColor = System.Drawing.Color.White;
            this.mainFLP.Location = new System.Drawing.Point(3, 3);
            this.mainFLP.Name = "mainFLP";
            this.mainFLP.Size = new System.Drawing.Size(1106, 896);
            this.mainFLP.TabIndex = 127;
            // 
            // elipseMainFLP
            // 
            this.elipseMainFLP.BorderRadius = 40;
            this.elipseMainFLP.TargetControl = this.mainFLP;
            // 
            // elipseMenuFLP
            // 
            this.elipseMenuFLP.BorderRadius = 40;
            this.elipseMenuFLP.TargetControl = this.menuFLP;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M_SHOES.BY.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 1019);
            this.Controls.Add(this.mainP);
            this.Controls.Add(this.menuP);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.foldingControlBox);
            this.Controls.Add(this.exitControlBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M-SHOES.BY";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.menuP.ResumeLayout(false);
            this.menuFLP.ResumeLayout(false);
            this.menuFLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPB)).EndInit();
            this.mainP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse elipseMain;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ControlBox foldingControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private FlowLayoutPanelDoubleBuffered mainFLP;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Elipse elipseMainFLP;
        private Guna.UI2.WinForms.Guna2Elipse elipseMenuFLP;
        private FlowLayoutPanelDoubleBuffered menuFLP;
        internal Guna.UI2.WinForms.Guna2CirclePictureBox avatarPB;
        public System.Windows.Forms.Label nameL;
        private Guna.UI2.WinForms.Guna2Button accountSettingsB;
        private Guna.UI2.WinForms.Guna2Button selfPickUpPointsB;
        private Guna.UI2.WinForms.Guna2Button exitB;
        private Guna.UI2.WinForms.Guna2Button workspaceB;
        private Guna.UI2.WinForms.Guna2Button shoesB;
        private Guna.UI2.WinForms.Guna2Button ordersB;
        private Guna.UI2.WinForms.Guna2Button basketB;
        private Guna.UI2.WinForms.Guna2Button likedB;
        private Guna.UI2.WinForms.Guna2Panel menuP;
        private Guna.UI2.WinForms.Guna2Panel mainP;
    }
}