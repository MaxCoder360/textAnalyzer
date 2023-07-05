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
using System.Threading;

namespace TextAnalyzer
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, int> words;
        public static int countWords, countUniqueWords;
        public static List<string> longestWords, topWords;
        public static Dictionary<char, double> lettersEnglish, lettersRussian;

        private char[] delimiters = { ' ', '.', ',', ':', ';', '\t', '\n', '\r', '?', '!' };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "%USERPROFILE%\\Documents";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainBox.Text = new StreamReader(openFileDialog.OpenFile()).ReadToEnd();
                }
            }
        }

        private void getStatistics_Click(object sender, EventArgs e)
        {
            words = new Dictionary<string, int>();
            countWords = 0; countUniqueWords = 0;
            longestWords = new List<string>(); topWords = new List<string>();
            lettersEnglish = new Dictionary<char, double>(); lettersRussian = new Dictionary<char, double>();

            foreach (string i in MainBox.Text.Split(delimiters))
            {
                // check for empty string
                if (i == "")
                    continue;
                countWords++;
                if (words.ContainsKey(i))
                {
                    words[i] += 1;
                }
                else
                {
                    words[i] = 1;
                    countUniqueWords++;
                }
            }
            GetLongestWords();
            GetTopWords();
            getLetterStatistics();
            
            using (Form2 form2 = new Form2())
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    return;
                }
            }
        }

        private void GetLongestWords()
        {
            string[] longestWordsArr = words.Keys.OrderBy(word => word.Length).ToArray<string>();
            for (int i = longestWordsArr.Length - 1; i >= Math.Max(0, longestWordsArr.Length - 10); i--)
            {
                longestWords.Add(longestWordsArr[i]);
            }
        }

        private void GetTopWords()
        {
            var topWordsArr = words
                .OrderBy(word => word.Value)
                .ToDictionary(word => word.Key)
                .Keys.ToArray<string>();
            for (int i = topWordsArr.Length - 1; i >= Math.Max(0, topWordsArr.Length - 10); i--)
            {
                topWords.Add(topWordsArr[i]);
            }
        }

        private bool isValidLetterEn(char c)
        {
            return (c >= 'A' && c <= 'Z'
                || c >= 'a' && c <= 'z');
        }
        private bool isValidLetterRus(char c)
        {
            return (c >= 'а' && c <= 'я'
                || c >= 'А' && c <= 'Я');
        }

        private void getLetterStatistics()
        {
            var letterCount = 0;
            for (char c = 'a'; c <= 'z'; c++)
            {
                lettersEnglish[c] = 0;
            }
            for (char c = 'а'; c <= 'я'; c++)
            {
                lettersRussian[c] = 0;
            }

            foreach (string str in words.Keys)
            {
                foreach (char c in str.ToLower())
                {
                    // check if this is actually a letter - not a number or another shit
                    if (isValidLetterRus(c))
                    {
                        letterCount++;
                        lettersRussian[c] += 1.0;
                    } else if (isValidLetterEn(c))
                    {
                        letterCount++;
                        lettersEnglish[c] += 1.0;
                    }
                }
            }

            if (letterCount == 0)
                return;

            List<char> FAKINGvAR = lettersEnglish.Keys.ToList<char>(); 
            foreach (char c in FAKINGvAR)
            {
                lettersEnglish[c] = Math.Round(lettersEnglish[c] / letterCount, 4);
            }
            lettersEnglish = lettersEnglish
                .OrderBy(word => 1 / word.Value)
                .ToDictionary(word => word.Key, word => word.Value);

            FAKINGvAR = lettersRussian.Keys.ToList<char>();
            foreach (char c in FAKINGvAR)
            {
                lettersRussian[c] = Math.Round(lettersRussian[c] / letterCount, 4);
            }
            lettersRussian = lettersRussian
                .OrderBy(word => 1 / word.Value)
                .ToDictionary(word => word.Key, word => word.Value);
        }

        public static List<string> getLettersToString(Dictionary<char, double> letters)
        {
            List<string> current = new List<string>();

            foreach (char c in letters.Keys)
            {
                current.Add($"{c} - {letters[c] * 100.0}%");
            }

            return current;
        }
    }
}
