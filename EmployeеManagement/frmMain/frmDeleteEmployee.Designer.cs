namespace frmMain
{
    partial class frmDeleteEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbUsersToBeDeleted = new System.Windows.Forms.ComboBox();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an Employee to delete";
            // 
            // cbUsersToBeDeleted
            // 
            this.cbUsersToBeDeleted.FormattingEnabled = true;
            this.cbUsersToBeDeleted.Location = new System.Drawing.Point(38, 38);
            this.cbUsersToBeDeleted.Name = "cbUsersToBeDeleted";
            this.cbUsersToBeDeleted.Size = new System.Drawing.Size(213, 21);
            this.cbUsersToBeDeleted.TabIndex = 1;
            this.cbUsersToBeDeleted.SelectedIndexChanged += new System.EventHandler(this.cbUsersToBeDeleted_SelectedIndexChanged);
            this.cbUsersToBeDeleted.TextChanged += new System.EventHandler(this.cbUsersToBeDeleted_TextChanged);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Enabled = false;
            this.btnDeleteUser.Location = new System.Drawing.Point(107, 82);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmDeleteEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 145);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.cbUsersToBeDeleted);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteEmployee";
            this.Text = "Delete Employee";
            this.Load += new System.EventHandler(this.frmDeleteUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUsersToBeDeleted;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}