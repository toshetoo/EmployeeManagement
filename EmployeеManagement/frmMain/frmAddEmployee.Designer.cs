namespace frmMain
{
    partial class frmAddEmployee
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSalaryAddUser = new System.Windows.Forms.TextBox();
            this.tbEGNAddUser = new System.Windows.Forms.TextBox();
            this.tbFamilyNameAddUser = new System.Windows.Forms.TextBox();
            this.tbSecondNameAddUser = new System.Windows.Forms.TextBox();
            this.tbNameAddUser = new System.Windows.Forms.TextBox();
            this.cbProfessionAddUser = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.btnSaveNewUser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Date of Arrival";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Profession";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "EGN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Family Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Second Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "First Name";
            // 
            // tbSalaryAddUser
            // 
            this.tbSalaryAddUser.Location = new System.Drawing.Point(82, 170);
            this.tbSalaryAddUser.Name = "tbSalaryAddUser";
            this.tbSalaryAddUser.Size = new System.Drawing.Size(128, 20);
            this.tbSalaryAddUser.TabIndex = 26;
            this.tbSalaryAddUser.TextChanged += new System.EventHandler(this.tbSalaryAddUser_TextChanged);
            this.tbSalaryAddUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSalaryAddUser_KeyPress);
            // 
            // tbEGNAddUser
            // 
            this.tbEGNAddUser.Location = new System.Drawing.Point(82, 118);
            this.tbEGNAddUser.Name = "tbEGNAddUser";
            this.tbEGNAddUser.Size = new System.Drawing.Size(128, 20);
            this.tbEGNAddUser.TabIndex = 24;
            this.tbEGNAddUser.TextChanged += new System.EventHandler(this.tbEGNAddUser_TextChanged);
            this.tbEGNAddUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEGNAddUser_KeyPress);
            // 
            // tbFamilyNameAddUser
            // 
            this.tbFamilyNameAddUser.Location = new System.Drawing.Point(82, 92);
            this.tbFamilyNameAddUser.Name = "tbFamilyNameAddUser";
            this.tbFamilyNameAddUser.Size = new System.Drawing.Size(128, 20);
            this.tbFamilyNameAddUser.TabIndex = 23;
            this.tbFamilyNameAddUser.TextChanged += new System.EventHandler(this.tbFamilyNameAddUser_TextChanged);
            this.tbFamilyNameAddUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFamilyNameAddUser_KeyPress);
            // 
            // tbSecondNameAddUser
            // 
            this.tbSecondNameAddUser.Location = new System.Drawing.Point(82, 66);
            this.tbSecondNameAddUser.Name = "tbSecondNameAddUser";
            this.tbSecondNameAddUser.Size = new System.Drawing.Size(128, 20);
            this.tbSecondNameAddUser.TabIndex = 22;
            this.tbSecondNameAddUser.TextChanged += new System.EventHandler(this.tbSecondNameAddUser_TextChanged);
            this.tbSecondNameAddUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSecondNameAddUser_KeyPress);
            // 
            // tbNameAddUser
            // 
            this.tbNameAddUser.Location = new System.Drawing.Point(82, 41);
            this.tbNameAddUser.Name = "tbNameAddUser";
            this.tbNameAddUser.Size = new System.Drawing.Size(128, 20);
            this.tbNameAddUser.TabIndex = 21;
            this.tbNameAddUser.TextChanged += new System.EventHandler(this.tbNameAddUser_TextChanged);
            this.tbNameAddUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNameAddUser_KeyPress);
            // 
            // cbProfessionAddUser
            // 
            this.cbProfessionAddUser.FormattingEnabled = true;
            this.cbProfessionAddUser.Items.AddRange(new object[] {
            "Banker",
            "Account",
            "Boss",
            "Programmer",
            "QA"});
            this.cbProfessionAddUser.Location = new System.Drawing.Point(81, 143);
            this.cbProfessionAddUser.Name = "cbProfessionAddUser";
            this.cbProfessionAddUser.Size = new System.Drawing.Size(129, 21);
            this.cbProfessionAddUser.TabIndex = 37;
            this.cbProfessionAddUser.TextChanged += new System.EventHandler(this.cbProfessionAddUser_TextChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Finance",
            "Big stuff",
            "Bossy"});
            this.cbDepartment.Location = new System.Drawing.Point(82, 222);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(128, 21);
            this.cbDepartment.TabIndex = 38;
            this.cbDepartment.TextChanged += new System.EventHandler(this.cbDepartment_TextChanged);
            // 
            // btnSaveNewUser
            // 
            this.btnSaveNewUser.Location = new System.Drawing.Point(22, 269);
            this.btnSaveNewUser.Name = "btnSaveNewUser";
            this.btnSaveNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNewUser.TabIndex = 39;
            this.btnSaveNewUser.Text = "Add";
            this.btnSaveNewUser.UseVisualStyleBackColor = true;
            this.btnSaveNewUser.Click += new System.EventHandler(this.btnSaveNewUser_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 20);
            this.dateTimePicker1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Add Employee";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSaveNewUser);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.cbProfessionAddUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSalaryAddUser);
            this.Controls.Add(this.tbEGNAddUser);
            this.Controls.Add(this.tbFamilyNameAddUser);
            this.Controls.Add(this.tbSecondNameAddUser);
            this.Controls.Add(this.tbNameAddUser);
            this.Name = "frmAddEmployee";
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSalaryAddUser;
        private System.Windows.Forms.TextBox tbEGNAddUser;
        private System.Windows.Forms.TextBox tbFamilyNameAddUser;
        private System.Windows.Forms.TextBox tbSecondNameAddUser;
        private System.Windows.Forms.TextBox tbNameAddUser;
        private System.Windows.Forms.ComboBox cbProfessionAddUser;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnSaveNewUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}