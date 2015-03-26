using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmMain
{
    class Employee
    {
        //private int id;
        private string firstName;
        private string secondName;
        private string thirdName;
        private string egn;
        private string profession;
        private string department;
        private int salary;
        private string hireDate;

        public Employee()
        {

        }
        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string SecondName
        {
            get { return secondName; }
            set { secondName = value; }
        }
        public string ThirdName
        {
            get { return thirdName; }
            set { thirdName = value; }
        }
        public string EGN
        {
            get { return egn; }
            set { egn = value; }
        }

        public string Profession
        {
            get { return profession; }
            set { profession = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
    }

}
