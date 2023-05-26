using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);
