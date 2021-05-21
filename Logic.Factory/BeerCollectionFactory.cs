using Logic.Interface;
using System;
using Logic;

namespace Logic.Factory
{
    public static class BeerCollectionFactory
    {
        public static IReadBeerCollection CreateBeerCollectionLogic()
        {
            return new BeerCollection();
        }
    }
}
