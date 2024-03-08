using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioHerancaPolimorfismo.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturerDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(DateTime manufacturerDate, string name, double price) : base (name, price)
        {
            ManufacturerDate = manufacturerDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " + ManufacturerDate.ToString("dd/MM/yyyy") + ")"; 
        }
    }
}
