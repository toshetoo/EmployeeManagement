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
    public partial class frmAddEmployee : Form
    {
        bool isValidated = true;
        Employee employee = new Employee();
        List<string> existingEGN = new List<string>();
        
        bool isFebruary = false;

        public frmAddEmployee()
        {
            InitializeComponent();
        }
        private void ValidateNameTextBox(TextBox tb,int minLetters, int maxLetters)
        {
            //Method validates textboxes with color and checks for the maximum length of the names
            if (tb.Text.Length < minLetters)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                isValidated = true;
                tb.BackColor = Color.Green;
            }
            if (tb.Text.Length > maxLetters)
            {
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
                MessageBox.Show("The maximum lenght of the name is 10 letters!");
            }
        }
        private static void ValidateNames(KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsLetter(pressedKey) || e.KeyChar == (char)8)
            {
                // Allow input.
                e.Handled = false;
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
            }
        }
        private void ShowProblemDialog(Exception ex, string message)
        {
            DialogResult dlg = MessageBox.Show(message, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg == DialogResult.Yes)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void CheckForErrorInput(string checker)
        {
            MessageBox.Show(checker);
            tbEGNAddUser.Text = tbEGNAddUser.Text.Remove(tbEGNAddUser.Text.Length - 2);
            tbEGNAddUser.Select(tbEGNAddUser.Text.Length, 0);
        }
        private static void UseOnlyDigits(KeyPressEventArgs e)
        {
            Char pressedKey = e.KeyChar;
            if (Char.IsDigit(pressedKey) || e.KeyChar == (char)8)
            {
                // Allow input.
                e.Handled = false;
            }
            else
            {
                // Stop the character from being entered into the control since not a letter, nor punctuation, nor a space.
                e.Handled = true;
            }
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            isValidated = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
        }
        private void btnSaveNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                //fills  a list with the existing EGN's for a later "contains" check
                using (StreamReader sr = new StreamReader("Employees.txt"))
            {

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');                    
                    emp.EGN = splitted[3];                    

                    existingEGN.Add(emp.EGN);

                }
            }

                if (tbNameAddUser.Text != "" && tbSecondNameAddUser.Text != "" && tbFamilyNameAddUser.Text != ""
                        && tbEGNAddUser.Text != "" && tbSalaryAddUser.Text != "" &&
                        cbDepartment.Text != "" && cbProfessionAddUser.Text != "")
                {
                    using (StreamWriter sw = new StreamWriter("Employees.txt", true))
                    {
                        #region InputData

                        employee.HireDate = (dateTimePicker1.Value.Day + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Year).ToString();

                        #region EGN Validation
                        if (tbEGNAddUser.Text.Length<10)
                        {
                            MessageBox.Show("EGN too short! The EGN must be 10 digits!");
                            tbEGNAddUser.Clear();
                        }
                        else
                        {
                            employee.EGN = tbEGNAddUser.Text;
                        }                        
                        #endregion                        

                        #region NamesValidation
                        if (tbNameAddUser.Text.Length < 3)
                        {
                            isValidated = false;
                            MessageBox.Show("First name too short!");
                            tbNameAddUser.Clear();
                        }
                        else
                        {
                            isValidated = true;
                            employee.FirstName = tbNameAddUser.Text;
                        }

                        if (tbSecondNameAddUser.Text.Length < 5)
                        {
                            isValidated = false;
                            MessageBox.Show("Second name too short!");
                            tbSecondNameAddUser.Clear();
                        }
                        else
                        {
                            isValidated = true;
                            employee.SecondName = tbSecondNameAddUser.Text;
                        }

                        if (tbFamilyNameAddUser.Text.Length < 5)
                        {
                            isValidated = false;
                            MessageBox.Show("Family name too short!");
                            tbFamilyNameAddUser.Clear();
                        }
                        else
                        {
                            isValidated = true;
                            employee.ThirdName = tbFamilyNameAddUser.Text;
                        }

                        #endregion

                        #region SalaryValidation
                        try
                        {                            
                            if (int.Parse(tbSalaryAddUser.Text) <= 0)
                            {
                                MessageBox.Show("Salary cant be zero or lower than zero!");
                                tbSalaryAddUser.Clear();
                            }
                            else
                            {
                                employee.Salary = int.Parse(tbSalaryAddUser.Text);
                            }
                        }
                        catch (FormatException forex)
                        {
                            ShowProblemDialog(forex, "The Salary can contain only numbers! Do you want to see information about the error?");                            
                            tbSalaryAddUser.Clear();
                        }
                        catch (OverflowException ovex)
                        {
                            ShowProblemDialog(ovex, "The Salary is too big! Do you want to see information about the error?");
                            tbSalaryAddUser.Clear();
                        }
                        #endregion

                        #region ProfessionValidation
                        try
                        {
                            employee.Profession = cbProfessionAddUser.SelectedItem.ToString();
                        }
                        catch (NullReferenceException nrefex)
                        {
                            ShowProblemDialog(nrefex, "You have to select a profession from the combobox! Do you want to see information about the error?");
                            cbProfessionAddUser.SelectedIndex = 0;                            
                        }
                        #endregion

                        #region DepartmentValidation
                        try
                        {
                            employee.Department = cbDepartment.SelectedItem.ToString();
                        }
                        catch (NullReferenceException nrefex)
                        {
                            ShowProblemDialog(nrefex, "You have to select a department from the combobox! Do you want to see information about the error?");
                            cbDepartment.SelectedIndex = 0;                            
                        }
                        #endregion

                        if (existingEGN.Contains(employee.EGN))
                        {
                            MessageBox.Show("Employee with the same EGN already exists!");                            
                        }
                        else
                        {
                            if(tbEGNAddUser.Text!="" && tbFamilyNameAddUser.Text!=""
                                && tbNameAddUser.Text!="" && tbSalaryAddUser.Text!="" && tbSecondNameAddUser.Text!=""
                                && cbDepartment.Text!="" && cbProfessionAddUser.Text!="")
                            {
                                if (isValidated == true)
                                {
                                    sw.WriteLine(
                                      employee.FirstName + "," + employee.SecondName + "," + employee.ThirdName + "," + employee.EGN + ","
                                          + employee.Profession + "," + employee.Department + "," + employee.Salary + "," + employee.HireDate
                                      );
                                    this.DialogResult = DialogResult.OK;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Could not add! Not all information filled!");
                            }
                        }
                        #endregion
                    }
                        
                }
                else
                {
                    MessageBox.Show("Please, fill all information!");
                }
            }

            catch (IOException ioex)
            {
                ShowProblemDialog(ioex, "Problem with the file! Do you want to see information about the error?");
            }
            catch (ArgumentException argex)
            {
                ShowProblemDialog(argex, "Problem with the file! Do you want to see information about the error?");
            }

        }       
        private void btnClear_Click(object sender, EventArgs e)
        {
            dateTimePicker1.ResetText();
            tbEGNAddUser.Clear();
            tbFamilyNameAddUser.Clear();
            tbNameAddUser.Clear();
            tbSalaryAddUser.Clear();
            tbSecondNameAddUser.Clear();
            cbDepartment.Text = "";
            cbProfessionAddUser.Text = "";
            isValidated = true;
        }
        private void tbNameAddUser_TextChanged(object sender, EventArgs e)
        {
            ValidateNameTextBox(tbNameAddUser,3,10);
        }
        private void tbNameAddUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNames(e);
        }
        private void tbSecondNameAddUser_TextChanged(object sender, EventArgs e)
        {
            ValidateNameTextBox(tbSecondNameAddUser,5,10);
        }
        private void tbSecondNameAddUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNames(e);
        }
        private void tbFamilyNameAddUser_TextChanged(object sender, EventArgs e)
        {
            ValidateNameTextBox(tbFamilyNameAddUser,5,10);
        }
        private void tbFamilyNameAddUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateNames(e);
        } 
        private void tbEGNAddUser_TextChanged(object sender, EventArgs e)
        {            
            if (tbEGNAddUser.Text.Length <= 9)
            {
                tbEGNAddUser.BackColor = Color.Red;
                if (tbEGNAddUser.Text.Length==4)
                {
                    string checker = tbEGNAddUser.Text.Substring(2, 2);
                    if (checker=="00")
                    {
                        CheckForErrorInput("The digits for the month cant be zero!");
                        
                    }
                    else if (int.Parse(checker)>12)
                    {
                        CheckForErrorInput("The digits for the month cant be more than 12!");
                        
                    }
                    if (checker=="02")
                    {
                        isFebruary = true;
                    }
                    else
                    {
                        isFebruary = false;
                    }
                }
                if (tbEGNAddUser.Text.Length == 6)
                {
                    string checker = tbEGNAddUser.Text.Substring(4, 2);
                    if (checker == "00")
                    {
                        CheckForErrorInput("The digits for the day cant be zero!");                        
                    }
                    else if (isFebruary && int.Parse(checker) > 28)
                    {                       
                        CheckForErrorInput("The digits for the day cant be more than 28!");                        
                    }
                    else if (int.Parse(checker) > 31)
                    {
                        CheckForErrorInput("The digits for the day cant be more than 31!");
                    }
                }

            }
            else if (tbEGNAddUser.Text.Length == 10)
            {
                isValidated = true;
                tbEGNAddUser.BackColor = Color.Blue;
            }
            else if (tbEGNAddUser.Text.Length > 10)
            {
                tbEGNAddUser.Text = tbEGNAddUser.Text.Remove(tbEGNAddUser.Text.Length - 1);
                MessageBox.Show("The lenght of the EGN is 10 digits!");
            }

        }
        private void tbEGNAddUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseOnlyDigits(e);
        } 
        private void tbSalaryAddUser_TextChanged(object sender, EventArgs e)
        {
            if (tbSalaryAddUser.Text.Length == 0)
            {
                tbSalaryAddUser.BackColor = Color.Red;
            }
            else
            {
                tbSalaryAddUser.BackColor = Color.Blue;
            }
            if (tbSalaryAddUser.Text.Length > 10)
            {
                tbSalaryAddUser.Text = tbSalaryAddUser.Text.Remove(tbSalaryAddUser.Text.Length - 1);
                MessageBox.Show("The maximum lenght of the salary is 10 digits!");
            }
        }
        private void tbSalaryAddUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            UseOnlyDigits(e);
        }
        private void cbProfessionAddUser_TextChanged(object sender, EventArgs e)
        {
            cbProfessionAddUser.ResetText();
        }
        private void cbDepartment_TextChanged(object sender, EventArgs e)
        {
            cbDepartment.ResetText();        
        }               
    }
}
