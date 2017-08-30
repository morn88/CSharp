namespace WebmLoader
{
    partial class Form1
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
            this.linkBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(12, 12);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(321, 20);
            this.linkBox.TabIndex = 0;
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(339, 9);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 64);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(94, 13);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Вставьте ссылку";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 121);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(399, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(339, 63);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 16);
            this.labelCount.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 162);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.linkBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelCount;
    }
}

