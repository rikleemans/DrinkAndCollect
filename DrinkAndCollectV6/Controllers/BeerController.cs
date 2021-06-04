using DrinkAndCollectV6.Models;
using Logic.Factory;
using Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.Interface;

namespace DrinkAndCollectV6.Controllers
{
    public class BeerController : Controller
    {
        // GET: BeerController
        public ActionResult Index()
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> beerViewModels = new List<BeerViewModel>();
            try
            {
                IReadOnlyCollection<IViewableBeer> beers = beerc.GetAllBeerInfo();
                foreach (IViewableBeer beer in beers)
                {
                    beerViewModels.Add(
                        new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
                }

                return View(beerViewModels);
            }
            catch(Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }


        }

        // GET: BeerController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
                var beer = beerc.GetBeerById(id);

                BeerViewModel beerViewModel = new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description);

                return View(beerViewModel);
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        // POST: BeerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection beer)
        {
            try
            {
                IReadBeer beers = BeerFactory.CreateBeerLogic();
                if (beers.UpdateBeer(Convert.ToInt32(beer["ID"]), Convert.ToInt32(beer["StyleID"]), Convert.ToInt32(beer["CatID"]), beer["Name"], beer["Description"]))
                {

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        // GET: BeerController/Details/5
        public ActionResult Details(string name)
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> viewbeer = new List<BeerViewModel>();

            try
            {
                IReadOnlyCollection<BeernameDTO> beers = beerc.GetAllBeer(name);
                foreach (IViewableBeer beer in beers)
                {
                    viewbeer.Add(new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
                }

                return View(viewbeer);
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        // GET: BeerController/Create
        public ActionResult AddBeer()
        {
            return View();
        }

        // POST: BeerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddBeer(IFormCollection beer)
        {
            try
            {
                IReadBeerCollection beers = BeerCollectionFactory.CreateBeerCollectionLogic();

                if (beers.AddBeer(Convert.ToInt32(beer["ID"]), Convert.ToInt32(beer["StyleID"]), Convert.ToInt32(beer["CatID"]), beer["Name"], beer["Description"]))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            IReadBeerCollection beer = BeerCollectionFactory.CreateBeerCollectionLogic();
            try
            {
                beer.RemoveBeer(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }

        }


    }
}
