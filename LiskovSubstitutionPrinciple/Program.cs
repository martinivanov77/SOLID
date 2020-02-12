using LiskovSubstitutionPrinciple.Abstract;
using LiskovSubstitutionPrinciple.Implementatuions;
using LiskovSubstitutionPrinciple.Interfaces;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));

            //Cannot replace base objects of base type Employees with ContractEmployee, as ContractEmployee inherits the IEmployee interface, and not the Employee Abstract class
            //employees.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee: {0} Bonus: {1} Minimum Salary {2}", employee.ToString(), employee.CalculateBonus(100000).ToString(),
                    employee.GetMinimumSalary().ToString()));
            }

            Console.WriteLine();

            //Here we are able to initialize List of IEmployee, and then add PermanentEmployee due to the inheritence structure(Employee: IEmployee ; PermanentEmployee:Employee)
            List<IEmployee> permanentEmployees = new List<IEmployee>();

            permanentEmployees.Add(new PermanentEmployee(1, "John"));
            permanentEmployees.Add(new PermanentEmployee(2, "Jason"));
            permanentEmployees.Add(new PermanentEmployee(3, "Mike"));

            foreach (var employee in permanentEmployees)
            {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }

            Console.ReadLine();
            
            //List<T> inherits from IEnumerable, IList, ICollection, thus instances of List<T> are able to replace the base interfaces, following the LSP!
            IEnumerable <Employee> employeeEnumerable = new List<Employee>();
            IList<Employee> employeeIList = new List<Employee>();
            ICollection<Employee> empCollection = new List<Employee>();
        }
    }
}
