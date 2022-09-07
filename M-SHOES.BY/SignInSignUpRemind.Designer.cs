
namespace M_SHOES.BY
{
    partial class SignInSignUpRemind
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInSignUpRemind));
            this.elipseSignInSignUpRemind = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.foldingControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutPanel = new M_SHOES.BY.FlowLayoutPanelDoubleBuffered();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // elipseSignInSignUpRemind
            // 
            this.elipseSignInSignUpRemind.BorderRadius = 35;
            this.elipseSignInSignUpRemind.TargetControl = this;
            // 
            // dragControl
            // 
            this.dragControl.ContainerControl = this;
            this.dragControl.TargetControl = this;
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
            this.exitControlBox.Location = new System.Drawing.Point(1164, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 86;
            this.exitControlBox.Click += new System.EventHandler(this.ExitControlBox_Click);
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
            this.foldingControlBox.Location = new System.Drawing.Point(1125, 12);
            this.foldingControlBox.Name = "foldingControlBox";
            this.foldingControlBox.ShadowDecoration.Parent = this.foldingControlBox;
            this.foldingControlBox.Size = new System.Drawing.Size(33, 32);
            this.foldingControlBox.TabIndex = 87;
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.Image = global::M_SHOES.BY.Properties.Resources.Logo;
            this.logoPB.Location = new System.Drawing.Point(499, 71);
            this.logoPB.Name = "logoPB";
            this.logoPB.ShadowDecoration.Parent = this.logoPB;
            this.logoPB.Size = new System.Drawing.Size(208, 111);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 125;
            this.logoPB.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 20;
            this.panel.Controls.Add(this.flowLayoutPanel);
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(426, 198);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(358, 557);
            this.panel.TabIndex = 126;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 15);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel.Size = new System.Drawing.Size(330, 525);
            this.flowLayoutPanel.TabIndex = 124;
            // 
            // SignInSignUpRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::M_SHOES.BY.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1209, 850);
            this.Controls.Add(this.logoPB);
            this.Controls.Add(this.foldingControlBox);
            this.Controls.Add(this.exitControlBox);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignInSignUpRemind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M-SHOES.BY";
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse elipseSignInSignUpRemind;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2ControlBox foldingControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
        private FlowLayoutPanelDoubleBuffered flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2Panel panel;
    }
}

