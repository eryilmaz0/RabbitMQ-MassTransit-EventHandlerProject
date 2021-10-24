using EventHandler.Processor.EventInfoObjects.Order;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.Events.Order
{
    public class OrderCreatedEvent : Event<OrderCreatedEventInfo>
    {
    }
}
