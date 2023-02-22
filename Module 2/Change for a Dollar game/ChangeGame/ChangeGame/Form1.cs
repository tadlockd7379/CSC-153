/**
* 2/13/23
* CSC 153
* Drew Tadlock
* Allow user to input amount of coins, if exactly $1 they win, otherwise tell them over or under
*/

using System;
using System.Windows.Forms;

namespace ChangeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double p = Double.Parse(pennies.Text);
                double n = Double.Parse(nickles.Text);
                double d = Double.Parse(dimes.Text);
                double q = Double.Parse(quarters.Text);

                double money = p + n * 5 + d * 10 + q * 25;

                if (money < 100)
                {
                    MessageBox.Show("Under $1");
                }
                else if (money > 100)
                {
                    MessageBox.Show("Over $1");
                }
                else
                {
                    MessageBox.Show("You win!");
                }
            }
            catch {}
        }
    }
}
