using GameSelling.Abstract;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GamerValidationManager:IGamerValidateService
    {
     
    
        public bool Validate(Gamer gamer) {

            if (gamer.GamerId == 1 && gamer.GamerName == "Eyüp" && gamer.GamerLastName == "Pervanlar" && gamer.GamerTcNumber == 12345678910 && gamer.GamerDateOfBirth == 2002)
            {
                Console.WriteLine("The user has been successfully authenticated.");
                return true;
            }
            else
            {
                Console.WriteLine("Information is Incorrect.");
                return false;
            }
        }
    }
}
