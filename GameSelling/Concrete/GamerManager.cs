using GameSelling.Abstract;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerValidateService _gamerValidateService;
        public GamerManager(IGamerValidateService gamerValidateService) {
            _gamerValidateService = gamerValidateService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerValidateService.Validate(gamer) == true)
            {
                Console.WriteLine("Player Added Successfully");
            }
            else
            {
                Console.WriteLine("The addition could not be made because the information was incorrect.");
            }
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("Deleted");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated");
        }
    }
}
