using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class BeerTests
    {
        private readonly Logic.BeerCollection _beercollection = new();
        private readonly Logic.Beer _beer = new(1, 1, 1, "kaas", "kaas");

        [TestMethod]
        public void GetAllBeerInfo()
        {
            var output = _beercollection.GetAllBeerInfo();
        }
        [TestMethod]
        public void GetAllBeer()
        {
            var output = _beercollection.GetAllBeer("kaass");
        }
        [TestMethod]
        public void UpdateBeer()
        {
            var s = new Beer(1, 1, 1, "kaass", "kaass");
            _beer.UpdateBeer(s);
        }
        [TestMethod]
        public void AddBeer()
        {
            Beer s = new Beer(3, 1, 1, "kaasss", "kaasss");
            _beercollection.AddBeer(s);
        }

        [TestMethod]
        public void RemoveBeer()
        {
            _beercollection.RemoveBeer(1);
        }

    }
}
