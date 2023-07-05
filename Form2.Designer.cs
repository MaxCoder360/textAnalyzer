
namespace TextAnalyzer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.mainBox = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.saveInFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainBox
            // 
            this.mainBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainBox.Location = new System.Drawing.Point(12, 12);
            this.mainBox.Multiline = true;
            this.mainBox.Name = "mainBox";
            this.mainBox.ReadOnly = true;
            this.mainBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.mainBox.Size = new System.Drawing.Size(784, 426);
            this.mainBox.TabIndex = 0;
            this.mainBox.TabStop = false;
            this.mainBox.WordWrap = false;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(543, 444);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(253, 84);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // saveInFile
            // 
            this.saveInFile.Location = new System.Drawing.Point(12, 444);
            this.saveInFile.Name = "saveInFile";
            this.saveInFile.Size = new System.Drawing.Size(253, 84);
            this.saveInFile.TabIndex = 2;
            this.saveInFile.Text = "Сохранить...";
            this.saveInFile.UseVisualStyleBackColor = true;
            this.saveInFile.Click += new System.EventHandler(this.saveInFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 536);
            this.Controls.Add(this.saveInFile);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.mainBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "СТАТИСТИКА ИЗ ТЕКСТА, КОТОРУЮ Я ПОЛУЧИЛ";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }

        #endregion

        private System.Windows.Forms.TextBox mainBox;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button saveInFile;
    }
}