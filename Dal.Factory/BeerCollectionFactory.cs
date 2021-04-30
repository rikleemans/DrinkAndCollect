using Dal.Interface;

namespace Dal.Factory
{
    public static class BeerCollectionFactory
    {
        public static IBeerCollection CreateBeerCollectionDal()
        {
            return new BeerCollectionDal();
        }
    }
}
