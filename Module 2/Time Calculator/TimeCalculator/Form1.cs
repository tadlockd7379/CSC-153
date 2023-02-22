/**
* 2/22/2023
* CSC 153
* Drew Tadlock
* Input seconds then tell the user seconds,minutes,hours,days based on how many seconds
*/

using System;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void seconds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double secondsParsed = double.Parse(seconds.Text);
                if (secondsParsed >= 86400)
                {
                    result.Text = $"{Math.Round(secondsParsed / 86400, 2)} days";
                }
                else if (secondsParsed >= 3600)
                {
                    result.Text = $"{Math.Round(secondsParsed / 3600, 2)} hours";
                }
                else if (secondsParsed >= 60)
                {
                    result.Text = $"{Math.Round(secondsParsed / 60, 2)} minutes";
                }
                else
                {
                    result.Text = $"{Math.Round(secondsParsed, 2)} seconds";
                }
            } catch {}
        }
    }
}
