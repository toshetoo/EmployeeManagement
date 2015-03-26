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
    public partial class frmEditEmployee : Form
    {
        List<Employee> employees = new List<Employee>();
        Employee emp = new Employee();
        
        string fileName = "Employees.txt";
        public frmEditEmployee()
        {
            InitializeComponent();
        }
        private void frmEditEmployee_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

                }
            }
            
            btnEditUser.Enabled = true;

            // shows information for the selected employee
            tbNameEditUser.Text = employees[frmManageEmployees.selectedIndex].FirstName;
            tbSecondNameEditUser.Text = employees[frmManageEmployees.selectedIndex].SecondName;
            tbFamilyNameEditUser.Text = employees[frmManageEmployees.selectedIndex].ThirdName;
            tbEGNEditUser.Text = employees[frmManageEmployees.selectedIndex].EGN;
            tbSalaryEditUser.Text = employees[frmManageEmployees.selectedIndex].Salary.ToString();
            tbDateOfArrivalEditUser.Text = employees[frmManageEmployees.selectedIndex].HireDate;
            tbDepartmentEditUser.Text = employees[frmManageEmployees.selectedIndex].Department;
            tbProfessionEditUser.Text = employees[frmManageEmployees.selectedIndex].Profession;
            
        }
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = MessageBox.Show("Are you sure you want to edit " + employees[frmManageEmployees.selectedIndex].FirstName + " " + employees[frmManageEmployees.selectedIndex].ThirdName + "'s salary?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dlg == DialogResult.Yes)
                {
                    if (int.Parse(tbSalaryEditUser.Text)<=0)
                    {
                        MessageBox.Show("Salary cant be less than zero or zero!");
                        tbSalaryEditUser.Clear();
                    }
                    else
                    {
                        employees[frmManageEmployees.selectedIndex].Salary = int.Parse(tbSalaryEditUser.Text);
                        MessageBox.Show("Employee edited!");
                        this.DialogResult = DialogResult.OK;
                    }                    
                }                
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, insert the salary in numbers!");
                tbSalaryEditUser.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number too big!");
                tbSalaryEditUser.Clear();
            }

            //writes the updated employee in a file
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

                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {           
            tbSalaryEditUser.Clear();                       
        }
    }
}
