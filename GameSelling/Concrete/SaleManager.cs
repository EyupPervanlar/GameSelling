using GameSelling.Abstract;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class SaleManager : ISaleService
    {
        IOfferService _offerService;
        public SaleManager(IOfferService offerService)
        {
            _offerService = offerService;
        }
        IGamerService _gamerService;
        public SaleManager(IGamerService gamerService) {
        _gamerService = gamerService;
        }
       
        public void Add(Sale sale)
        {
            Console.WriteLine(sale.Gamer.GamerName+" "+sale.Gamer.GamerLastName+" bought "+sale.Game.GameName+" for "+ sale.Price+" Tl "+sale.SaleDate+". ");
        }

        public void Delete(Sale sale)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Sale sale)
        {
            Console.WriteLine("Updated");
        }
    }
}
