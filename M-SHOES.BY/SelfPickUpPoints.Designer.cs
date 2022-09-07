
namespace M_SHOES.BY
{
    partial class SelfPickUpPoints
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.workLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.informationRTB = new System.Windows.Forms.RichTextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.addressesLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.progressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.progressL = new System.Windows.Forms.Label();
            this.connectInternetL = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.loadT = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.progressBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 10);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(454, 672);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1_DocumentCompleted);
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.BackColor = System.Drawing.Color.Transparent;
            this.workLabel.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.workLabel.ForeColor = System.Drawing.Color.DimGray;
            this.workLabel.Location = new System.Drawing.Point(45, 45);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(427, 49);
            this.workLabel.TabIndex = 102;
            this.workLabel.Text = "Пункты самовывоза:";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.BorderRadius = 15;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.informationRTB);
            this.guna2Panel2.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel2.Location = new System.Drawing.Point(35, 355);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(526, 503);
            this.guna2Panel2.TabIndex = 136;
            // 
            // informationRTB
            // 
            this.informationRTB.BackColor = System.Drawing.Color.Gainsboro;
            this.informationRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationRTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.informationRTB.ForeColor = System.Drawing.Color.Black;
            this.informationRTB.Location = new System.Drawing.Point(19, 18);
            this.informationRTB.MaxLength = 4000;
            this.informationRTB.Name = "informationRTB";
            this.informationRTB.ReadOnly = true;
            this.informationRTB.Size = new System.Drawing.Size(504, 468);
            this.informationRTB.TabIndex = 0;
            this.informationRTB.Text = "";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.addressesLB);
            this.guna2Panel1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Location = new System.Drawing.Point(35, 165);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(526, 137);
            this.guna2Panel1.TabIndex = 137;
            // 
            // addressesLB
            // 
            this.addressesLB.BackColor = System.Drawing.Color.Gainsboro;
            this.addressesLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressesLB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addressesLB.ForeColor = System.Drawing.Color.Black;
            this.addressesLB.FormattingEnabled = true;
            this.addressesLB.ItemHeight = 21;
            this.addressesLB.Location = new System.Drawing.Point(19, 10);
            this.addressesLB.Name = "addressesLB";
            this.addressesLB.Size = new System.Drawing.Size(504, 105);
            this.addressesLB.TabIndex = 0;
            this.addressesLB.SelectedIndexChanged += new System.EventHandler(this.AddressesLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(46, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 138;
            this.label1.Text = "адреса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(46, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "информация";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.BorderRadius = 15;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.progressBar);
            this.guna2Panel3.Controls.Add(this.connectInternetL);
            this.guna2Panel3.Controls.Add(this.webBrowser1);
            this.guna2Panel3.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel3.Location = new System.Drawing.Point(586, 165);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 15);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Padding = new System.Windows.Forms.Padding(3);
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(481, 693);
            this.guna2Panel3.TabIndex = 140;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Controls.Add(this.progressL);
            this.progressBar.FillColor = System.Drawing.Color.Silver;
            this.progressBar.FillThickness = 25;
            this.progressBar.Location = new System.Drawing.Point(90, 190);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.SpringGreen;
            this.progressBar.ProgressColor2 = System.Drawing.Color.SpringGreen;
            this.progressBar.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.progressBar.ProgressThickness = 25;
            this.progressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar.ShadowDecoration.Parent = this.progressBar;
            this.progressBar.Size = new System.Drawing.Size(306, 290);
            this.progressBar.TabIndex = 125;
            // 
            // progressL
            // 
            this.progressL.AutoSize = true;
            this.progressL.BackColor = System.Drawing.Color.Transparent;
            this.progressL.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold);
            this.progressL.ForeColor = System.Drawing.Color.DarkGray;
            this.progressL.Location = new System.Drawing.Point(119, 125);
            this.progressL.Name = "progressL";
            this.progressL.Size = new System.Drawing.Size(67, 37);
            this.progressL.TabIndex = 1;
            this.progressL.Text = "0 %";
            // 
            // connectInternetL
            // 
            this.connectInternetL.AutoSize = true;
            this.connectInternetL.BackColor = System.Drawing.Color.White;
            this.connectInternetL.Font = new System.Drawing.Font("Montserrat", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectInternetL.ForeColor = System.Drawing.Color.DimGray;
            this.connectInternetL.Location = new System.Drawing.Point(120, 279);
            this.connectInternetL.MaximumSize = new System.Drawing.Size(300, 0);
            this.connectInternetL.Name = "connectInternetL";
            this.connectInternetL.Size = new System.Drawing.Size(250, 104);
            this.connectInternetL.TabIndex = 124;
            this.connectInternetL.Text = "Отсутствует подключение к Интернету.";
            this.connectInternetL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.connectInternetL.UseCompatibleTextRendering = true;
            this.connectInternetL.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.webBrowser1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(594, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 141;
            this.label3.Text = "карта";
            // 
            // loadT
            // 
            this.loadT.Enabled = true;
            this.loadT.Interval = 10;
            this.loadT.Tick += new System.EventHandler(this.LoadT_Tick);
            // 
            // SelfPickUpPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.workLabel);
            this.Name = "SelfPickUpPoints";
            this.Size = new System.Drawing.Size(1086, 880);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.progressBar.ResumeLayout(false);
            this.progressBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label workLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.RichTextBox informationRTB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox addressesLB;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label connectInternetL;
        private System.Windows.Forms.Label progressL;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar;
        private System.Windows.Forms.Timer loadT;
    }
}
