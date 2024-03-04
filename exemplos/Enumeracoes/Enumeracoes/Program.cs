using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

//conversao enum para string
string txt = OrderStatus.PendingPayment.ToString();

//conversao de string para enum
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");