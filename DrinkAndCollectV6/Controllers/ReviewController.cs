using Logic.Factory;
using Logic.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV6.Models;

namespace DrinkAndCollectV6.Controllers
{
    public class ReviewController : Controller
    {
        // GET: ReviewController
        public ActionResult Index()
        {
            try
            {
                IReadUser user = UserFactory.CreateUserLogic();
                List<ReviewViewModel> reviewview = new List<ReviewViewModel>();

                IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviews();

                foreach (IViewableReview review in reviews)
                {
                    reviewview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate,
                        review.Taste, review.Description, review.Datum));
                }

                return View(reviewview);

            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult Details(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> reviewview = new List<ReviewViewModel>();
            try
            {
                IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviewsByUser(id);

                foreach (IViewableReview review in reviews)
                {
                    reviewview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate,
                        review.Taste, review.Description, review.Datum));
                }

                return View(reviewview);
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                return View();
            }
        }

        public ActionResult AddReview()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddReview(IFormCollection review)
        {
            try
            {
                IReadUserCollection users = UserCollectionFactory.CreateUserCollectionLogic();

                if (users.AddReview(Convert.ToInt32(review["ReviewID"]), review["UserID"], Convert.ToInt32(review["BeerID"]), Convert.ToInt32(review["Rate"]), review["Taste"], review["Description"], Convert.ToDateTime(review["Datum"])))
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
                ViewData["message"] = ex.Message;
                return View();
            }
        }

        // POST: UserController/Delete/5
        public ActionResult DeleteReview(int id)
        {
            try
            {
                IReadUserCollection users = UserCollectionFactory.CreateUserCollectionLogic();

                users.RemoveReview(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["message"] = ex.Message;
                return View();
            }

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
                if (reviews.UpdateReview(Convert.ToInt32(review["ReviewID"]), review["UserID"], Convert.ToInt32(review["BeerID"]), Convert.ToInt32(review["Rate"]), review["Taste"], review["Description"], Convert.ToDateTime(review["Datum"])))
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
                ViewData["message"] = ex.Message;
                return View();
            }
        }
    }
}
