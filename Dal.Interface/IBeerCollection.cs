using System;
using System.Collections.Generic;
using System.Text;

namespace Dal.Interface
{
    public interface IBeerCollection
    {
        public List<BeerDTO> GetAllBeerInfo();
        public List<BeernameDTO> GetAllBeer(string name);
        public void AddBeer(BeerDTO beers);
        public void RemoveBeer(BeerDTO beers);
    }
}
