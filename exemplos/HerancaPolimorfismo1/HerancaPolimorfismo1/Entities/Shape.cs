using HerancaPolimorfismo1.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo1.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }

        //nao colocar um construtor sem argumentos obriga as outras classes a terem um color
        public Shape(Color color) 
        {
            Color = color;
        }

        //nao precisa do virtual se é abstrato
        public abstract double Area();
    }
}
