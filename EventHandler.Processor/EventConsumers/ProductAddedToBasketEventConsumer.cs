using EventHandler.Processor.EventHandlerFactory;
using EventHandler.Processor.EventHandlers;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.Events;
using EventHandler.Processor.MessageContracts;
using EventHandler.Processor.SubscriptionManager;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventHandler.Processor
{
    public class ProductAddedToBasketEventConsumer : IConsumer<IEvent<ProductAddedToBasketEventInfo>>
    {
        public async Task Consume(ConsumeContext<IEvent<ProductAddedToBasketEventInfo>> context)
        {
            IEventSubscriptionManager _eventSubManager = new InMemoryEventSubscriptionManager();
            IList<IProductAddedToBasketEventHandler> eventHandlers = _eventSubManager.GetSubscribedEventHandlersByProductAddedToBasketEvent();

            //Her eventhandler için ProcessEvent methotunu çalıştır
            foreach (IProductAddedToBasketEventHandler eventHandler in eventHandlers)
            {
                eventHandler.ProcessEvent(context.Message.EventInfo);
            }
        }

        
        
    }
}
