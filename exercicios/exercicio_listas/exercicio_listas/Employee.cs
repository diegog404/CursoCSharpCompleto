using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_listas
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public double Salary;

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreseSalary(double percentage)
        {
            Salary = Salary + (Salary / 100) * percentage;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
