using System.Collections.Generic;
using System.Globalization;
using Dal.Interface;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.TestDal;

namespace Test
{
    [TestClass]
    public class BeerTests
    { 
        private readonly BeerCollection _beercollection = new BeerCollection(new BeerCollectionDalTest());
        private readonly Beer _beers = new();
        private readonly Beer _beer = new(1, 1, 1, "bavaria", "bavaria");

    [TestMethod]
    public void BeerInfoSearch_User_Response()
    {
        int number = 3;
        var output = _beercollection.GetAllBeerInfo();

        Assert.AreEqual(output.Count, number);
    }

    [TestMethod]
    public void BeerNameSearch_User_Response()
    {
        string beername = "bavaria";
        string expected = "bavaria";

        var output = _beercollection.GetAllBeer(beername);

        Assert.AreEqual(output.Count, 2);
    }

    [TestMethod]
    public void AddBeerInfo_User_AddBeer()
    {
        BeerDTO beer = new BeerDTO(2, 2, 2, "bavaria", "bavaria");

        bool output = _beercollection.AddBeer(2, 2, 2, "bavaria", "bavaria");
        
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

    [TestMethod]
    public void GetBeerInfo_User_GetBeerMin()
    {
        int number = 1;

        var response = _beercollection.GetBeerById(number);

        Assert.IsNotNull(response);
    }

    [TestMethod]
    public void GetBeerInfo_User_GetBeerTooMax()
    {
        int number = 10;

        var response = _beercollection.GetBeerById(number);

        Assert.IsNotNull(response);
    }
    }
}
