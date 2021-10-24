using EventHandler.Processor.EventInfoObjects.Order;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Abstract
{
    public interface IOrderCreatedEventHandler : IEventHandler<OrderCreatedEventInfo>
    {
    }
}
