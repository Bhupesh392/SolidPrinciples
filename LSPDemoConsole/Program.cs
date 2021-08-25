using LSPDemoConsole.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can't Add Contract Employee
            List<Employee> employees = new List<Employee>
            {
                new PermanentEmployee(1, "John"),
                new TempEmployee(2, "Jason")
            };
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus: {1} Minimum Salary {2}", employee.ToString(), employee.CalculateBonus(100000).ToString(), employee.GetMinimumSalary()));
            }
            
            Console.ReadLine();

            List<IEmployee> employeesOnly = new List<IEmployee>
            {
                new PermanentEmployee(1, "John"),
                new TempEmployee(2, "Jason"),
                new ContractEmployee(3, "Mike")
            };
            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0} Minimum Salary {1}", 
                    employee.ToString(),
                    employee.GetMinimumSalary()));
            }

            Console.ReadLine();
        }
    }
}
