namespace EmployeeTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Onyinye", "Joann", 10.00M);
            Employee employee2 = new Employee("Presido", "Ikhu", 1.00M);

            string firstEmployee = employee1.FirstName + " " + employee1.LastName;
            string secondEmployee = employee2.FirstName + " " + employee2.LastName;

            Console.WriteLine($"Annual Salary of {firstEmployee} is: {employee1.annualSalary()}\n");
            Console.WriteLine($"Annual Salary of {secondEmployee} is: {employee2.annualSalary()}\n");

            Console.WriteLine("Giving a raise of 10% to their monthly salary\nNew salary is: \n");

            decimal employee1Salary = employee1.MonthlySalary;
            decimal employee2Salary = employee2.MonthlySalary;

            employee1Salary = employee1.salaryRaise(employee1Salary);
            employee2Salary = employee2.salaryRaise(employee2Salary);

            Console.WriteLine($"Raised Salary of {firstEmployee} is: {employee1Salary}\n");
            Console.WriteLine($"Raised Salary of {secondEmployee} is: {employee2Salary}\n");

        }
    }
}