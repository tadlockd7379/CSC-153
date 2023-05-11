/**
* 3/22/2023
* CSC 153
* Drew Tadlock
* Calculate hospital charges based on user input
*/

using System;
using System.Windows.Forms;

namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        double costPerDay = 350;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total = CalcStayCharges() + CalcMiscCharges();
            MessageBox.Show("Cost of all charges is $" + total + ".");
        }

        private double CalcStayCharges()
        {
            try
            {
                double days = Double.Parse(daysInput.Text);
                return days * costPerDay;
            }
            catch
            {
                return 0;
            }
        }

        private double CalcMiscCharges()
        {
            try
            {
                double medicalCharges = Double.Parse(medicationChargesInput.Text);
                double surgicalCharges = Double.Parse(surgicalChargesInput.Text);
                double labCharges = Double.Parse(labChargesInput.Text);
                double rehabCharges = Double.Parse(rehabChargesInput.Text);
                return medicalCharges + surgicalCharges + labCharges + rehabCharges;
            }
            catch
            {
                return 0;
            }
        }
    }
}
