using System;
using System.Collections.Generic;
using System.Linq;
using Bazaar.Core.Entities;
using Bazaar.Core.Repositories;
using Bazaar.ApplicationServices.Mapping;
using Bazaar.ApplicationServices.ViewModels;

namespace Bazaar.ApplicationServices 
{
    public interface IOrderService 
    { 
        OrderViewModel GetOrder(int id);
        OrderViewModel GetLastOrderForBuyer(int buyerId);
    }

    public class OrderService : IOrderService 
    {
        public IOrderRepository OrderRepository { get; set; }
        public IBuyerRepository BuyerRepository { get; set; }

        public OrderViewModel GetOrder(int id) 
        {
            return OrderRepository.FindById(id).MapTo<OrderViewModel>();
        }

        public OrderViewModel GetLastOrderForBuyer(int buyerId)
        {
            return OrderRepository.DoTransaction(() => 
            {
                var buyer = BuyerRepository.FindById(buyerId);
                var orders = OrderRepository.GetOrdersForBuyer(buyer);
                return orders.LastOrDefault()?.MapTo<OrderViewModel>();
            });
        }
    }
}