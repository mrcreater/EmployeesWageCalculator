using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ParinkumarPatel
{
    class ComissionEmployee : Employee
    {
        private double _comissionRate;

        public double ComissionRate
        {
            get { return _comissionRate; }
            set { _comissionRate = value; }
        }

        private double _grossSale;

        public double GrossSale
        {
            get { return _grossSale; }
            set { _grossSale = value; }
        }

        public ComissionEmployee(String employeeName, EmployeeType employeeType,
            double comissionRate, double grossSales) : base(employeeName, employeeType)
        {
            ComissionRate = comissionRate;
            GrossSale = grossSales;
        }


        public override double GrossEarnings
        {
            get
            {
                return ComissionRate * GrossSale/100;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCommissionRate: {ComissionRate:P}" + $"\nGross Sales: {GrossSale:C}";
        }
    }
}
