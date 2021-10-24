using EventHandler.Processor.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventInfoObjects
{
    public class ProductAddedToBasketEventInfo : IEventInfoObject
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
