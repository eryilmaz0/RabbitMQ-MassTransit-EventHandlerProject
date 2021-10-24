using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.Constants
{
    public static class RabbitMQConstants
    {
        public static string RabbitMqUri = "rabbitmq://localhost/MassTransitEventHandler/";
        public static string UserName = "guest";
        public static string Password = "guest";
        public const string NewProductInsertedEventServiceQueue = "event-service-new-product-inserted";
        public const string ProductAddedTBasketEventServiceQueue = "event-service-product-added-to-basket";
        public const string PaymentReceivedEventServiceQueue = "event-service-payment-received";
        public const string OrderCreatedEventServiceQueue = "event-service-order-created";
    }
}
