using System.Collections.Generic;
using Dal.Factory;
using Dal.Interface;

namespace Logic
{
    public class Beer
    {
        private readonly List<Beer> _Beer = new List<Beer>();
        private readonly IBeer _dal;

        public Beer()
        {
            _dal = BeerFactory.CreateBeerDal();
        }


    }
}
