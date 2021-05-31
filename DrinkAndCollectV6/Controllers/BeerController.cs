using DrinkAndCollectV6.Models;
using Logic.Factory;
using Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndCollectV6.Controllers
{
    public class BeerController : Controller
    {
        // GET: BeerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BeerController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: BeerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(IFormCollection beer)
        {
            IReadBeer beers = BeerFactory.CreateBeerLogic();
            try
            {
                if (beers.UpdateBeer(Convert.ToInt32(beer["ID"]), Convert.ToInt32(beer["StyleID"]), Convert.ToInt32(beer["CatID"]), beer["Name"], beer["Description"]))
                {

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

       
    }
}
