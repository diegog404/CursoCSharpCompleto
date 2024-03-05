using ExercicioEnumComposicao.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioEnumComposicao.Entities
{
    internal class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Clients { get; set; }

        public Order()
        {
        }

        public Order(DateTime momment, OrderStatus status, Client clients)
        {
            Momment = momment;
            Status = status;
            Clients = clients;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;

            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Momment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Clients.Name + " (" + Clients.BirthDate.ToString("dd/MM/yyyy") + ") - " + Clients.Email);
            sb.AppendLine("Order items:");

            foreach (OrderItem oi in Items)
            {
                sb.AppendLine(oi.Product.Name + ", " + oi.Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", Quantity: " + oi.Quantity + ", SubTotal: " + oi.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}
