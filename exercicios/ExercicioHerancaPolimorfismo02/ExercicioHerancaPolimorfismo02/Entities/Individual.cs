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

        public override double TaxesPaid()
        {
            if(AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - HealthExpediture * 0.50;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpediture * 0.50;
            }
        }
    }
}
