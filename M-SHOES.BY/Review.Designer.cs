
namespace M_SHOES.BY
{
    partial class Review
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
            this.ratingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.nameAndDateL = new System.Windows.Forms.Label();
            this.reviewText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ratingStar
            // 
            this.ratingStar.Location = new System.Drawing.Point(3, 3);
            this.ratingStar.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.RatingColor = System.Drawing.Color.Gold;
            this.ratingStar.Size = new System.Drawing.Size(120, 30);
            this.ratingStar.TabIndex = 147;
            this.ratingStar.Value = 5F;
            this.ratingStar.ValueChanged += new System.EventHandler(this.RatingStar_ValueChanged);
            // 
            // nameAndDateL
            // 
            this.nameAndDateL.AutoSize = true;
            this.nameAndDateL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAndDateL.ForeColor = System.Drawing.Color.Black;
            this.nameAndDateL.Location = new System.Drawing.Point(137, 7);
            this.nameAndDateL.Margin = new System.Windows.Forms.Padding(3);
            this.nameAndDateL.Name = "nameAndDateL";
            this.nameAndDateL.Size = new System.Drawing.Size(122, 21);
            this.nameAndDateL.TabIndex = 148;
            this.nameAndDateL.Text = "nameAndDateL";
            // 
            // reviewText
            // 
            this.reviewText.AutoSize = true;
            this.reviewText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reviewText.ForeColor = System.Drawing.Color.Black;
            this.reviewText.Location = new System.Drawing.Point(141, 34);
            this.reviewText.Margin = new System.Windows.Forms.Padding(3);
            this.reviewText.MaximumSize = new System.Drawing.Size(416, 0);
            this.reviewText.MinimumSize = new System.Drawing.Size(416, 0);
            this.reviewText.Name = "reviewText";
            this.reviewText.Size = new System.Drawing.Size(416, 21);
            this.reviewText.TabIndex = 150;
            this.reviewText.Text = "label1";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reviewText);
            this.Controls.Add(this.nameAndDateL);
            this.Controls.Add(this.ratingStar);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Name = "Review";
            this.Size = new System.Drawing.Size(560, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2RatingStar ratingStar;
        private System.Windows.Forms.Label nameAndDateL;
        private System.Windows.Forms.Label reviewText;
    }
}
