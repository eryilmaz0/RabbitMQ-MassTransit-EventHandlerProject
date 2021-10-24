using EventHandler.Processor.EventInfoObjects.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Abstract
{
    public interface IPaymentReceivedEventHandler : IEventHandler<PaymentReceivedEventInfo>
    {
    }
}
