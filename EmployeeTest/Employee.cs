using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTest
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private decimal monthlySalary;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value > 0)
                {
                    monthlySalary = value;
                }
            }
        }

        public Employee(string name1, string name2, decimal salary)
        {
            FirstName = name1;
            LastName = name2;
            MonthlySalary = salary;
        }

        public decimal annualSalary ()
        {
            decimal annual = monthlySalary * 12;
            return annual;
        }



        public decimal salaryRaise (decimal newSalary)
        {
            newSalary = (newSalary / 10) + newSalary;
            newSalary = newSalary * 12;
            return newSalary;
        }
    }
}
