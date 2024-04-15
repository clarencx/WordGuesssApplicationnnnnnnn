using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string CorrectWord = "cheese";
        private StringBuilder guess;
        public Form1()
        {
            InitializeComponent();
            guess = new StringBuilder(CorrectWord.Length);
            guess.Append(CorrectWord[0]);
            for (int i = 1; i < CorrectWord.Length - 1; i++)
            {
                if (char.IsLetter(CorrectWord[i]) && i > 1 && i < CorrectWord.Length - 1)
                    guess.Append('?');
                else
                    guess.Append(CorrectWord[i]);
            }
            guess.Append(CorrectWord[CorrectWord.Length - 1]);
            label1.Text = guess.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string CorrectAnswer = textBox1.Text;

            if (CorrectAnswer == CorrectWord)
            {
                label1.Text = CorrectWord;
                MessageBox.Show("Correct Guess!");
            }
            else
            {
                listBox1.Items.Add(CorrectAnswer);
                MessageBox.Show("Wrong Guess!, Try Again");

            }

            textBox1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }
    }
}