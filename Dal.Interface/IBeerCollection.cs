﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Dal.Interface
{
    public interface IBeerCollection
    {
        public List<BeerDTO> GetAllBeerInfo();
        public List<BeernameDTO> GetAllBeer(string name);
        public bool AddBeer(BeerDTO beers);
        public bool RemoveBeer(int id);
    }
}
