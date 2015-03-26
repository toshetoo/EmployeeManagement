using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    class FileManagement
    {
        public FileManagement()
        {

        }
        public void ReadFile(string fileName, List<string> egnList)
        {

            using (StreamReader sr = new StreamReader(fileName))
            {

                string line = "";
                while ((line = sr.ReadLine()) != null)
                {
                    Employee emp = new Employee();
                    string[] splitted = line.Split(',');                    
                    emp.EGN = splitted[3];                    

                    egnList.Add(emp.EGN);

                }
            }
        }
        public void ReadFile(string fileName, List<Employee> list)
        {
            
            using (StreamReader sr = new StreamReader(fileName))
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

                    list.Add(emp);                   

                }
            }
        }
        public void ReadFile(string fileName, List<Employee> list, ListBox listBox)
        {
            
            using (StreamReader sr = new StreamReader(fileName))
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

                    list.Add(emp);
                    listBox.Items.Add(emp.FirstName + " " + emp.ThirdName+", "+emp.EGN);
                }
            }
        }
        public void ReadFile(string fileName, List<Employee> list, ComboBox comboBox)
        {
            
            using (StreamReader sr = new StreamReader(fileName))
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

                    list.Add(emp);
                    comboBox.Items.Add(emp.FirstName + " " + emp.ThirdName + ", "+emp.EGN);
                }
            }
        }
        public void WriteFile(string fileName, bool toAppend,List<Employee> list)
        {
            using (StreamWriter sw = new StreamWriter(fileName,toAppend))
            {
                foreach (Employee emp in list)
                {
                    sw.WriteLine(
                    emp.FirstName + "," + emp.SecondName + "," + emp.ThirdName + "," + emp.EGN + ","
                        + emp.Profession + "," + emp.Department + "," + emp.Salary + "," + emp.HireDate
                    );
                }
            }
        }
    }
}
