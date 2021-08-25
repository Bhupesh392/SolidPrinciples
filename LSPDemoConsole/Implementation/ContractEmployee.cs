using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    //Liskov Violation
    public class ContractEmployee : IEmployee
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public ContractEmployee() { }
        public ContractEmployee(int id, string name) 
        {
            this.ID = id;
            this.Name = name;
        }
        public decimal GetMinimumSalary()
        {
            return 5000;
        }
        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", this.ID, this.Name);
        }

        //Imagine Contract EMployee doesn't get the bonus. now it's breaking the Liskov principle which says that no sub class can throw error. So lets create another Interface IEmployeeBonus
        //public override decimal CalculateBonus(decimal salary)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
