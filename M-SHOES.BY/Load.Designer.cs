namespace M_SHOES.BY
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressL = new System.Windows.Forms.Label();
            this.logoPB = new Guna.UI2.WinForms.Guna2PictureBox();
            this.circlePB = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.elipseLoad = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loadT = new System.Windows.Forms.Timer(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.exitControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.progressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePB)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Controls.Add(this.progressL);
            this.progressBar.Controls.Add(this.logoPB);
            this.progressBar.Controls.Add(this.circlePB);
            this.progressBar.FillColor = System.Drawing.Color.CornflowerBlue;
            this.progressBar.FillThickness = 25;
            this.progressBar.Location = new System.Drawing.Point(137, 54);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.SpringGreen;
            this.progressBar.ProgressColor2 = System.Drawing.Color.SpringGreen;
            this.progressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressThickness = 25;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(352, 334);
            this.progressBar.TabIndex = 1;
            // 
            // progressL
            // 
            this.progressL.AutoSize = true;
            this.progressL.BackColor = System.Drawing.Color.Transparent;
            this.progressL.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold);
            this.progressL.ForeColor = System.Drawing.Color.White;
            this.progressL.Location = new System.Drawing.Point(125, 207);
            this.progressL.Name = "progressL";
            this.progressL.Size = new System.Drawing.Size(53, 30);
            this.progressL.TabIndex = 1;
            this.progressL.Text = "0 %";
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.Transparent;
            this.logoPB.Image = global::M_SHOES.BY.Properties.Resources.Logo;
            this.logoPB.Location = new System.Drawing.Point(54, 70);
            this.logoPB.Name = "logoPB";
            this.logoPB.ShadowDecoration.Parent = this.logoPB;
            this.logoPB.Size = new System.Drawing.Size(208, 111);
            this.logoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPB.TabIndex = 126;
            this.logoPB.TabStop = false;
            // 
            // circlePB
            // 
            this.circlePB.FillColor = System.Drawing.Color.DimGray;
            this.circlePB.Location = new System.Drawing.Point(23, 24);
            this.circlePB.Name = "circlePB";
            this.circlePB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePB.ShadowDecoration.Parent = this.circlePB;
            this.circlePB.Size = new System.Drawing.Size(306, 289);
            this.circlePB.TabIndex = 3;
            this.circlePB.TabStop = false;
            // 
            // elipseLoad
            // 
            this.elipseLoad.BorderRadius = 35;
            this.elipseLoad.TargetControl = this;
            // 
            // loadT
            // 
            this.loadT.Enabled = true;
            this.loadT.Interval = 10;
            this.loadT.Tick += new System.EventHandler(this.LoadT_Tick);
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
            this.exitControlBox.Location = new System.Drawing.Point(579, 12);
            this.exitControlBox.Name = "exitControlBox";
            this.exitControlBox.ShadowDecoration.Parent = this.exitControlBox;
            this.exitControlBox.Size = new System.Drawing.Size(33, 32);
            this.exitControlBox.TabIndex = 91;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::M_SHOES.BY.Properties.Resources.BackgroundLoad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 436);
            this.Controls.Add(this.exitControlBox);
            this.Controls.Add(this.progressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M-SHOES.BY";
            this.progressBar.ResumeLayout(false);
            this.progressBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Elipse elipseLoad;
        private System.Windows.Forms.Timer loadT;
        private System.Windows.Forms.Label progressL;
        private Guna.UI2.WinForms.Guna2PictureBox logoPB;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePB;
        private Guna.UI2.WinForms.Guna2ControlBox exitControlBox;
    }
}