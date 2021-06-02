using Dal.Interface;

namespace Dal.Factory
{
    public static class StyleFactory
    {
        public static IStyle CreateStyleDal()
        {
            return new StyleDal();
        }
    }
}
