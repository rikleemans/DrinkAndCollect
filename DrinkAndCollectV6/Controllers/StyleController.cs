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
    public class StyleController : Controller
    {
        // GET: BeerController
        public ActionResult Index()
        {
            IReadBeerCollection beerc = BeerCollectionFactory.CreateBeerCollectionLogic();
            List<StyleViewModel> styleViewModels = new List<StyleViewModel>();
            try
            {
                IReadOnlyCollection<IViewableStyle> styles = beerc.GetAllStyle();
                foreach (IViewableStyle style in styles)
                {
                    styleViewModels.Add(
                        new StyleViewModel(style.StyleID, style.Name));
                }

                return View(styleViewModels);
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
    }
}
