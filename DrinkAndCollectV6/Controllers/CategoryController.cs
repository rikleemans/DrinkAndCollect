﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV6.Models;
using Logic.Factory;
using Logic.Interface;
using Microsoft.AspNetCore.Http;

namespace DrinkAndCollectV6.Controllers
{
    public class CategoryController : Controller
    {
        // GET: BeerController
        public ActionResult Index()
        {
            try
            {
                IReadCategory beercollection = CategoryFactory.CreateCategoryLogic();
                List<CategoryViewModel> catViewModels = new List<CategoryViewModel>();
                IReadOnlyCollection<IViewableCategory> cats = beercollection.GetAllCategory();
                foreach (IViewableCategory cat in cats)
                {
                    catViewModels.Add(
                        new CategoryViewModel(cat.CatID, cat.Name));
                }

                return View(catViewModels);
            }
            catch (Exception e)
            {
                List<CategoryViewModel> newmodel = new List<CategoryViewModel>();
                ViewData["message"] = e.Message;
                return View(newmodel);
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
                IReadCategory cat = CategoryFactory.CreateCategoryLogic();

                if (cat.AddCategory(Convert.ToInt32(category["CatID"]), category["Name"]))
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
                ViewData["message"] = e.Message;
                return View();
            }

        }

        public ActionResult DeleteCategory(int id)
        {
            IReadCategory cat = CategoryFactory.CreateCategoryLogic();
            try
            {
                cat.RemoveCategory(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ViewData["message"] = e.Message;
                return View();
            }

        }
    }
}
