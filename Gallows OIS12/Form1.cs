using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gallows_OIS12
{
    public partial class frmHangman : Form
    {
        PictureBox[] pbHangman = new PictureBox[6];
        Word word;
        string secretWord;
        int Lives = 0;
        bool c1Guessed, c2Guessed, c3Guessed, c4Guessed, c5Guessed, c6Guessed, Won;
        char c1, c2, c3, c4, c5, c6;
        int numberOfGuesses = 1;
        List<Label> letters = new List<Label>();

        public frmHangman()
        {
            InitializeComponent();

            pbHangman[0] = pb1;
            pbHangman[1] = pb2;
            pbHangman[2] = pb3;
            pbHangman[3] = pb4;
            pbHangman[4] = pb5;
            pbHangman[5] = pb6;
            letters = new List<Label>()
            {
                lblC1,
                lblC2,
                lblC3,
                lblC4,
                lblC5,
                lblC6
            };
        }

        public string GetterWords()
        {
            string unsortedWords = "timber,legend,punish,exceed";
            List<string> sortedWords = unsortedWords.Split(',').ToList();
            int index = new Random().Next(sortedWords.Count);
            string secretWord = sortedWords[index];

            return secretWord;
        }
        
        public void ResetImages()
        {
            for (int j = 1; j < pbHangman.Length; j++)
            {
                pbHangman[j].Visible = false;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ResetGame();
            word = new Word(GetterWords());
            MessageBox.Show(word.ToString());
            MessageBox.Show("New word generated");
            ResetImages();

        }

        private void ResetGame()
        {
            Won = false; c1Guessed = false; c2Guessed = false; c3Guessed = false; c4Guessed = false; c5Guessed = false; c6Guessed = false;
        }
        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (tbGuessChar.Text.Length > 1)
            {
                MessageBox.Show("Too much chars, you can only put in 1 char");
            }
            else
            {
                char chosenChar = Convert.ToChar(tbGuessChar.Text);
                for (int i = 0; i < numberOfGuesses; i++)
                {                  
                    int index = word.getCharIndex(chosenChar);
                    if (index != null)
                    {
                        switch (index)
                        {
                            case 0:
                                lblC1.Text = chosenChar.ToString();
                                c1Guessed = true;
                                break;
                            case 1:
                                lblC2.Text = chosenChar.ToString();
                                c2Guessed = true;
                                break;
                            case 2:
                                lblC3.Text = chosenChar.ToString();
                                c3Guessed = true;
                                break;
                            case 3:
                                lblC4.Text = chosenChar.ToString();
                                c4Guessed = true;
                                break;
                            case 4:
                                lblC5.Text = chosenChar.ToString();
                                c5Guessed = true;
                                break;
                            case 5:
                                lblC6.Text = chosenChar.ToString();
                                c6Guessed = true;
                                break;
                            default:
                                pbHangman[Lives + 1].Visible = true;                               
                                MessageBox.Show("Wrong char");
                                break;
                        }
                    }
                }
            }
        }
    }
}

