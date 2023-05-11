/**
* 4/3/2023
* CSC 153
* Drew Tadlock
* Allow user to enter number, tell them if it's prime or not
*/

using System;
using System.Windows.Forms;

namespace PrimeNumbers
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
                int number = int.Parse(numberInput.Text);
                bool prime = IsPrime(number);
                MessageBox.Show(number + " is " + (prime ? "prime" : "not prime") + ".");
            }
            catch {}
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
                if (i == number)
                {
                    return true;
                }
            }

            return true;
        }
    }
}
