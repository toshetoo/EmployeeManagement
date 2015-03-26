using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmManageEmployees : Form
    {
        List<Employee> employees = new List<Employee>();
        Employee emp = new Employee();
        
        public static int selectedIndex;
        
        public frmManageEmployees()
        {
            InitializeComponent();
        }

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAddUser = new frmAddEmployee();
            if (frmAddUser.ShowDialog()==DialogResult.OK)
            {
                lbEmployees.Items.Clear();
                employees.Clear();
                using (StreamReader sr = new StreamReader("Employees.txt"))
            {
                
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');
                    emp.FirstName = splitted[0];
                    emp.SecondName = splitted[1];
                    emp.ThirdName = splitted[2];
                    emp.EGN = splitted[3];
                    emp.Profession = splitted[4];
                    emp.Department = splitted[5];
                    emp.Salary = int.Parse(splitted[6]);
                    emp.HireDate = splitted[7];

                    employees.Add(emp);
                    lbEmployees.Items.Add(emp.FirstName + " " + emp.ThirdName+", "+emp.EGN);
                }
            }
                lbEmployees.SelectedIndex = 0;
            }
        }

        private void btnEditEmployer_Click(object sender, EventArgs e)
        {
            frmEditEmployee frmEditUser = new frmEditEmployee();
            if (frmEditUser.ShowDialog()==DialogResult.OK)
            {
                lbEmployees.Items.Clear();
                employees.Clear();
                    using (StreamReader sr = new StreamReader("Employees.txt"))
            {
                
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');
                    emp.FirstName = splitted[0];
                    emp.SecondName = splitted[1];
                    emp.ThirdName = splitted[2];
                    emp.EGN = splitted[3];
                    emp.Profession = splitted[4];
                    emp.Department = splitted[5];
                    emp.Salary = int.Parse(splitted[6]);
                    emp.HireDate = splitted[7];

                    employees.Add(emp);
                    lbEmployees.Items.Add(emp.FirstName + " " + emp.ThirdName+", "+emp.EGN);
                }
            }
                lbEmployees.SelectedIndex = 0;
            }
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // disables resize
                using (StreamReader sr = new StreamReader("Employees.txt"))
            {
                
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');
                    emp.FirstName = splitted[0];
                    emp.SecondName = splitted[1];
                    emp.ThirdName = splitted[2];
                    emp.EGN = splitted[3];
                    emp.Profession = splitted[4];
                    emp.Department = splitted[5];
                    emp.Salary = int.Parse(splitted[6]);
                    emp.HireDate = splitted[7];

                    employees.Add(emp);
                    lbEmployees.Items.Add(emp.FirstName + " " + emp.ThirdName+", "+emp.EGN);
                }
            }
            

        }

        private void lbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shows information for every employee
            selectedIndex = lbEmployees.SelectedIndex;
            tbFirstName.Text = employees[lbEmployees.SelectedIndex].FirstName;
            tbSecondName.Text = employees[lbEmployees.SelectedIndex].SecondName;
            tbThirdName.Text = employees[lbEmployees.SelectedIndex].ThirdName;
            tbSalary.Text = employees[lbEmployees.SelectedIndex].Salary.ToString();
            tbProfession.Text = employees[lbEmployees.SelectedIndex].Profession;
            tbEGN.Text = employees[lbEmployees.SelectedIndex].EGN.ToString();
            tbDepartment.Text = employees[lbEmployees.SelectedIndex].Department;
            tbDateOfArrival.Text = employees[lbEmployees.SelectedIndex].HireDate;
            
        }

        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            frmDeleteEmployee frmDeleteUser = new frmDeleteEmployee();
            if (frmDeleteUser.ShowDialog() == DialogResult.OK)
            {
                employees.Clear();
                lbEmployees.Items.Clear();
                    using (StreamReader sr = new StreamReader("Employees.txt"))
            {
                
                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');
                    emp.FirstName = splitted[0];
                    emp.SecondName = splitted[1];
                    emp.ThirdName = splitted[2];
                    emp.EGN = splitted[3];
                    emp.Profession = splitted[4];
                    emp.Department = splitted[5];
                    emp.Salary = int.Parse(splitted[6]);
                    emp.HireDate = splitted[7];

                    employees.Add(emp);
                    lbEmployees.Items.Add(emp.FirstName + " " + emp.ThirdName+", "+emp.EGN);
                }
            }
                lbEmployees.SelectedIndex = 0;
            }

        }                   
    }
}
