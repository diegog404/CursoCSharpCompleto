using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHerancaPolimorfismo02.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpediture { get; set; }

        public Individual(double healthExpediture, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpediture = healthExpediture;
        }

        public override double TaxesPaid(double anualIncome)
        {
            double tax;

            if(AnualIncome < 20000.00)
            {
                tax =+ anualIncome * 0.15;
            }
            else
            {
                tax = +anualIncome * 0.25;
            }

            if(HealthExpediture > 0)
            {
                tax = -HealthExpediture * 0.50;
            }

            return tax;
        }
    }
}
