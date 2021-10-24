using EventHandler.Processor.Events.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventInfoObjects.Order
{
    public class OrderCreatedEventInfo : IEventInfoObject
    {
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
