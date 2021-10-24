using EventHandler.Processor.EventInfoObjects.Product;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.Events.Product
{
    public class NewProductInsertedEvent : Event<NewProductInsertedEventInfo>
    {
    }
}
