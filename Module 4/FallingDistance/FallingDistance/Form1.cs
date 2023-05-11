/**
* 3/19/2023
* CSC 153
* Drew Tadlock
* Allow user to input how long an object has been falling then output how many meters it's fallen
*/

using System;
using System.Windows.Forms;

namespace FallingDistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double time = double.Parse(input.Text);
                results.Text = "It has fallen " + FallingDistance(time) + " meters.";
            }
            catch {}
        }

        private double FallingDistance(double seconds)
        {
            double g = 9.8;
            return 0.5 * g * Math.Pow(seconds, 2);
        }
    }
}
