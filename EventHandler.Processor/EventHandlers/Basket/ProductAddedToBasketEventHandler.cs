using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.Events;
using EventHandler.Processor.Exception;
using EventHandler.Processor.MessageContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Basket
{
    public class ProductAddedToBasketEventHandler : IProductAddedToBasketEventHandler
    {
        public void ProcessEvent(ProductAddedToBasketEventInfo eventInfo)
        {
            //Eventi işliyoruz. Her Handler için değişebilir
            Console.WriteLine($"Product Added To Basket Event Triggered.");
            Console.WriteLine($"Basket Id : {eventInfo.BasketId}");
            Console.WriteLine($"Product Id : {eventInfo.Id}");
            Console.WriteLine($"Product Name : {eventInfo.Name}");
            Console.WriteLine($"Product Category : {eventInfo.Category}");
            Console.WriteLine($"Product Price : {eventInfo.Price}");
            Console.WriteLine("************************************************************************************************");
        }
    }
}
