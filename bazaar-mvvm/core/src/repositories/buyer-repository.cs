using System;
using System.Collections.Generic;
using Bazaar.Core.Entities;

namespace Bazaar.Core.Repositories
{
    public interface IBuyerRepository : IRepository<Buyer>
    {
        Buyer GetByUserName(string userName);
        List<Buyer> GetBuyersBeforeDate(DateTime cutoff);
    }
}