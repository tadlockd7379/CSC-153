/**
* 1/23/2023
* CSC 153
* Drew Tadlock
* Display sales tax based on property value
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

namespace Tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void propertyValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                salesTax.Text = $"${double.Parse(propertyValue.Text) / 100 * 0.64}";
            } 
            catch
            {
            }
        }

        private void propertyValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
