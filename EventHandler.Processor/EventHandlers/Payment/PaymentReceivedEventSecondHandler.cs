using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Payment
{
    public class PaymentReceivedEventSecondHandler : IPaymentReceivedEventHandler
    
    {
        public void ProcessEvent(PaymentReceivedEventInfo eventInfo)
        {
            //Eventi işliyoruz. Her Handler için değişebilir
            Console.WriteLine($"Payment Received Event Triggered. (2)");
            Console.WriteLine($"User Id : {eventInfo.UserId}");
            Console.WriteLine($"Product Amount : {eventInfo.Amount}");
            Console.WriteLine($"Card Number : {eventInfo.CardNumber}");
            Console.WriteLine($"Payment Date : {eventInfo.PaymentDate.ToString("dd'/'MM'/'yyyy")}");
            Console.WriteLine("************************************************************************************************");
        }
    }
}
