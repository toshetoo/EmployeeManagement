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
    public partial class frmDeleteEmployee : Form
    {
        Employee emp = new Employee();
        List<Employee> deleteList = new List<Employee>();
       
        public frmDeleteEmployee()
        {
            InitializeComponent();            
        }
        
        private void cbUsersToBeDeleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteUser.Enabled = true;
        }

        private void frmDeleteUser_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //reads the file with the employees and fills the list and combobox
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

                    deleteList.Add(emp);
                    cbUsersToBeDeleted.Items.Add(emp.FirstName + " " + emp.ThirdName + ", "+emp.EGN);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Are you sure you want to delete "+deleteList[cbUsersToBeDeleted.SelectedIndex].FirstName + " "+deleteList[cbUsersToBeDeleted.SelectedIndex].SecondName + " from the list?","Are you sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dlg == DialogResult.Yes)
            {
                deleteList.RemoveAt(cbUsersToBeDeleted.SelectedIndex);
                MessageBox.Show("Employee deleted!");
            }            
            
            //updates the file with the new value
            using (StreamWriter sw = new StreamWriter("Employees.txt"))
            {
                foreach (Employee emp in deleteList)
                {
                    sw.WriteLine(
                    emp.FirstName + "," + emp.SecondName + "," + emp.ThirdName + "," + emp.EGN + ","
                        + emp.Profession + "," + emp.Department + "," + emp.Salary + "," + emp.HireDate
                    );
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void cbUsersToBeDeleted_TextChanged(object sender, EventArgs e)
        {
            if (cbUsersToBeDeleted.Text.Length==0)
            {
                MessageBox.Show("Error!");
                cbUsersToBeDeleted.SelectedIndex = 0; //puts a default selection if the user deletes the text
            }
        }
    }
}
