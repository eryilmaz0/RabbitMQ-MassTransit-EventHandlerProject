using EventHandler.Processor.EventHandlers;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventHandlers.Basket;
using EventHandler.Processor.EventInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.SubscriptionManager
{
    public interface IEventSubscriptionManager
    {
        IList<IProductAddedToBasketEventHandler> GetSubscribedEventHandlersByProductAddedToBasketEvent();
        IList<INewProductInsertedEventHandler> GetSubscribedEventHandlersByNewProductInsertedEvent();
        IList<IPaymentReceivedEventHandler> GetSubscribedEventHandlersByPaymentReceivedEvent();
        IList<IOrderCreatedEventHandler> GetSubscribedEventHandlersByOrderCreatedEvent();

        void SubscribeEventHandlerForNewProductInsertedEvent(INewProductInsertedEventHandler eventHandler);
        void SubscribeEventHandlerForProductAddedToBasketEvent(IProductAddedToBasketEventHandler eventHandler);
        void SubscribeEventHandlerForPaymentReceivedEvent(IPaymentReceivedEventHandler eventHandler);
        void SubscribeEventHandlerForOrderCreatedEvent(IOrderCreatedEventHandler eventHandler);
    }
}
