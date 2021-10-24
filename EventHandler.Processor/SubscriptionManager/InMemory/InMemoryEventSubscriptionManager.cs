using EventHandler.Processor.EventHandlers;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.SubscriptionManager
{
    public class InMemoryEventSubscriptionManager : IEventSubscriptionManager
    {

        public IList<INewProductInsertedEventHandler> GetSubscribedEventHandlersByNewProductInsertedEvent()
        {
            return InMemoryEventHandlerSubscriptionsRepository.GetSubscribedNewProductInsertedEventHandlers();
        }


        public IList<IOrderCreatedEventHandler> GetSubscribedEventHandlersByOrderCreatedEvent()
        {
            return InMemoryEventHandlerSubscriptionsRepository.GetSubscribedOrderCreatedEventHandlers();
        }


        public IList<IPaymentReceivedEventHandler> GetSubscribedEventHandlersByPaymentReceivedEvent()
        {
            return InMemoryEventHandlerSubscriptionsRepository.GetSubscribedPaymentReceivedEventHandlers();
        }


        public IList<IProductAddedToBasketEventHandler> GetSubscribedEventHandlersByProductAddedToBasketEvent()
        {
            return InMemoryEventHandlerSubscriptionsRepository.GetSubscribedProductAddedToBasketEventHandlers();
        }



        public void SubscribeEventHandlerForNewProductInsertedEvent(INewProductInsertedEventHandler eventHandler)
        {
            InMemoryEventHandlerSubscriptionsRepository.SubscribeEventHandlerForNewProductInsertedEvent(eventHandler);
        }



        public void SubscribeEventHandlerForProductAddedToBasketEvent(IProductAddedToBasketEventHandler eventHandler)
        {
            InMemoryEventHandlerSubscriptionsRepository.SubscribeEventHandlerForProductAddedToBasketEvent(eventHandler);
        }



        public void SubscribeEventHandlerForPaymentReceivedEvent(IPaymentReceivedEventHandler eventHandler)
        {
            InMemoryEventHandlerSubscriptionsRepository.SubscribeEventHandlerFoPaymentReceivedEvent(eventHandler);
        }



        public void SubscribeEventHandlerForOrderCreatedEvent(IOrderCreatedEventHandler eventHandler)
        {
            InMemoryEventHandlerSubscriptionsRepository.SubscribeEventHandlerFoOrderCreatedEvent(eventHandler);
        }
    }
}
