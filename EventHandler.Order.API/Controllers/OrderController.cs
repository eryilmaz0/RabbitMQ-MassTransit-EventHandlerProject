using EventHandler.Processor;
using EventHandler.Processor.Constants;
using EventHandler.Processor.EventInfoObjects.Order;
using EventHandler.Processor.Events.Order;
using EventHandler.Processor.MessageContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateOrder(CreateOrderRequest request)
        {
            OrderCreatedEventInfo eventInfo = new()
            {
                Amount = request.Amount,
                UserId = request.UserId,
                CreatedDate = DateTime.Now,
                OrderId = Guid.NewGuid().ToString()
            };

            OrderCreatedEvent orderCreatedEvent = new() { EventInfo = eventInfo };
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.RabbitMqUri}{RabbitMQConstants.OrderCreatedEventServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IEvent<OrderCreatedEventInfo>>(orderCreatedEvent);
            return Ok("Sipariş Oluşturuldu.");

        }
    }
}
