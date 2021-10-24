using EventHandler.Processor.EventHandlers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.SubscriptionManager
{
    public class RedisEventSubscriptionManager : IEventSubscriptionManager
    {

        public IList<INewProductInsertedEventHandler> GetSubscribedEventHandlersByNewProductInsertedEvent()
        {
            throw new NotImplementedException();
        }

        public IList<IOrderCreatedEventHandler> GetSubscribedEventHandlersByOrderCreatedEvent()
        {
            throw new NotImplementedException();
        }

        public IList<IPaymentReceivedEventHandler> GetSubscribedEventHandlersByPaymentReceivedEvent()
        {
            throw new NotImplementedException();
        }

        public IList<IProductAddedToBasketEventHandler> GetSubscribedEventHandlersByProductAddedToBasketEvent()
        {
            throw new NotImplementedException();
        }

        public void SubscribeEventHandlerForNewProductInsertedEvent(INewProductInsertedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public void SubscribeEventHandlerForOrderCreatedEvent(IOrderCreatedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public void SubscribeEventHandlerForPaymentReceivedEvent(IPaymentReceivedEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }

        public void SubscribeEventHandlerForProductAddedToBasketEvent(IProductAddedToBasketEventHandler eventHandler)
        {
            throw new NotImplementedException();
        }
    }
}
