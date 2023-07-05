
namespace TextAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainBox = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.Button();
            this.getStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainBox
            // 
            this.MainBox.Location = new System.Drawing.Point(12, 12);
            this.MainBox.Multiline = true;
            this.MainBox.Name = "MainBox";
            this.MainBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.MainBox.Size = new System.Drawing.Size(1010, 762);
            this.MainBox.TabIndex = 0;
            this.MainBox.WordWrap = false;
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(1028, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(236, 82);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Открытие файла...";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // getStatistics
            // 
            this.getStatistics.Location = new System.Drawing.Point(1028, 692);
            this.getStatistics.Name = "getStatistics";
            this.getStatistics.Size = new System.Drawing.Size(236, 82);
            this.getStatistics.TabIndex = 2;
            this.getStatistics.Text = "Получить\r\nстатистику";
            this.getStatistics.UseVisualStyleBackColor = true;
            this.getStatistics.Click += new System.EventHandler(this.getStatistics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1276, 786);
            this.Controls.Add(this.getStatistics);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.MainBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "АНАЛИЗАТОР 3000";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }

        #endregion

        private System.Windows.Forms.TextBox MainBox;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button getStatistics;
    }
}

