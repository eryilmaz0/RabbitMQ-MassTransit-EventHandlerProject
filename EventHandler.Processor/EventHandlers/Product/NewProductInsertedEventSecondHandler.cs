using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventInfoObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers.Product
{
    public class NewProductInsertedEventSecondHandler : INewProductInsertedEventHandler
    {
        public void ProcessEvent(NewProductInsertedEventInfo eventInfo)
        {
            //Eventi işliyoruz. Her Handler için değişebilir
            Console.WriteLine($"New Product Inserted Event Triggered. (2)");
            Console.WriteLine($"Product Id : {eventInfo.Id}");
            Console.WriteLine($"Product Name : {eventInfo.Name}");
            Console.WriteLine($"Product Category : {eventInfo.Category}");
            Console.WriteLine($"Product Price : {eventInfo.Price}");
            Console.WriteLine("************************************************************************************************");
        }
    }
}
