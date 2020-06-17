using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ParinkumarPatel
{
    class SalariedEmployee : Employee
    {
        
        private double _salary;

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public SalariedEmployee(String employeeName, EmployeeType employeeType,
            double salary) : base(employeeName, employeeType)
        {
            Salary = salary;
        }


        public override double GrossEarnings
        {
            get
            {
                return Salary;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\n Salary : { Salary:C}";
        }
    }
}
