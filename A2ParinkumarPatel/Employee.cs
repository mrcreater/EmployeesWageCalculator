using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ParinkumarPatel
{
    enum EmployeeType
    {
        HourlyEmployee, CommissionEmployee,
        WeeklySalaryEmployee
    }
    abstract class Employee
    {
        public virtual double HoursWorked { get; set; }
        public virtual double HourlyWage { get; set; }
        public virtual double GrossSales { get; set; }
        public virtual double CommissionRate { get; set; }
        public virtual double WeeklySalary { get; set; }

        private String _employeeName;

        public String EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        private EmployeeType _employeeType;

        public EmployeeType EmployeeType
        {
            get { return _employeeType; }
            set { _employeeType = value; }
        }

        public Employee(String employeeName, EmployeeType employeeType)
        {
            EmployeeName = employeeName;
            EmployeeType = employeeType;
        }

        public Employee(String employeeName, EmployeeType employeeType, double hoursWorked, double hourlyWage, double grossSales, double commissionRate, double weeklySalary, double grossEarnings)
        {
            EmployeeName = employeeName;
            EmployeeType = employeeType;

            HoursWorked = hoursWorked;
            HourlyWage = hourlyWage;

            GrossSales = grossSales;
            CommissionRate = commissionRate;

            WeeklySalary = weeklySalary;

            GrossEarnings = grossEarnings;
        }

        public virtual double GrossEarnings
        {
            get;
        }

        public virtual double PropertyTax
        {
            get { return (GrossEarnings * 20) / 100; }
        }

        public virtual double NetEarnings
        {
            get { return GrossEarnings - PropertyTax; }
        }


        public override string ToString()
        {
            return $"{EmployeeName}\n{EmployeeType}";
        }
    }
}
