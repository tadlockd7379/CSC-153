/**
* 1/18/2023
* CSC 153
* Drew Tadlock
* Show different format of names based on user input
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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {
            calculateNames();
        }

        private void middleName_TextChanged(object sender, EventArgs e)
        {
            calculateNames();
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {
            calculateNames();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            calculateNames();
        }

        private void calculateNames()
        {
            if (firstName.TextLength > 0 && middleName.TextLength > 0 && lastName.TextLength > 0 && title.TextLength > 0)
            {
                button1.Text = $"{title.Text}. {firstName.Text} {middleName.Text} {lastName.Text}";
                button2.Text = $"{firstName.Text} {middleName.Text} {lastName.Text}";
                button3.Text = $"{firstName.Text} {lastName.Text}";
                button4.Text = $"{lastName.Text}, {firstName.Text} {middleName.Text}, {title.Text}.";
                button5.Text = $"{lastName.Text}, {firstName.Text} {middleName.Text}";
                button6.Text = $"{lastName.Text}, {firstName.Text}";
            }
        }
    }
}
