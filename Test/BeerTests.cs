using System.Collections.Generic;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class BeerTests
    { 
        private readonly BeerCollection _beercollection = new();
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
    public void BeerInfo_User_ChangesBeerInfo()
    {
        //int number = 1;
        //string name = "kaas";
        //var expected = (number, number, number, name, name);
        //var s = new Beer(1, 1, 1, "kaas", "kaas");
        //_beers.UpdateBeer(s);
        //Assert.AreEqual(expected, s);
    }
    [TestMethod]
    public void AddBeerInfo_User_AddBeer()
    {
        //int number = 1;
        //string name = "kaas";
        //var expected = (number, number, number, name, name);
        //Beer s = new Beer(1, 1, 1, "kaas", "kaas");
        //_beercollection.AddBeer();
        //Assert.AreEqual(expected, s);
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
