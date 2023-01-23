/**
* 1/18/2023
* CSC 153
* Drew Tadlock
* Calculate the cost of painting depending on user input
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double sqrFtValue;
        double ppgValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void sqrFt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sqrFtValue = double.Parse(sqrFt.Text);
                updateResults();
            }
            catch {}
        }

        private void updateResults()
        {
            try
            {
                double gallons = sqrFtValue / 115;
                double hours = gallons * 8;
                double labor = hours * 20;
                double paintCost = ppgValue * gallons;
                double laborCost = hours * 20;
                gallonsOfPaint.Text = $"Gallons of paint: {Math.Round(gallons, 2)}";
                hoursOfLabor.Text = $"Hours of labor: {Math.Round(hours, 2)}";
                costOfPaint.Text = $"Cost of paint: ${Math.Round(paintCost, 2)}";
                costOfLabor.Text = $"Cost of labor: ${Math.Round(laborCost, 2)}";
                totalCost.Text = $"Total Cost: ${Math.Round(paintCost + laborCost, 2)}";
            } 
            catch {}
        }

        private void ppg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ppgValue = double.Parse(ppg.Text);
                updateResults();
            } 
            catch {}
        }
    }
}
