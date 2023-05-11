using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeLibrary;

namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Employee[] employees = new Employee[] {
                new Employee("Susan Meyers", 47899, "Accounting", "Vice President"),
                new Employee("Mark Jones", 39119, "IT", "Programmer"),
                new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer")
            };
            
            foreach (Employee employee in employees)
            {
                outputLabel.Text += "Name: " + employee.name + ", ID Number: " + employee.idnumber + ", Department: " + employee.department + ", Position: " + employee.position + "\n";
            }
        }
    }
}
