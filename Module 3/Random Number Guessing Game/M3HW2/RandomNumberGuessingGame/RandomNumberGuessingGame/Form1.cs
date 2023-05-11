/**
* Date
* CSC 153
* Drew Tadlock
* Infinite random number game, between 1 and 100. Tell user if too high or too low
*/

using System;
using System.Windows.Forms;

namespace RandomNumberGuessingGame
{
    public partial class Form1 : Form
    {
        int answer;
        int number;

        public Form1()
        {
            InitializeComponent();
            Generate();
        }

        private void Generate()
        {
            answer = new Random().Next(1, 100);
        }

        private void numberBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(numberBox.Text);
            }
            catch {}
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (number == answer)
            {
                MessageBox.Show("You win! Generating new number...");
                Generate();
            }
            else if (number < answer)
            {
                MessageBox.Show("Too low!");
            }
            else
            {
                MessageBox.Show("Too high!");
            }
        }
    }
}
