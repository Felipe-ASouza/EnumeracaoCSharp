using System;
using enum1.Entities;
using enum1.Entities.Enums;

namespace enum1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus) Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);
        }
    }
}