using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Entites
{
    public class Sale
    {
        public int Id{ get; set; }
        public Gamer Gamer { get; set; }
        public Game Game { get; set; }
        public double Price { get { return Game.GamePrice; } }
        public DateTime SaleDate { get; set; }
    }
}
