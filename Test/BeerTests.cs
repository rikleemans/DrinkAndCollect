using System.Collections.Generic;
using System.Globalization;
using Dal.Interface;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class BeerTests
    { 
        private readonly TestDal.BeerCollectionDalTest _beercollection = new();
        private readonly Beer _beers = new();
        private readonly Beer _beer = new(1, 1, 1, "kaas", "kaas");

    [TestMethod]
    public void BeerInfoSearch_User_Response()
    {
        var output = _beercollection.GetAllBeerInfo();

        Assert.AreEqual(output.Count, 1);
    }

    [TestMethod]
    public void BeerNameSearch_User_Response()
    {
        string beername = "kaas";
        string expected = "kaas";

        var output = _beercollection.GetAllBeer(beername);

        Assert.AreEqual(output.Count, 1);
    }

    [TestMethod]
    public void AddBeerInfo_User_AddBeer()
    {
        BeerDTO beer = new BeerDTO(2, 2, 2, "kaas", "kaas");

         bool output =  _beercollection.AddBeer(beer);

        Assert.IsTrue(output);
        }

    [TestMethod]
    public void RemoveBeerInfo_User_RemoveBeer()
    {
        int number = 1;
        var expected = true;

        var response = _beercollection.RemoveBeer(number);

        Assert.AreEqual(expected, response);
    }

}
}
