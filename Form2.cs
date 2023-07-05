using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WriteOnTextBox();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void WriteOnTextBox()
        {
            mainBox.Text = "Количество слов: " + Form1.countWords;
            mainBox.AppendText($"{Environment.NewLine}Количество уникальных слов: " + Form1.countUniqueWords);
            mainBox.AppendText($"{Environment.NewLine}10 самых длинных слов: {String.Join(", ", Form1.longestWords)}");
            mainBox.AppendText($"{Environment.NewLine}10 самых часто встречаемых слов: {String.Join(", ", Form1.topWords)}");
            mainBox.AppendText($"{Environment.NewLine}Процентное соотношение букв в тексте: {Environment.NewLine}");
            mainBox.AppendText(String.Join(", ", Form1.getLettersToString(Form1.lettersEnglish)) + Environment.NewLine);
            mainBox.AppendText(String.Join(", ", Form1.getLettersToString(Form1.lettersRussian)));
        }

        private void saveInFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Посхалка, лол";
                saveFileDialog.InitialDirectory = "%USERPROFILE%\\Documents";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.OpenFile());
                    sw.Write(mainBox.Text.Replace("{Environment.NewLine}", "\n"));
                    sw.Close();
                    MessageBox.Show("Файл успешно сохранён");
                }
            }
        }
    }
}
