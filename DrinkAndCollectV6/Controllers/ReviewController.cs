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
    public class ReviewController : Controller
    {
        // GET: ReviewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ReviewController/Edit/5
        public ActionResult Update(int id)
        {
            return View();
        }

        // POST: ReviewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(IFormCollection review)
        {
            IReadReview reviews = ReviewFactory.CreateReviewLogic();
            try
            {
                if (reviews.UpdateReview(Convert.ToInt32(review["ReviewID"]), Convert.ToInt32(review["UserID"]), Convert.ToInt32(review["BeerID"]), Convert.ToInt32(review["Rate"]), review["Taste"], review["Description"], Convert.ToDateTime(review["Datum"])))
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
