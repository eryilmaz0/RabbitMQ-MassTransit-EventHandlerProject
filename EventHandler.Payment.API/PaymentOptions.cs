using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Payment.API
{
    public class PaymentOptions
    {
        public int UserId { get; set; }
        public string CardNumber { get; set; }
        public string CardDate { get; set; }
        public string SecurityCode { get; set; }
        public decimal Amount { get; set; }
    }
}
