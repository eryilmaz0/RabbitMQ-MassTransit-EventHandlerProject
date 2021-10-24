using EventHandler.Processor.EventInfoObjects.Payment;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.Events.Payment
{
    public class PaymentReceivedEvent : Event<PaymentReceivedEventInfo>
    {
    }
}
