using EventHandler.Processor.EventHandlers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlerFactory
{
    public interface IEventHandlerFactoryClient
    {
        IProductAddedToBasketEventHandler GetProductAddedToBasketEventHandler();
        INewProductInsertedEventHandler GetNewProductInsertedEventHandler();
        IPaymentReceivedEventHandler GetPaymentReceivedEventHandler();
        IOrderCreatedEventHandler GetOrderCreatedEventHandler();
    }
}
