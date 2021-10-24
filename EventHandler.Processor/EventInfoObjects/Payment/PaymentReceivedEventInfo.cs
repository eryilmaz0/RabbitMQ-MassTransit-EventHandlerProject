using EventHandler.Processor.Events.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventInfoObjects.Payment
{
    public class PaymentReceivedEventInfo : IEventInfoObject
    {
        public int UserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string CardNumber { get; set; }
    }
}
