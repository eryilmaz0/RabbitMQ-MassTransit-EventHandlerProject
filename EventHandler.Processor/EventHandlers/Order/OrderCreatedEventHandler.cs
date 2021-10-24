using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Order;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Order
{
    public class OrderCreatedEventHandler : IOrderCreatedEventHandler
    {
        public void ProcessEvent(OrderCreatedEventInfo eventInfo)
        {
 
            //Eventi işliyoruz. Her Handler için değişebilir
            Console.WriteLine($"Order Created Event Triggered.");
            Console.WriteLine($"Order Id : {eventInfo.OrderId}");
            Console.WriteLine($"User Id : {eventInfo.UserId}");
            Console.WriteLine($"Product Amount : {eventInfo.Amount}");
            Console.WriteLine($"Product Created : {eventInfo.CreatedDate.ToString("dd'/'MM'/'yyyy")}");
            Console.WriteLine("************************************************************************************************");
        }
    }
}
