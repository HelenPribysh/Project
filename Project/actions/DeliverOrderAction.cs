using Project.enums;
using Project.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.actions
{
    class DeliverOrderAction : IAction
    {
        Order _order;

        public DeliverOrderAction(Order order)
        {
            _order = order;
        }

        internal Order Order { get => _order; }

        public void Action()
        {
            DeliveOrder();
        }

        private void DeliveOrder()
        {
            _order.OrderStatus = OrderStatus.OnWay;
            Console.WriteLine("Your order is on way");
            int count = -100;
            while (true)
            {
                if (count == 10000)
                    break;
                else
                    count++;
            }
            _order.OrderStatus = OrderStatus.Delivered;
            Console.WriteLine("Your order is delievered");
        }
    }
}
