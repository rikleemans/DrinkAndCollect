using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectServer.Models;
using DrinkAndCollectV4.Models;
using Logic.Factory;
using Logic.Interface;

namespace DrinkAndCollectServer.Controllers
{
    public class BeerCollectionController : Controller
    {
        public async Task<List<BeerViewModel>> GetAllBeerInfo()
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> viewbeer= new List<BeerViewModel>();
            IReadOnlyCollection<IViewableBeer> beers = beerc.GetAllBeerInfo();

            foreach (IViewableBeer beer in beers)
            {
                viewbeer.Add(new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
            }

            return viewbeer;
        }
        public async Task<List<BeerViewModel>> GetAllBeer()
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<BeerViewModel> viewbeer = new List<BeerViewModel>();
            IReadOnlyCollection<IViewableBeer> beers = beerc.GetAllBeerInfo();

            foreach (IViewableBeer beer in beers)
            {
                viewbeer.Add(new BeerViewModel(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description));
            }

            return viewbeer;
        }

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

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async void RemoveBeer(BeerViewModel beer)
        {
            IReadBeerCollection beers = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                beers.RemoveBeer(beer.ID, beer.StyleID, beer.CatID, beer.Name, beer.Description);
            }
            catch
            {
                View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void AddCategory(CategoryViewModel category)
        {
            IReadBeerCollection cat = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                cat.AddCategory(category.CatID, category.Categorie);
            }
            catch
            {
                View();
            }

        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async void RemoveCategory(CategoryViewModel category)
        {
            IReadBeerCollection cat = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                cat.RemoveCategory(category.CatID, category.Categorie);
            }
            catch
            {
                View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void AddStyle(StyleViewModel style)
        {
            IReadBeerCollection styles = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                styles.AddStyle(style.StyleID, style.Style);
            }
            catch
            {
                View();
            }

        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async void RemoveStyle(StyleViewModel style)
        {
            IReadBeerCollection styles = BeerCollectionFactory.CreateBeerCollectionLogic();

            try
            {
                styles.RemoveStyle(style.StyleID, style.Style);
            }
            catch
            {
                View();
            }

        }
    }

}
