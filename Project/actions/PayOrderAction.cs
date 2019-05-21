using Project.enums;
using Project.orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.actions
{
    class PayOrderAction : IAction
    {
        Order _order;

        public PayOrderAction(Order order)
        {
            _order = order;
        }

        internal Order Order { get => _order; }

        public void Action()
        {
            PayOrder();
        }

        private void PayOrder()
        {
            _order.OrderStatus = OrderStatus.Paid;
            Console.WriteLine("Your order is paid. Thank you for buying in our shop");
        }
    }
}
