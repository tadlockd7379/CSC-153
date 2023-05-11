/**
* 5/10/2023
* CSC 153
* Drew Tadlock
* Create overloaded methods for calculating the area of various shapes
*/

using System;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            double circleRadius = 5;
            circleArea.Text = "Area: " + Math.Round(AreaLibrary.AreaLibrary.Area(circleRadius), 2);

            double rectangleLength = 5;
            double rectangleWidth = 10;
            rectangleArea.Text = "Area: " + Math.Round(AreaLibrary.AreaLibrary.Area(rectangleWidth, rectangleLength), 2);

            double cylinderRadius = 5;
            double cylinderHeight = 10;
            cylinderArea.Text = "Area: " + Math.Round(AreaLibrary.AreaLibrary.Area(Math.PI, cylinderRadius, cylinderHeight), 2);
        }
    }
}
