/**
* 3/13/2023
* CSC 153
* Drew Tadlock
* let user select how many random numbers to write and to where
*/

using System;
using System.IO;
using System.Windows.Forms;

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int amountOfNumbers = 1;
            try
            {
                amountOfNumbers = int.Parse(randomNumbersInput.Text);
            } 
            catch
            {
                MessageBox.Show("Invalid Number.");
            }

            if (amountOfNumbers < 1 || amountOfNumbers > 100)
            {
                MessageBox.Show("Must be between 1 and 100.");
            }
            else
            {
                String fileContent = "";
                Random random = new Random();
                for (int i = 0; i < amountOfNumbers; i++)
                {
                    fileContent += random.Next(1, amountOfNumbers) + "\n";
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFile.FileName, fileContent);
                }
            }
        }
    }
}
