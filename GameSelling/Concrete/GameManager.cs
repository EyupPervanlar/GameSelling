using GameSelling.Abstract;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Game is Added "+game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Game is Deleted");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Game is Updated");
        }
    }
}
