using EventHandler.Processor.EventHandlers;
using EventHandler.Processor.EventHandlers.Abstract;
using EventHandler.Processor.EventHandlers.Basket;
using EventHandler.Processor.EventHandlers.Order;
using EventHandler.Processor.EventHandlers.Payment;
using EventHandler.Processor.EventHandlers.Product;
using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.SubscriptionManager
{
    public static class InMemoryEventHandlerSubscriptionsRepository
    {
        private static IList<IProductAddedToBasketEventHandler> _productAddedToBasketEventHandlers;
        private static IList<INewProductInsertedEventHandler> _newProductInsertedEventHandlers;
        private static IList<IPaymentReceivedEventHandler> _paymentReceivedEventHandlers;
        private static IList<IOrderCreatedEventHandler> _orderCreatedEventHandlers;


        static InMemoryEventHandlerSubscriptionsRepository()
        {
            LoadDefaultEventSubscriptions();
        }


        #region IProductAddedToBasketEventHandler Getter-Setter

        public static IList<IProductAddedToBasketEventHandler> GetSubscribedProductAddedToBasketEventHandlers()
        {
            return _productAddedToBasketEventHandlers;
        }


        public static void SubscribeEventHandlerForProductAddedToBasketEvent(IProductAddedToBasketEventHandler eventHandler)
        {
            _productAddedToBasketEventHandlers.Add(eventHandler);
        }

        #endregion


        #region INewProductInsertedEventHandler Getter-Setter

        public static IList<INewProductInsertedEventHandler> GetSubscribedNewProductInsertedEventHandlers()
        {
            return _newProductInsertedEventHandlers;
        }


        public static void SubscribeEventHandlerForNewProductInsertedEvent(INewProductInsertedEventHandler eventHandler)
        {
            _newProductInsertedEventHandlers.Add(eventHandler);
        }

        #endregion


        #region IPaymentReceivedEventHandler Getter-Setter

        public static IList<IPaymentReceivedEventHandler> GetSubscribedPaymentReceivedEventHandlers()
        {
            return _paymentReceivedEventHandlers;
        }


        public static void SubscribeEventHandlerFoPaymentReceivedEvent(IPaymentReceivedEventHandler eventHandler)
        {
            _paymentReceivedEventHandlers.Add(eventHandler);
        }

        #endregion


        #region IOrderCreatedEventHandler Getter-Setter

        public static IList<IOrderCreatedEventHandler> GetSubscribedOrderCreatedEventHandlers()
        {
            return _orderCreatedEventHandlers;
        }


        public static void SubscribeEventHandlerFoOrderCreatedEvent(IOrderCreatedEventHandler eventHandler)
        {
            _orderCreatedEventHandlers.Add(eventHandler);
        }

        #endregion


        private static void LoadDefaultEventSubscriptions()
        {

            IList<IProductAddedToBasketEventHandler> productAddedToBasketEventHandlers = new List<IProductAddedToBasketEventHandler>()
            {
                new ProductAddedToBasketEventHandler(),
                new ProductAddedToBasketEventSecondHandler()
            };


            IList<INewProductInsertedEventHandler> newProductInsertedEventHandlers = new List<INewProductInsertedEventHandler>()
            {
                new NewProductInsertedEventHandler(),
                new NewProductInsertedEventSecondHandler()
            };


            IList<IPaymentReceivedEventHandler> paymentReceivedEventHandlers = new List<IPaymentReceivedEventHandler>()
            {
                new PaymentReceivedEventHandler(),
                new PaymentReceivedEventSecondHandler()
            };


            IList<IOrderCreatedEventHandler> orderCreatedEventHandlers = new List<IOrderCreatedEventHandler>()
            {
                new OrderCreatedEventHandler(),
                new OrderCreatedEventSecondHandler()
            };

            _productAddedToBasketEventHandlers = productAddedToBasketEventHandlers;
            _newProductInsertedEventHandlers = newProductInsertedEventHandlers;
            _paymentReceivedEventHandlers = paymentReceivedEventHandlers;
            _orderCreatedEventHandlers = orderCreatedEventHandlers;
            
        }
    }
}
