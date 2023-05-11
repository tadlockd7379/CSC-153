using CarLibrary;
using System;
using System.Collections.Generic;
/**
* 4/26/2023
* CSC 153
* Drew Tadlock
* Allow user to input car year, make, and model. Then allow them to accelerate and brake and then show the speed of the car.
*/

using System.Windows.Forms;

namespace CarClass
{
    public partial class Form1 : Form
    {
        Car car;

        public Form1()
        {
            InitializeComponent();
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            this.car.Brake();
            UpdateSpeed();
        }

        private void accelerateButton_Click(object sender, EventArgs e)
        {
            this.car.Accelerate();
            UpdateSpeed();
        }

        private void UpdateSpeed()
        {
            this.mphLabel.Text = this.car.speed + " mph";
        }

        private void createCarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(yearInput.Text, out int year);
                string make = makeInput.Text;
                string model = modelInput.Text;
                brakeButton.Visible = true;
                accelerateButton.Visible = true;
                createCarButton.Visible = false;
                yearInput.Enabled = false;
                makeInput.Enabled = false;
                modelInput.Enabled = false;
                this.car = new Car(year, make, model);
            }
            catch {}
        }
    }
}
