using Dal.Interface;

namespace Dal.Factory
{
    public static class BeerFactory
    {
        public static IBeer CreateBeerDal()
        {
            return new BeerDal();
        }
    }
}
