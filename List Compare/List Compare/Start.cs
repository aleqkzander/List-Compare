using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace List_Compare
{
    public partial class Start : Form
    {
        private List<string> listOne;
        private List<string> listTwo;

        public Start()
        {
            InitializeComponent();
        }


        private void Start_Load(object sender, EventArgs e)
        {
            listOne = new List<string>();
            listTwo = new List<string>();
        }


        private void OpenFirstList_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // read the file line by line
                string[] _filetext = File.ReadAllLines(openFileDialog.FileName);

                // return when empty
                if (_filetext.ToString() == string.Empty) return;

                foreach (string text in _filetext)
                {
                    // add to first list
                    listOne.Add(text);
                    // add to box
                    FirstListBox.Text += text + "\n";
                }

                // set score from import
                ScoreListOne.Text = "SCORE: " + (listOne.Count).ToString("00");
            }
        }

        #region clear first list
        private void ClearFirstList_Click(object sender, EventArgs e)
        {
            FirstListBox.Clear();
        }
        #endregion


        private void OpenSecondList_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // read the file line by line
                string[] _filetext = File.ReadAllLines(openFileDialog.FileName);

                // return when empty
                if (_filetext.ToString() == string.Empty) return;

                foreach (string text in _filetext)
                {
                    // add to first list
                    listTwo.Add(text);
                    // add to box
                    SecondListBox.Text += text + "\n";
                }

                // set score from import
                ScoreListTwo.Text = "SCORE: " + (listTwo.Count).ToString("00");
            }
        }

        #region clear second list
        private void ClearSecondList_Click(object sender, EventArgs e)
        {
            SecondListBox.Clear();
        }
        #endregion


        private void CompareList_Click(object sender, EventArgs e)
        {
            ResultLabel.Text = "RESULT: " + Compare().ToString("00");
        }


        private int Compare()
        {
            int score = 0;

            // loop throug list one
            foreach (string element1 in listOne)
            {
                // foreach entry in list1 loop throug list2 and compare
                foreach (string element2 in listOne)
                {
                    if (element1 == element2)
                    {
                        // add score
                        score++;
                    }
                    else
                    {
                        // continue
                        continue;
                    }
                }
            }

            // return score
            return score;
        }
    }
}
