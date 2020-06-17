using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2ParinkumarPatel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void rdbtnChangedText(object sender, EventArgs e)
        {
            if (rdbtnHourlyPaid.Checked)
            {
                lbHoursWorked.Text = "Hours Worked:";
                lbHourlyWage.Text = "Hourly Wage:";
                txtbxHourlyWage.Show();
            }

            else if (rdbtnCommissionBased.Checked)
            {
                lbHoursWorked.Text = "Gross Sales:";
                lbHourlyWage.Text = "Commission Rate:";
                txtbxHourlyWage.Show();
            }

            else if (rdbtnWeeklySalary.Checked)
            {
                lbHoursWorked.Text = "Weekly Salary:";
                lbHourlyWage.Text = null;
                txtbxHourlyWage.Hide();
            }
        }

        List<ListOfEmployees> EmployeeList = new List<ListOfEmployees>();

        private void CmbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeName = cmbxEmployees.GetItemText(cmbxEmployees.SelectedItem);
            List<string> employeeNameList = new List<string>();
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if (EmployeeList[i].employeeName == employeeName)
                {
                    txtbxName.Text = EmployeeList[i].employeeName;

                    txtbxHoursWorked.Text = EmployeeList[i].hoursWorked.ToString();
                    txtbxHourlyWage.Text = EmployeeList[i].hourlyWage.ToString();
                    txtbxGrossEarnings.Text = EmployeeList[i].grossEarning.ToString();
                    txtbxLessTax.Text = EmployeeList[i].lessTax.ToString();
                    txtbxNetEarnings.Text = EmployeeList[i].NetEarning.ToString();
                }
            }
        }

        

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (rdbtnHourlyPaid.Checked)
            {
                double hoursWork = Convert.ToDouble(txtbxHoursWorked.Text);
                double hourlyWage = Convert.ToDouble(txtbxHourlyWage.Text);
                Employee _employeeClass = new HourlyEmployee(txtbxName.Text, EmployeeType.HourlyEmployee, hourlyWage, hoursWork);
                txtbxGrossEarnings.Text = _employeeClass.GrossEarnings.ToString("C");
                txtbxLessTax.Text = _employeeClass.PropertyTax.ToString("C");
                txtbxNetEarnings.Text = _employeeClass.NetEarnings.ToString("C");

                ListOfEmployees addEmployee = new ListOfEmployees(txtbxName.Text, EmployeeType.HourlyEmployee, hoursWork, hourlyWage, 0.0, 0.0, 0.0, _employeeClass.GrossEarnings, _employeeClass.PropertyTax, _employeeClass.NetEarnings);

                EmployeeList.Add(addEmployee);
                cmbxEmployees.Items.Add(txtbxName.Text);


            }
            if (rdbtnCommissionBased.Checked)
            {
                double grossSales = Convert.ToDouble(txtbxHoursWorked.Text);
                double commissionRate = Convert.ToDouble(txtbxHourlyWage.Text);
                Employee _employeeClass = new ComissionEmployee(txtbxName.Text, EmployeeType.CommissionEmployee, grossSales, commissionRate);

                txtbxGrossEarnings.Text = _employeeClass.GrossEarnings.ToString("C");
                txtbxLessTax.Text = _employeeClass.PropertyTax.ToString("C");
                txtbxNetEarnings.Text = _employeeClass.NetEarnings.ToString("C");

                ListOfEmployees addEmployee = new ListOfEmployees(txtbxName.Text, EmployeeType.CommissionEmployee, 0.0, 0.0, grossSales, commissionRate, 0.0, _employeeClass.GrossEarnings, _employeeClass.PropertyTax, _employeeClass.NetEarnings);
                EmployeeList.Add(addEmployee);
                cmbxEmployees.Items.Add(txtbxName.Text);
            }
            if (rdbtnWeeklySalary.Checked)
            {
                double weeklySalary = Convert.ToDouble(txtbxHoursWorked.Text);


                Employee _employeeClass = new SalariedEmployee(txtbxName.Text, EmployeeType.WeeklySalaryEmployee, weeklySalary);
                txtbxGrossEarnings.Text = _employeeClass.GrossEarnings.ToString("C");
                txtbxLessTax.Text = _employeeClass.PropertyTax.ToString("C");
                txtbxNetEarnings.Text = _employeeClass.NetEarnings.ToString("C");
                ListOfEmployees addEmployee = new ListOfEmployees(txtbxName.Text, EmployeeType.CommissionEmployee, 0.0, 0.0, 0.0, 0.0, weeklySalary, _employeeClass.GrossEarnings, _employeeClass.PropertyTax, _employeeClass.NetEarnings);
                EmployeeList.Add(addEmployee);
                cmbxEmployees.Items.Add(txtbxName.Text);
            }
            
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            rdbtnHourlyPaid.Checked = true;
            rdbtnCommissionBased.Checked = false;
            rdbtnWeeklySalary.Checked = false;
            txtbxName.Text = "";
            txtbxHourlyWage.Text = "";
            txtbxHoursWorked.Text = "";
            txtbxNetEarnings.Text = "";
            txtbxGrossEarnings.Text = "";
            txtbxLessTax.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
