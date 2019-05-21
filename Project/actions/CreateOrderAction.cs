using Project.enums;
using Project.orders;
using Project.storage;
using Project.techniques;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.actions
{
    class CreateOrderAction : IAction
    {
        Storage _storage;
        Order _order;

        public CreateOrderAction(Storage storage)
        {
            _storage = storage;
            _order = new Order();
        }

        internal Order Order { get => _order; }

        public void Action()
        {
            CreateOrder();
        }

        private void CreateOrder()
        {
            Console.WriteLine("Name");
            _order.ClientName = Console.ReadLine();

            Console.WriteLine("What do you want to buy? We have next techniques: ");
            foreach (TechniqueType type in _storage.AvailableTypes)
            {
                Console.WriteLine(type);
            }

            TechniqueType choosedTechniqueType = 
                (TechniqueType)Enum.Parse(typeof(TechniqueType),Console.ReadLine().ToUpper());
            List<Technique> choosedTechniqueTypes = _storage.GetTechniqueType(choosedTechniqueType);
            foreach (Technique technique in choosedTechniqueTypes)
            {
                Console.WriteLine(technique.Model);
            }

            Console.WriteLine("Choose what you want");
            string choosedTechniqueModel = Console.ReadLine();
            _order.AddModel(GetTechniqueByModel(choosedTechniqueModel, choosedTechniqueTypes));

            Console.WriteLine("Type your address");
            _order.ClientAddress = Console.ReadLine();
            _order.OrderStatus = OrderStatus.Accepted;
        }

        private Technique GetTechniqueByModel(string model, List<Technique> choosedTechniqueTypes)
        {
            foreach (Technique choosedTechniqueModel in choosedTechniqueTypes)
            {
                if (string.Equals(model, choosedTechniqueModel.Model))
                {
                    switch (choosedTechniqueModel.Type)
                    {
                        case TechniqueType.NOTEBOOK:
                            return new Notebook(model);
                        case TechniqueType.SMARTPHONE:
                            return new Smartphone(model);
                    }
                }
            }
            return null;
        }
    }
}
