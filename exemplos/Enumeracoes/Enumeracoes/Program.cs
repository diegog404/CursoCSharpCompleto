using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

//converte um tipo enumerado em string
string txt = OrderStatus.PendingPayment.ToString();
Console.WriteLine(txt);

//converte um string para um tipo enumerado
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine(os);