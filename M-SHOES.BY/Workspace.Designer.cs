
namespace M_SHOES.BY
{
    partial class Workspace
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
            this.workLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableEditorB = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.BackColor = System.Drawing.Color.Transparent;
            this.workLabel.Font = new System.Drawing.Font("Century Gothic", 30F);
            this.workLabel.ForeColor = System.Drawing.Color.DimGray;
            this.workLabel.Location = new System.Drawing.Point(45, 45);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(341, 49);
            this.workLabel.TabIndex = 103;
            this.workLabel.Text = "Рабочая среда:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(99, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 104;
            this.label1.Text = "Перейти в:";
            // 
            // tableEditorB
            // 
            this.tableEditorB.Animated = true;
            this.tableEditorB.BackColor = System.Drawing.Color.Transparent;
            this.tableEditorB.CheckedState.Parent = this.tableEditorB;
            this.tableEditorB.CustomImages.Parent = this.tableEditorB;
            this.tableEditorB.FillColor = System.Drawing.Color.Transparent;
            this.tableEditorB.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tableEditorB.ForeColor = System.Drawing.Color.Black;
            this.tableEditorB.HoverState.Parent = this.tableEditorB;
            this.tableEditorB.Image = global::M_SHOES.BY.Properties.Resources.Workspace;
            this.tableEditorB.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableEditorB.ImageSize = new System.Drawing.Size(40, 40);
            this.tableEditorB.Location = new System.Drawing.Point(105, 188);
            this.tableEditorB.Margin = new System.Windows.Forms.Padding(0);
            this.tableEditorB.Name = "tableEditorB";
            this.tableEditorB.ShadowDecoration.Parent = this.tableEditorB;
            this.tableEditorB.Size = new System.Drawing.Size(921, 60);
            this.tableEditorB.TabIndex = 105;
            this.tableEditorB.Text = "Редактор таблиц";
            this.tableEditorB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tableEditorB.Click += new System.EventHandler(this.TableEditorB_Click);
            // 
            // Workspace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableEditorB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.workLabel);
            this.Name = "Workspace";
            this.Size = new System.Drawing.Size(1086, 840);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button tableEditorB;
    }
}
