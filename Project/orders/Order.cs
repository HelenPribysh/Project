using Project.enums;
using Project.techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.orders
{
    class Order
    {
        private string _clientName;
        private List<Technique> _techniques;
        private string _clientAddress;
        private OrderStatus _orderStatus;

        public Order()
        {
            _orderStatus = OrderStatus.OnReview;
            _techniques = new List<Technique>();
        }

        public string ClientName { get => _clientName; set => _clientName = value; }
        public string ClientAddress { get => _clientAddress; set => _clientAddress = value; }
        internal List<Technique> Techniques { get => _techniques; set => _techniques = value; }
        internal OrderStatus OrderStatus { get => _orderStatus; set => _orderStatus = value; }

        public void AddModel(Technique technique)
        {
            _techniques.Add(technique);
        }
    }
}
