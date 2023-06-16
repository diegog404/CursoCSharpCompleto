using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo02.Entities
{
    internal class Company : TaxPayer
    {
        public int EmployeeNumber { get; set; }

        public Company(int employeeNumber, string name, double anualIncome) : base(name, anualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double TaxesPaid()
        {
            if(EmployeeNumber > 10)
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
