namespace frmMain
{
    partial class frmManageEmployees
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
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployer = new System.Windows.Forms.Button();
            this.btnEditEmployer = new System.Windows.Forms.Button();
            this.btnDeleteEmployer = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.tbThirdName = new System.Windows.Forms.TextBox();
            this.tbEGN = new System.Windows.Forms.TextBox();
            this.tbProfession = new System.Windows.Forms.TextBox();
            this.tbSalary = new System.Windows.Forms.TextBox();
            this.tbDateOfArrival = new System.Windows.Forms.TextBox();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(12, 42);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(244, 368);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "All employees";
            // 
            // btnAddEmployer
            // 
            this.btnAddEmployer.Location = new System.Drawing.Point(262, 67);
            this.btnAddEmployer.Name = "btnAddEmployer";
            this.btnAddEmployer.Size = new System.Drawing.Size(95, 23);
            this.btnAddEmployer.TabIndex = 2;
            this.btnAddEmployer.Text = "Add employee";
            this.btnAddEmployer.UseVisualStyleBackColor = true;
            this.btnAddEmployer.Click += new System.EventHandler(this.btnAddEmployer_Click);
            // 
            // btnEditEmployer
            // 
            this.btnEditEmployer.Location = new System.Drawing.Point(262, 96);
            this.btnEditEmployer.Name = "btnEditEmployer";
            this.btnEditEmployer.Size = new System.Drawing.Size(95, 23);
            this.btnEditEmployer.TabIndex = 3;
            this.btnEditEmployer.Text = "Edit employee";
            this.btnEditEmployer.UseVisualStyleBackColor = true;
            this.btnEditEmployer.Click += new System.EventHandler(this.btnEditEmployer_Click);
            // 
            // btnDeleteEmployer
            // 
            this.btnDeleteEmployer.Location = new System.Drawing.Point(262, 125);
            this.btnDeleteEmployer.Name = "btnDeleteEmployer";
            this.btnDeleteEmployer.Size = new System.Drawing.Size(95, 23);
            this.btnDeleteEmployer.TabIndex = 4;
            this.btnDeleteEmployer.Text = "Delete";
            this.btnDeleteEmployer.UseVisualStyleBackColor = true;
            this.btnDeleteEmployer.Click += new System.EventHandler(this.btnDeleteEmployer_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Enabled = false;
            this.tbFirstName.Location = new System.Drawing.Point(507, 42);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 5;
            // 
            // tbSecondName
            // 
            this.tbSecondName.Enabled = false;
            this.tbSecondName.Location = new System.Drawing.Point(507, 67);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(100, 20);
            this.tbSecondName.TabIndex = 6;
            // 
            // tbThirdName
            // 
            this.tbThirdName.Enabled = false;
            this.tbThirdName.Location = new System.Drawing.Point(507, 93);
            this.tbThirdName.Name = "tbThirdName";
            this.tbThirdName.Size = new System.Drawing.Size(100, 20);
            this.tbThirdName.TabIndex = 7;
            // 
            // tbEGN
            // 
            this.tbEGN.Enabled = false;
            this.tbEGN.Location = new System.Drawing.Point(507, 119);
            this.tbEGN.Name = "tbEGN";
            this.tbEGN.Size = new System.Drawing.Size(100, 20);
            this.tbEGN.TabIndex = 8;
            // 
            // tbProfession
            // 
            this.tbProfession.Enabled = false;
            this.tbProfession.Location = new System.Drawing.Point(507, 145);
            this.tbProfession.Name = "tbProfession";
            this.tbProfession.Size = new System.Drawing.Size(100, 20);
            this.tbProfession.TabIndex = 9;
            // 
            // tbSalary
            // 
            this.tbSalary.Enabled = false;
            this.tbSalary.Location = new System.Drawing.Point(507, 171);
            this.tbSalary.Name = "tbSalary";
            this.tbSalary.Size = new System.Drawing.Size(100, 20);
            this.tbSalary.TabIndex = 10;
            // 
            // tbDateOfArrival
            // 
            this.tbDateOfArrival.Enabled = false;
            this.tbDateOfArrival.Location = new System.Drawing.Point(507, 197);
            this.tbDateOfArrival.Name = "tbDateOfArrival";
            this.tbDateOfArrival.Size = new System.Drawing.Size(100, 20);
            this.tbDateOfArrival.TabIndex = 11;
            // 
            // tbDepartment
            // 
            this.tbDepartment.Enabled = false;
            this.tbDepartment.Location = new System.Drawing.Point(507, 223);
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(100, 20);
            this.tbDepartment.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Second Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Family Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "EGN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(444, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Profession";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Date of Arrival";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Department";
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 435);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.tbDateOfArrival);
            this.Controls.Add(this.tbSalary);
            this.Controls.Add(this.tbProfession);
            this.Controls.Add(this.tbEGN);
            this.Controls.Add(this.tbThirdName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.btnDeleteEmployer);
            this.Controls.Add(this.btnEditEmployer);
            this.Controls.Add(this.btnAddEmployer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmployees);
            this.Name = "frmManageEmployees";
            this.Text = "Employeе Control";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddEmployer;
        private System.Windows.Forms.Button btnEditEmployer;
        private System.Windows.Forms.Button btnDeleteEmployer;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.TextBox tbThirdName;
        private System.Windows.Forms.TextBox tbEGN;
        private System.Windows.Forms.TextBox tbProfession;
        private System.Windows.Forms.TextBox tbSalary;
        private System.Windows.Forms.TextBox tbDateOfArrival;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}