using EventHandler.Processor.EventInfoObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Abstract
{
    public interface INewProductInsertedEventHandler : IEventHandler<NewProductInsertedEventInfo>
    {  
    }
}
