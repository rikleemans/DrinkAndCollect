using System;
using System.Collections.Generic;
using System.Text;
using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    public class BeerCollection
    {
        private readonly IBeerCollection _dal;

        public BeerCollection()
        {
            _dal = BeerCollectionFactory.CreateBeerCollectionDal();
        }
    }
}
