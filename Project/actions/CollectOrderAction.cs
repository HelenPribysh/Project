using Project.orders;
using System;
using System.Collections.Generic;
using System.Text;
using Project.enums;
using Project.storage;
using Project.techniques;
using System.Linq;

namespace Project.actions
{
    class CollectOrderAction : IAction
    {
        private Order _order;
        private Storage _storage;

        public CollectOrderAction(Order order, Storage storage)
        {
            _order = order;
            _storage = storage;
        }

        internal Order Order { get => _order; }

        public void Action()
        {
            CollectOrder();
        }

        private void CollectOrder()
        {
            _order.OrderStatus = OrderStatus.Collecting;
            Console.WriteLine("Your order is collecting");
            int count = -100;
            while (true)
            {
                if (count == 1000000000)
                    break;
                else
                    count++;
            }            
            _order.OrderStatus = OrderStatus.Collected;
            Console.WriteLine("Your order is collected");
            DecreaseNumberOfTechniquesAtStorage();
        }

        private void DecreaseNumberOfTechniquesAtStorage()
        {
            List<Technique> orderedTechniques = _order.Techniques;
            foreach (Technique ordTech in orderedTechniques)
            {
                foreach (Technique storeTech in _storage.ModelStore.Where(tech => tech.Type == ordTech.Type).ToList<Technique>())
                {
                    if (ordTech.Model.Equals(storeTech.Model))
                    {
                        storeTech.Quantity--;
                    }
                }
            }
        }
    }
}
