/**
* 3/13/2023
* CSC 153
* Drew Tadlock
* read file from previous assignment and show the numbers, amount of numbers, and total of the numbers added
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RandomNumberFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                IEnumerable<String> enumLines = File.ReadLines(fileDialog.FileName, Encoding.UTF8);
                int lines = 0;
                int total = 0;
                foreach (string line in enumLines)
                {
                    lines++;
                    numbersListBox.Items.Add(line);
                    total += int.Parse(line);
                }
                totalLabel.Text = "Total of numbers: " + total;
                totalNumbersLabel.Text = lines + " Numbers";
            }
            else
            {
                Form1_Load(sender, e);
            }
        }
    }
}
