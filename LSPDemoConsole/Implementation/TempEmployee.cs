using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPDemoConsole.Implementation
{
    public class TempEmployee : Employee
    {
        public TempEmployee() { }
        public TempEmployee(int id, string name) : base(id, name)
        {
        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
