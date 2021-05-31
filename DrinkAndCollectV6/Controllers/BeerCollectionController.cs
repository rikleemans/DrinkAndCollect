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
    public class BeerCollectionController : Controller
    {
        // GET: BeerController
        public ActionResult Index()
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> beerViewModels = new List<BeerViewModel>();
            IReadOnlyCollection<IViewableBeer> beers = beerc.GetAllBeerInfo();

            foreach (IViewableBeer beer in beers)
            {
                beerViewModels.Add(new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
            }

            return View(beerViewModels);
        }

        // GET: BeerController/Details/5
        public ActionResult Details(string name)
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> viewbeer = new List<BeerViewModel>();
            IReadOnlyCollection<IViewableBeer> beers = beerc.GetAllBeer(name);

            foreach (IViewableBeer beer in beers)
            {
                viewbeer.Add(new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
            }

            return View(viewbeer);
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
            catch
            {
                return View();
            }
        }

        // GET: BeerController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: BeerController/Delete/5
        public ActionResult Delete(int id)
        {
            IReadBeerCollection beers = BeerCollectionFactory.CreateBeerCollectionLogic();
            try
            {
                    beers.RemoveBeer(id);
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BeerController/Create
        public ActionResult AddStyle()
        {
            return View();
        }

        // POST: BeerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddStyle(IFormCollection style)
        {

            try
            {
                IReadBeerCollection styles = BeerCollectionFactory.CreateBeerCollectionLogic();

                if(styles.AddStyle(Convert.ToInt32(style["StyleID"]), style["Style"]))
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

        // GET: BeerController/Delete/5
        //public ActionResult RemoveStyle(int id)
        //{
        //    return View();
        //}

        // POST: BeerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RemoveStyle(int id)
        {
            IReadBeerCollection styles = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                styles.RemoveBeer(id);
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: BeerController/Create
        public ActionResult AddCategory()
        {
            return View();
        }

        // POST: BeerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(IFormCollection category)
        {
            try
            {
                IReadBeerCollection cat = BeerCollectionFactory.CreateBeerCollectionLogic();

                if (cat.AddCategory(Convert.ToInt32(category["CatID"]), category["Category"]))
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

        // GET: BeerController/Delete/5
        //public ActionResult DeleteCategory(int id)
        //{
        //    return View();
        //}

        // POST: BeerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCategory(int id)
        {
            IReadBeerCollection cat = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                cat.RemoveCategory(id);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
