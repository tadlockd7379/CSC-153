/**
* 3/5/2023
* CSC 153
* Drew Tadlock
* Calculate pennies per day based on user's input, payment doubles for each day
*/

using System;
using System.Windows.Forms;

namespace PenniesForPay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void daysBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double days = double.Parse(daysBox.Text);
                payLabel.Text = "Pay: ¢" + (Math.Pow(2, days - 1));
            }
            catch {}
        }
    }
}
