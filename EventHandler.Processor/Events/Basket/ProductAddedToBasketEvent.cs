using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.Events
{
    public class ProductAddedToBasketEvent : Event<ProductAddedToBasketEventInfo>
    {

    }
}
