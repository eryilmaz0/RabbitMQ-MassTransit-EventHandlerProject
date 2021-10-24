using EventHandler.Processor.Constants;
using MassTransit;
using System;
using System.Threading.Tasks;

namespace EventHandler.Processor
{
    class Program
    {
        static async Task Main(string[] args)
        {
         
            var bus = BusConfigurator.ConfigureBus(factory =>
            {

                factory.ReceiveEndpoint(RabbitMQConstants.ProductAddedTBasketEventServiceQueue, endPoint =>
                {
                    endPoint.Consumer<ProductAddedToBasketEventConsumer>();
                });


                factory.ReceiveEndpoint(RabbitMQConstants.NewProductInsertedEventServiceQueue, endPoint =>
                {
                    endPoint.Consumer<NewProductInsertedEventConsumer>();
                });


                factory.ReceiveEndpoint(RabbitMQConstants.PaymentReceivedEventServiceQueue, endPoint =>
                {
                    endPoint.Consumer<PaymentReceivedEventConsumer>();
                });


                factory.ReceiveEndpoint(RabbitMQConstants.OrderCreatedEventServiceQueue, endPoint =>
                {
                    endPoint.Consumer<OrderCreatedEventConsumer>();
                });

            });

            await bus.StartAsync();
            await Task.Run(() => Console.ReadLine());
            await bus.StopAsync();
        }
    }
}
