using EventHandler.Processor;
using EventHandler.Processor.Constants;
using EventHandler.Processor.EventInfoObjects.Payment;
using EventHandler.Processor.Events.Payment;
using EventHandler.Processor.MessageContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventHandler.Payment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Payment(PaymentOptions paymentOptions)
        {
            PaymentReceivedEventInfo eventInfo = new()
            {
                CardNumber = paymentOptions.CardNumber,
                Amount = paymentOptions.Amount,
                PaymentDate = DateTime.Now,
                UserId = paymentOptions.UserId
            };

            PaymentReceivedEvent paymentReceivedEvent = new() { EventInfo = eventInfo };
            var bus = BusConfigurator.ConfigureBus();
            var sendToUri = new Uri($"{RabbitMQConstants.RabbitMqUri}{RabbitMQConstants.PaymentReceivedEventServiceQueue}");
            var endPoint = await bus.GetSendEndpoint(sendToUri);
            await endPoint.Send<IEvent<PaymentReceivedEventInfo>>(paymentReceivedEvent);
            return Ok("Ödeme İşlemi Tamamlandı.");
        }
    }
}
