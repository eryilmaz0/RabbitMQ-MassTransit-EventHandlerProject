using EventHandler.Processor.EventHandlerFactory;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Order;
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
    public class OrderCreatedEventConsumer : IConsumer<IEvent<OrderCreatedEventInfo>>
    {
        public async Task Consume(ConsumeContext<IEvent<OrderCreatedEventInfo>> context)
        {
            IEventSubscriptionManager _eventSubManager = new InMemoryEventSubscriptionManager();
            IList<IOrderCreatedEventHandler> eventHandlers = _eventSubManager.GetSubscribedEventHandlersByOrderCreatedEvent();

            //Her eventhandler için ProcessEvent methotunu çalıştır
            foreach (IOrderCreatedEventHandler eventHandler in eventHandlers)
            {
                eventHandler.ProcessEvent(context.Message.EventInfo);
            }
        }
    }
}
