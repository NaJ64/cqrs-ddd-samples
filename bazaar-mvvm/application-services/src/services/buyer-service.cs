using System.Collections.Generic;
using System.Linq;
using Bazaar.ApplicationServices.ViewModels;
using Bazaar.Core.Entities;
using Bazaar.Core.Repositories;

namespace Bazaar.ApplicationServices 
{

    public class UpdateTopBuyersCommand
    {
        int Increment { get; set; }
    }

    public interface IUpdateTopBuyersCommandHandler
    {
        void Handle(UpdateTopBuyersCommand command);
    }

    public interface IBuyerQueries
    {
        List<BuyerViewModel> GetTopBuyers();
    }


    // public interface IBuyerService 
    // {
    //     void UpdateTopBuyers();
    //     List<BuyerViewModel> GetTopBuyers();
    // }

    // public class BuyerService
    // {
    //     public IBuyerRepository BuyerRepository { get; set; }

    //     public void UpdateTopBuyers() 
    //     {
    //         var buyers = BuyerRepository.GetAll();
    //         BuyerRepository.DoTransaction(() => 
    //         {
    //             while (!buyers.Any(x => x.BuyerScore >= 5)) 
    //             {
    //                 foreach(var buyer in buyers) 
    //                 {
    //                     buyer.BuyerScore += 1;
    //                     BuyerRepository.Update(buyer);
    //                 }
    //             }
    //         });
    //     }

    //     public List<BuyerViewModel> GetTopBuyers()
    //     {
    //         var buyers = BuyerRepository.GetAll();
    //         return buyers.Where(x => x.BuyerScore >= 5).Select(x => x.MapTo<BuyerViewModel>()).ToList();
    //     }
    // }
}
