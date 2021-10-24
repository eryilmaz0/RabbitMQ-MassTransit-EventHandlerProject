using EventHandler.Processor.EventHandlerFactory;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Product;
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
    public class NewProductInsertedEventConsumer : IConsumer<IEvent<NewProductInsertedEventInfo>>
    {
        public async Task Consume(ConsumeContext<IEvent<NewProductInsertedEventInfo>> context)
        {
            IEventSubscriptionManager _eventSubManager = new InMemoryEventSubscriptionManager();
            IList<INewProductInsertedEventHandler> eventHandlers = _eventSubManager.GetSubscribedEventHandlersByNewProductInsertedEvent();

            //Her eventhandler için ProcessEvent methotunu çalıştır
            foreach (INewProductInsertedEventHandler eventHandler in eventHandlers)
            {
                eventHandler.ProcessEvent(context.Message.EventInfo);
            }
        }
    }
}
