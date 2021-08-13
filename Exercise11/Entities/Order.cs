using Exercise11.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
namespace Exercise11.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Item { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Item.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Item.Remove(item);
        }
        public double total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Item)
            {
                sum += item.subTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder b1 = new StringBuilder();
            b1.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm"));
            b1.AppendLine("Order status: " + Status);
            b1.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate + ") - " + Client.Email);
            b1.AppendLine("Order items: ");
            foreach(OrderItem order in Item)
            {
                b1.AppendLine(order.Product + ", Quantity: " + order.Quantity + ", Subtotal: $" + order.subTotal());
            }
            b1.AppendLine("Total price:" + total().ToString("F2", CultureInfo.InvariantCulture));

            return b1.ToString();
        }
    }
}
