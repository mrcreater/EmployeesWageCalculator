using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ParinkumarPatel
{
    class ListOfEmployees
    {
        public string employeeName { get; set; }
        public EmployeeType employeeType { get; set; }
        public double hoursWorked { get; set; }
        public double hourlyWage { get; set; }

        public double grossSales { get; set; }

        public double comissionRate { get; set; }

        public double weeklySalary { get; set; }

        public double grossEarning { get; set; }
        public double lessTax { get; set; }
        public double NetEarning { get; set; }

        public ListOfEmployees(string employeeName, EmployeeType employeeType, double hoursWorked, double hourlyWage, double grossSales, double comissionRate, double weeklySalary, double grossEarning, double lessTax, double netEarning)
        {
            this.employeeName = employeeName;
            this.employeeType = employeeType;
            this.hoursWorked = hoursWorked;
            this.hourlyWage = hourlyWage;
            this.grossSales = grossSales;
            this.comissionRate = comissionRate;
            this.weeklySalary = weeklySalary;
            this.grossEarning = grossEarning;
            this.lessTax = lessTax;
            NetEarning = netEarning;
        }
    }
}
