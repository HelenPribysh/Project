using Project.actions;
using Project.orders;
using Project.storage;
using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.InitStorage();

            CreateOrderAction createOrderAction = new CreateOrderAction(storage);
            createOrderAction.Action();
            Order createdOrder = createOrderAction.Order;

            CollectOrderAction collectOrderAction = new CollectOrderAction(createdOrder, storage);
            collectOrderAction.Action();
            Order collectedOrder = collectOrderAction.Order;

            DeliverOrderAction deliverOrderAction = new DeliverOrderAction(collectedOrder);
            deliverOrderAction.Action();
            Order deliveredOrder = deliverOrderAction.Order;

            PayOrderAction payOrderAction = new PayOrderAction(deliveredOrder);
            payOrderAction.Action();
        }
    }
}
