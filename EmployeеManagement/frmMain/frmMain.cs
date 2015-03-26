using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMain
{
    public partial class frmMain : Form
    {      
        
        public frmMain()
        {
            InitializeComponent();
        }
        private void OpenValidation(Form form, ToolStripMenuItem toolStrip)
        {
            // Method checks if a form from the menu is already opened
            // so no duplicate forms can be created
            if (toolStrip.CheckState == CheckState.Unchecked)
            {
                form.Anchor = AnchorStyles.Left;
                form.Show();
                toolStrip.CheckState = CheckState.Checked;
            }
            else if (toolStrip.CheckState == CheckState.Checked)
            {
                MessageBox.Show("Form already opened!");
            }
        }
        private void aboutMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frmAbout = new frmAbout();
            frmAbout.MdiParent = this;

            OpenValidation(frmAbout,aboutMeToolStripMenuItem);
        }       

        private void workersListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageEmployees frmManageUsers = new frmManageEmployees();
            frmManageUsers.MdiParent = this;

            OpenValidation(frmManageUsers, workersListToolStripMenuItem);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }       

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                workersListToolStripMenuItem.CheckState = CheckState.Unchecked;
            }            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                aboutMeToolStripMenuItem.CheckState = CheckState.Unchecked;
            }  
        }

    }
}

