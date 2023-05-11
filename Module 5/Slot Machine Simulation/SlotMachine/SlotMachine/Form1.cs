/**
* 4/19/2023
* CSC 153
* Drew Tadlock
* Slot Machine Simulator
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        double totalSpent = 0;
        double totalWinnings = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(amountInput.Text);
                totalSpent += amount;

                int result1 = random.Next(1, 9);
                int result2 = random.Next(1, 9);
                int result3 = random.Next(1, 9);

                pictureBox1.Image = ImageFromResult(result1);
                pictureBox2.Image = ImageFromResult(result2);
                pictureBox3.Image = ImageFromResult(result3);

                int matches = 0;

                if (result1 == result2) matches++;
                if (result2 == result3) matches++;
                if (result1 == result3) matches++;

                int multiplier = 0;

                if (matches == 1) multiplier = 2;
                else multiplier = matches;

                double winnings = amount * multiplier;
                MessageBox.Show("You won $" + winnings + ".");
                totalWinnings += winnings;
            } catch {}
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've spent $" + totalSpent + " and won $" + totalWinnings + ".");
            Close();
        }

        private Image ImageFromResult(int result)
        {
            return Image.FromFile("./Resources/" + result.ToString() + ".bmp");
        }
    }
}
