using System.Collections.Generic;
using Bazaar.Core.Entities;

namespace Bazaar.Core.Repositories
{
    public interface IOrderRepository : IRepository<Order> 
    { 
        List<Order> GetOrdersOverAmount(decimal amount);
        List<Order> GetOrdersForBuyer(Buyer buyer);
    }
}