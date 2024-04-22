using GameSelling.Abstract;
using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Concrete
{
    public class OfferManager : IOfferService
    {

        public void Add(Offer offer)
        {
            Console.WriteLine("Offer is Successfully Added");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine("Offer is Successfully Deleted");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine("Offer is Successfully Updated");
        }
    }
}
