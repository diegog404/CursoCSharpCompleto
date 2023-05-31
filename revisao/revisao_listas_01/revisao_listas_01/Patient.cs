using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao_listas_01
{
    internal class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Employment { get; set; }

        public Patient()
        {

        }

        public Patient(int id, string name, string employment)
        {
            Id = id;
            Name = name;
            Employment = employment;
        }
    }
}
