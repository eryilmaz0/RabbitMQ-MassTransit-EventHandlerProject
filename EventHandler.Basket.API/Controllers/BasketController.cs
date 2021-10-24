using EventHandler.Processor;
using EventHandler.Processor.Constants;
using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.Events;
using EventHandler.Processor.MessageContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Basket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddProductToBasket(Product product)
        {
            ProductAddedToBasketEventInfo eventInfo = new()
            {
                Id = product.Id,
                BasketId = product.BasketId,
                Name = product.Name,
                Category = product.Category,
                Price = product.Price
            };

            ProductAddedToBasketEvent productAddedToBasketEvent = new() { EventInfo = eventInfo };
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.RabbitMqUri}{RabbitMQConstants.ProductAddedTBasketEventServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<Event<ProductAddedToBasketEventInfo>>(productAddedToBasketEvent);
            return Ok("Ürün Sepete Eklendi.");
        }
    }
}
