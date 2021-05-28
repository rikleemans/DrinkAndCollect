using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV4.Models;
using Logic.Factory;
using Logic.Interface;

namespace DrinkAndCollectServer.Controllers
{
    public class BeerController : Controller
    {
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async void UpdateBeer(BeerViewModel beers)
        {
            IReadBeer beer = BeerFactory.CreateBeerLogic();

            try
            {
                beer.UpdateBeer(beers.ID, beers.StyleID, beers.CatID, beers.Name, beers.Description);
            }
            catch
            {
                View();
            }

        }
    }
}
