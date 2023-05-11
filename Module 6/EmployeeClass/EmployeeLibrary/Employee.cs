namespace EmployeeLibrary
{
    public class Employee
    {
        public string name;
        public int idnumber;
        public string department;
        public string position;

        public Employee(string name, int idnumber, string department, string position)
        {
            this.name = name;
            this.idnumber = idnumber;
            this.department = department;
            this.position = position;
        }

        public Employee(string name, int idnumber)
        {
            this.name = name;
            this.idnumber = idnumber;
            this.department = "";
            this.position = "";
        }

        public Employee()
        {
            this.name = "";
            this.idnumber = 0;
            this.department = "";
            this.position = "";
        }
    }
}
