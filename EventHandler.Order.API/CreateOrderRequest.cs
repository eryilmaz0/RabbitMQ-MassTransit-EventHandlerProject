using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Order.API
{
    public class CreateOrderRequest
    {
        public int UserId { get; set; }
        public decimal Amount { get; set; }
    }
}
