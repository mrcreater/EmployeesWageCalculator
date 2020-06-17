using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ParinkumarPatel
{
    class HourlyEmployee : Employee
    {
        private double _wage;

        public double Wage
        {
            get { return _wage; }
            set { _wage = value; }
        }

        private double _hours;

        public double Hours
        {
            get { return _hours; }
            set { _hours = value; }
        }



        public HourlyEmployee(String employeeName, EmployeeType employeeType,
            double wage, double hours) : base(employeeName, employeeType)
        {
            Wage = wage;
            Hours = hours;
        }

        public override double GrossEarnings
        {
            get
            {
                if (Hours <= 40)
                    return Hours * Wage;
                else
                    return (40 * Wage) + (Hours - 40) * Wage * 1.5;
            }
        }
        public override string ToString()
        {
            return base.ToString() + "$\nHours:  {Hours}\nWage: { Wage:C}";
        }
    }
}
