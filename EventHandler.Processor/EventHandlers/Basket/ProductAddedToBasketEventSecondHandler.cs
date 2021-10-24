using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Basket
{
    public class ProductAddedToBasketEventSecondHandler : IProductAddedToBasketEventHandler
    {
        public void ProcessEvent(ProductAddedToBasketEventInfo eventInfo)
        {
            //Eventi işliyoruz. Her Handler için değişebilir
            Console.WriteLine($"Product Added To Basket Event Triggered. (2)");
            Console.WriteLine($"Basket Id : {eventInfo.BasketId}");
            Console.WriteLine($"Product Id : {eventInfo.Id}");
            Console.WriteLine($"Product Name : {eventInfo.Name}");
            Console.WriteLine($"Product Category : {eventInfo.Category}");
            Console.WriteLine($"Product Price : {eventInfo.Price}");
            Console.WriteLine("************************************************************************************************");
        }
    }
}
