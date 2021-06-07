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
            IReadStyle beercollection = StyleFactory.CreateStyleLogic();
            List<StyleViewModel> styleViewModels = new List<StyleViewModel>();
            try
            {
                IReadOnlyCollection<IViewableStyle> styles = beercollection.GetAllStyle();
                foreach (IViewableStyle style in styles)
                {
                    styleViewModels.Add(
                        new StyleViewModel(style.StyleID, style.Name));
                }

                return View(styleViewModels);
            }
            catch (Exception e)
            {
                List<StyleViewModel> newmodel = new List<StyleViewModel>();
                ViewData["message"] = e.Message;
                return View(newmodel);
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
                IReadStyle styles = StyleFactory.CreateStyleLogic();

                if (styles.AddStyle(Convert.ToInt32(style["StyleID"]), style["Name"]))
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
            }
            catch (Exception e)
            {
                List<StyleViewModel> newmodel = new List<StyleViewModel>();
                ViewData["message"] = e.Message;
                return View(newmodel);
            }
        }

        public ActionResult RemoveStyle(int id)
        {
            try
            {
                IReadStyle styles = StyleFactory.CreateStyleLogic();

                styles.RemoveStyle(id);
                return RedirectToAction(nameof(Index));

            }
            catch (Exception e)
            {
                List<StyleViewModel> newmodel = new List<StyleViewModel>();
                ViewData["message"] = e.Message;
                return View(newmodel);
            }
        }
    }
}
