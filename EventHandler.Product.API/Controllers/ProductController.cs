using EventHandler.Processor;
using EventHandler.Processor.Constants;
using EventHandler.Processor.EventInfoObjects.Product;
using EventHandler.Processor.Events.Product;
using EventHandler.Processor.MessageContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> InsertProduct(Product product)
        {
            NewProductInsertedEventInfo eventInfo = new()
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Price = product.Price
            };

            NewProductInsertedEvent newProductInsertedEvent = new() { EventInfo = eventInfo };
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.RabbitMqUri}{RabbitMQConstants.NewProductInsertedEventServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IEvent<NewProductInsertedEventInfo>>(newProductInsertedEvent);
            return Ok("Yeni Ürün Eklendi.");
        }
    }
}
