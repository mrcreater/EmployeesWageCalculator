namespace A2ParinkumarPatel
{
    partial class Form1
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
            this.grpbxSelectTypeEmployee = new System.Windows.Forms.GroupBox();
            this.rdbtnWeeklySalary = new System.Windows.Forms.RadioButton();
            this.rdbtnCommissionBased = new System.Windows.Forms.RadioButton();
            this.rdbtnHourlyPaid = new System.Windows.Forms.RadioButton();
            this.grpbxEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.txtbxHourlyWage = new System.Windows.Forms.TextBox();
            this.txtbxHoursWorked = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lbHourlyWage = new System.Windows.Forms.Label();
            this.lbHoursWorked = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.grpCalculatedWage = new System.Windows.Forms.GroupBox();
            this.txtbxNetEarnings = new System.Windows.Forms.TextBox();
            this.txtbxLessTax = new System.Windows.Forms.TextBox();
            this.txtbxGrossEarnings = new System.Windows.Forms.TextBox();
            this.lbNetEarnings = new System.Windows.Forms.Label();
            this.lbLessTax = new System.Windows.Forms.Label();
            this.lbGrossEarnings = new System.Windows.Forms.Label();
            this.cmbxEmployees = new System.Windows.Forms.ComboBox();
            this.lbEmployee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpbxSelectTypeEmployee.SuspendLayout();
            this.grpbxEmployeeInformation.SuspendLayout();
            this.grpCalculatedWage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxSelectTypeEmployee
            // 
            this.grpbxSelectTypeEmployee.Controls.Add(this.rdbtnWeeklySalary);
            this.grpbxSelectTypeEmployee.Controls.Add(this.rdbtnCommissionBased);
            this.grpbxSelectTypeEmployee.Controls.Add(this.rdbtnHourlyPaid);
            this.grpbxSelectTypeEmployee.Location = new System.Drawing.Point(36, 31);
            this.grpbxSelectTypeEmployee.Name = "grpbxSelectTypeEmployee";
            this.grpbxSelectTypeEmployee.Size = new System.Drawing.Size(628, 100);
            this.grpbxSelectTypeEmployee.TabIndex = 0;
            this.grpbxSelectTypeEmployee.TabStop = false;
            this.grpbxSelectTypeEmployee.Text = "Select Type of Employee";
            this.grpbxSelectTypeEmployee.Enter += new System.EventHandler(this.rdbtnChangedText);
            // 
            // rdbtnWeeklySalary
            // 
            this.rdbtnWeeklySalary.AutoSize = true;
            this.rdbtnWeeklySalary.Location = new System.Drawing.Point(467, 43);
            this.rdbtnWeeklySalary.Name = "rdbtnWeeklySalary";
            this.rdbtnWeeklySalary.Size = new System.Drawing.Size(119, 21);
            this.rdbtnWeeklySalary.TabIndex = 2;
            this.rdbtnWeeklySalary.TabStop = true;
            this.rdbtnWeeklySalary.Text = "Weekly Salary";
            this.rdbtnWeeklySalary.UseVisualStyleBackColor = true;
            this.rdbtnWeeklySalary.CheckedChanged += new System.EventHandler(this.rdbtnChangedText);
            // 
            // rdbtnCommissionBased
            // 
            this.rdbtnCommissionBased.AutoSize = true;
            this.rdbtnCommissionBased.Location = new System.Drawing.Point(257, 43);
            this.rdbtnCommissionBased.Name = "rdbtnCommissionBased";
            this.rdbtnCommissionBased.Size = new System.Drawing.Size(152, 21);
            this.rdbtnCommissionBased.TabIndex = 1;
            this.rdbtnCommissionBased.TabStop = true;
            this.rdbtnCommissionBased.Text = "Commission Based ";
            this.rdbtnCommissionBased.UseVisualStyleBackColor = true;
            this.rdbtnCommissionBased.CheckedChanged += new System.EventHandler(this.rdbtnChangedText);
            // 
            // rdbtnHourlyPaid
            // 
            this.rdbtnHourlyPaid.AutoSize = true;
            this.rdbtnHourlyPaid.Checked = true;
            this.rdbtnHourlyPaid.Location = new System.Drawing.Point(50, 43);
            this.rdbtnHourlyPaid.Name = "rdbtnHourlyPaid";
            this.rdbtnHourlyPaid.Size = new System.Drawing.Size(102, 21);
            this.rdbtnHourlyPaid.TabIndex = 0;
            this.rdbtnHourlyPaid.TabStop = true;
            this.rdbtnHourlyPaid.Text = "Hourly Paid";
            this.rdbtnHourlyPaid.UseVisualStyleBackColor = true;
            // 
            // grpbxEmployeeInformation
            // 
            this.grpbxEmployeeInformation.Controls.Add(this.txtbxHourlyWage);
            this.grpbxEmployeeInformation.Controls.Add(this.txtbxHoursWorked);
            this.grpbxEmployeeInformation.Controls.Add(this.txtbxName);
            this.grpbxEmployeeInformation.Controls.Add(this.lbHourlyWage);
            this.grpbxEmployeeInformation.Controls.Add(this.lbHoursWorked);
            this.grpbxEmployeeInformation.Controls.Add(this.lbName);
            this.grpbxEmployeeInformation.Location = new System.Drawing.Point(36, 160);
            this.grpbxEmployeeInformation.Name = "grpbxEmployeeInformation";
            this.grpbxEmployeeInformation.Size = new System.Drawing.Size(392, 180);
            this.grpbxEmployeeInformation.TabIndex = 1;
            this.grpbxEmployeeInformation.TabStop = false;
            this.grpbxEmployeeInformation.Text = "Input the Employee\'s Information";
            // 
            // txtbxHourlyWage
            // 
            this.txtbxHourlyWage.Location = new System.Drawing.Point(183, 131);
            this.txtbxHourlyWage.Name = "txtbxHourlyWage";
            this.txtbxHourlyWage.Size = new System.Drawing.Size(184, 22);
            this.txtbxHourlyWage.TabIndex = 5;
            // 
            // txtbxHoursWorked
            // 
            this.txtbxHoursWorked.Location = new System.Drawing.Point(183, 84);
            this.txtbxHoursWorked.Name = "txtbxHoursWorked";
            this.txtbxHoursWorked.Size = new System.Drawing.Size(184, 22);
            this.txtbxHoursWorked.TabIndex = 4;
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(183, 37);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(184, 22);
            this.txtbxName.TabIndex = 3;
            // 
            // lbHourlyWage
            // 
            this.lbHourlyWage.AutoSize = true;
            this.lbHourlyWage.Location = new System.Drawing.Point(50, 131);
            this.lbHourlyWage.Name = "lbHourlyWage";
            this.lbHourlyWage.Size = new System.Drawing.Size(94, 17);
            this.lbHourlyWage.TabIndex = 2;
            this.lbHourlyWage.Text = "Hourly Wage:";
            // 
            // lbHoursWorked
            // 
            this.lbHoursWorked.AutoSize = true;
            this.lbHoursWorked.Location = new System.Drawing.Point(50, 84);
            this.lbHoursWorked.Name = "lbHoursWorked";
            this.lbHoursWorked.Size = new System.Drawing.Size(103, 17);
            this.lbHoursWorked.TabIndex = 1;
            this.lbHoursWorked.Text = "Hours Worked:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(50, 40);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 17);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // grpCalculatedWage
            // 
            this.grpCalculatedWage.Controls.Add(this.txtbxNetEarnings);
            this.grpCalculatedWage.Controls.Add(this.txtbxLessTax);
            this.grpCalculatedWage.Controls.Add(this.txtbxGrossEarnings);
            this.grpCalculatedWage.Controls.Add(this.lbNetEarnings);
            this.grpCalculatedWage.Controls.Add(this.lbLessTax);
            this.grpCalculatedWage.Controls.Add(this.lbGrossEarnings);
            this.grpCalculatedWage.Location = new System.Drawing.Point(36, 377);
            this.grpCalculatedWage.Name = "grpCalculatedWage";
            this.grpCalculatedWage.Size = new System.Drawing.Size(628, 165);
            this.grpCalculatedWage.TabIndex = 2;
            this.grpCalculatedWage.TabStop = false;
            this.grpCalculatedWage.Text = "Calculated Wage";
            // 
            // txtbxNetEarnings
            // 
            this.txtbxNetEarnings.Location = new System.Drawing.Point(183, 126);
            this.txtbxNetEarnings.Name = "txtbxNetEarnings";
            this.txtbxNetEarnings.ReadOnly = true;
            this.txtbxNetEarnings.Size = new System.Drawing.Size(184, 22);
            this.txtbxNetEarnings.TabIndex = 8;
            // 
            // txtbxLessTax
            // 
            this.txtbxLessTax.Location = new System.Drawing.Point(183, 82);
            this.txtbxLessTax.Name = "txtbxLessTax";
            this.txtbxLessTax.ReadOnly = true;
            this.txtbxLessTax.Size = new System.Drawing.Size(184, 22);
            this.txtbxLessTax.TabIndex = 7;
            // 
            // txtbxGrossEarnings
            // 
            this.txtbxGrossEarnings.Location = new System.Drawing.Point(183, 42);
            this.txtbxGrossEarnings.Name = "txtbxGrossEarnings";
            this.txtbxGrossEarnings.ReadOnly = true;
            this.txtbxGrossEarnings.Size = new System.Drawing.Size(184, 22);
            this.txtbxGrossEarnings.TabIndex = 6;
            // 
            // lbNetEarnings
            // 
            this.lbNetEarnings.AutoSize = true;
            this.lbNetEarnings.Location = new System.Drawing.Point(50, 126);
            this.lbNetEarnings.Name = "lbNetEarnings";
            this.lbNetEarnings.Size = new System.Drawing.Size(94, 17);
            this.lbNetEarnings.TabIndex = 5;
            this.lbNetEarnings.Text = "Net Earnings:";
            // 
            // lbLessTax
            // 
            this.lbLessTax.AutoSize = true;
            this.lbLessTax.Location = new System.Drawing.Point(50, 82);
            this.lbLessTax.Name = "lbLessTax";
            this.lbLessTax.Size = new System.Drawing.Size(69, 17);
            this.lbLessTax.TabIndex = 4;
            this.lbLessTax.Text = "Less Tax:";
            // 
            // lbGrossEarnings
            // 
            this.lbGrossEarnings.AutoSize = true;
            this.lbGrossEarnings.Location = new System.Drawing.Point(50, 42);
            this.lbGrossEarnings.Name = "lbGrossEarnings";
            this.lbGrossEarnings.Size = new System.Drawing.Size(110, 17);
            this.lbGrossEarnings.TabIndex = 3;
            this.lbGrossEarnings.Text = "Gross Earnings:";
            // 
            // cmbxEmployees
            // 
            this.cmbxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmployees.FormattingEnabled = true;
            this.cmbxEmployees.Location = new System.Drawing.Point(219, 581);
            this.cmbxEmployees.Name = "cmbxEmployees";
            this.cmbxEmployees.Size = new System.Drawing.Size(334, 24);
            this.cmbxEmployees.TabIndex = 0;
            this.cmbxEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbxEmployees_SelectedIndexChanged);
            // 
            // lbEmployee
            // 
            this.lbEmployee.AutoSize = true;
            this.lbEmployee.Location = new System.Drawing.Point(86, 581);
            this.lbEmployee.Name = "lbEmployee";
            this.lbEmployee.Size = new System.Drawing.Size(81, 17);
            this.lbEmployee.TabIndex = 3;
            this.lbEmployee.Text = "Employees:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(503, 194);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(503, 243);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(503, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 647);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbEmployee);
            this.Controls.Add(this.cmbxEmployees);
            this.Controls.Add(this.grpCalculatedWage);
            this.Controls.Add(this.grpbxEmployeeInformation);
            this.Controls.Add(this.grpbxSelectTypeEmployee);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.grpbxSelectTypeEmployee.ResumeLayout(false);
            this.grpbxSelectTypeEmployee.PerformLayout();
            this.grpbxEmployeeInformation.ResumeLayout(false);
            this.grpbxEmployeeInformation.PerformLayout();
            this.grpCalculatedWage.ResumeLayout(false);
            this.grpCalculatedWage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSelectTypeEmployee;
        private System.Windows.Forms.RadioButton rdbtnWeeklySalary;
        private System.Windows.Forms.RadioButton rdbtnCommissionBased;
        private System.Windows.Forms.RadioButton rdbtnHourlyPaid;
        private System.Windows.Forms.GroupBox grpbxEmployeeInformation;
        private System.Windows.Forms.TextBox txtbxHourlyWage;
        private System.Windows.Forms.TextBox txtbxHoursWorked;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lbHourlyWage;
        private System.Windows.Forms.Label lbHoursWorked;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox grpCalculatedWage;
        private System.Windows.Forms.TextBox txtbxNetEarnings;
        private System.Windows.Forms.TextBox txtbxLessTax;
        private System.Windows.Forms.TextBox txtbxGrossEarnings;
        private System.Windows.Forms.Label lbNetEarnings;
        private System.Windows.Forms.Label lbLessTax;
        private System.Windows.Forms.Label lbGrossEarnings;
        private System.Windows.Forms.ComboBox cmbxEmployees;
        private System.Windows.Forms.Label lbEmployee;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

