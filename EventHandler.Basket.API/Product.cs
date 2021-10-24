using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Basket.API
{
    public class Product
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
