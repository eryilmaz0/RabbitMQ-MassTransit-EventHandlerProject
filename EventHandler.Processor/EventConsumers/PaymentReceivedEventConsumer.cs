using EventHandler.Processor.EventHandlerFactory;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Payment;
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
    public class PaymentReceivedEventConsumer : IConsumer<IEvent<PaymentReceivedEventInfo>>
    {
        public async Task Consume(ConsumeContext<IEvent<PaymentReceivedEventInfo>> context)
        {
            IEventSubscriptionManager _eventSubManager = new InMemoryEventSubscriptionManager();
            IList<IPaymentReceivedEventHandler> eventHandlers = _eventSubManager.GetSubscribedEventHandlersByPaymentReceivedEvent();

            //Her eventhandler için ProcessEvent methotunu çalıştır
            foreach (IPaymentReceivedEventHandler eventHandler in eventHandlers)
            {
                eventHandler.ProcessEvent(context.Message.EventInfo);
            }
        }
    }
}
