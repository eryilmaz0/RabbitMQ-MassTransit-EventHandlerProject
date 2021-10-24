using EventHandler.Processor.EventHandlerFactory;
using EventHandler.Processor.EventHandlers;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventHandlers.Basket;
using EventHandler.Processor.EventHandlers.Order;
using EventHandler.Processor.EventHandlers.Payment;
using EventHandler.Processor.EventHandlers.Product;
using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.Events;
using EventHandler.Processor.Events.Order;
using EventHandler.Processor.Events.Payment;
using EventHandler.Processor.Events.Product;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor
{
    public class EventHandlerFactoryClient : IEventHandlerFactoryClient
    {
        //public static IEventHandler GetEventHandler(Type handlerType) 
        //{
        //    IEventHandler eventHandler = null;
        //    string eventTypeName = handlerType.Name;

        //    switch (eventTypeName)
        //    {
        //        case nameof(ProductAddedToBasketEvent):
        //        eventHandler = new ProductAddedToBasketEventHandler();
        //        break;

        //        case nameof(PaymentReceivedEvent):
        //            eventHandler = new PaymentReceivedEventHandler();
        //        break;

        //        case nameof(OrderCreatedEvent):
        //            eventHandler = new OrderCreatedEventHandler();
        //        break;

        //        case nameof(NewProductInsertedEvent):
        //            eventHandler = new NewProductInsertedEventHandler();
        //        break;

        //        default:
        //        throw new SystemException(); 
        //    }

        //    return eventHandler;
        //}


        public INewProductInsertedEventHandler GetNewProductInsertedEventHandler()
        {
            return new NewProductInsertedEventHandler();
        }

        public IOrderCreatedEventHandler GetOrderCreatedEventHandler()
        {
            return new OrderCreatedEventHandler();
        }

        public IPaymentReceivedEventHandler GetPaymentReceivedEventHandler()
        {
            return new PaymentReceivedEventHandler();
        }

        public IProductAddedToBasketEventHandler GetProductAddedToBasketEventHandler()
        {
            return new ProductAddedToBasketEventHandler();
        }
    }

}
