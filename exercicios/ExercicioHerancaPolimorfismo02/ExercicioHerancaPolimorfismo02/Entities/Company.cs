using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo02.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeCount { get; set; }

        public Company()
        {
        }

        public Company(int employeeCount, string name, double anualIncome): base(name, anualIncome)
        {
            EmployeeCount = employeeCount;
        }

        public override double Tax()
        {
            if (EmployeeCount > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
