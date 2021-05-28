using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV4.Models;
using Logic;
using Logic.Factory;
using Logic.Interface;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Org.BouncyCastle.Crypto.Engines;

namespace DrinkAndCollectV4.Controllers
{
    
    public class UserController : Controller
    {
        
        // GET: UserController
        public async Task<ActionResult> GetAllReviewsAsync()

        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviews();

            foreach (IViewableReview review in reviews)
            {
                viewreview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View (viewreview);
        }

        // GET: UserController/Details/5
        public ActionResult GetAllReviewsByUser(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviewsByUser(id);

            foreach (IViewableReview review in reviews)
            {
                viewreview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(viewreview);
        }
        public ActionResult GetCollection(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetCollection(id);

            foreach (IViewableReview review in reviews)
            {
                viewreview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(viewreview);
        }
        public ActionResult GetAllFriends(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<UserViewModel> viewuser = new List<UserViewModel>();
            IReadOnlyCollection<FriendViewModel> users = user.GetAllFriends(id);

            foreach (FriendViewModel user in users)
            {
                viewuser.Add(new UserViewModel(user.Username, user.UserID, user.BeerID, user.Rate, user.Taste, user.Description, user.Datum));
            }

            return View(viewreview);
        }
        public ActionResult GetAllReviewsByUser(int id, int friendid)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviewsByUser(id, friendid);

            foreach (IViewableReview review in reviews)
            {
                viewreview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(viewreview);
        }



        //// GET: UserController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: UserController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: UserController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: UserController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
