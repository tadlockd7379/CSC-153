using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            Color color1 = Color.White;
            if (red1.Checked) color1 = Color.Red;
            else if (green1.Checked) color1 = Color.Green;
            else if (yellow1.Checked) color1 = Color.Yellow;

            Color color2 = Color.White;
            if (red2.Checked) color2 = Color.Red;
            else if (green2.Checked) color2 = Color.Green;
            else if (yellow2.Checked) color2 = Color.Yellow;

            if (color1 == color2)
            {
                BackColor = color1;
            }
            else
            {
                BackColor = Mix(color1, color2);
            }
        }

        private Color Mix(Color color1, Color color2)
        {
            int r = color1.R + color2.R;
            int g = color1.G + color2.G;
            int b = color1.B + color2.B;

            return Color.FromArgb(r / 2, g / 2, b / 2);
        }
    }
}
