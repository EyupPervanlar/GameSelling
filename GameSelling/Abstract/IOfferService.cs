using GameSelling.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSelling.Abstract
{
    public interface IOfferService
    {
        void Add(Offer offer);
        void Delete(Offer offer);
        void Update(Offer offer);
    }
}
