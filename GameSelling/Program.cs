using GameSelling.Abstract;
using GameSelling.Concrete;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
           GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            SaleManager saleManager = new SaleManager(gamerManager);
            OfferManager offerManager = new OfferManager();
            Gamer gamer1 = new Gamer {
                GamerId = 1,
           GamerName = "Eyüp",
           GamerLastName = "Pervanlar",
           GamerTcNumber = 12345678910,
            GamerDateOfBirth = 2002 };
            Game game1 = new Game
            {
                GameId = 1,
                GameName = "Counter Strike 2",
                GamePrice = 200
            };
            Sale sale = new Sale {
                Id = 1,
                Game = game1,
                Gamer = gamer1,
                SaleDate = DateTime.Now
            
            };
            Offer offer1 = new Offer
            {
                Id = 1,
                DiscountRate = "%25",
                Name = "Counter Strike 2"
            };
            gamerManager.Add(gamer1);
            gameManager.Add(game1);
            offerManager.Add(offer1);
            saleManager.Add(sale);
            Console.ReadLine();
          
        }
    }
}
