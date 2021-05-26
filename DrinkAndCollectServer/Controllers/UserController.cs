using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV4.Models;
using Logic.Factory;
using Logic.Interface;
using Org.BouncyCastle.Crypto.Engines;

namespace DrinkAndCollectV4.Controllers
{
    
    public class UserController : Controller
    {
        
        // GET: UserController
        public async Task<List<ReviewViewModel>> GetAllReviewsAsync()
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviews();

            foreach (IViewableReview review in reviews)
            {
                viewreview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return viewreview;
        }

        public async Task<List<ReviewViewModel>> GetAllReviewByUserAsync(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewreviews = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviewsByUser(id);

            foreach (IViewableReview review in reviews)
            {
                viewreviews.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return viewreviews;
        }

        public async Task<List<ReviewViewModel>> GetCollectionAsync(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewcollection = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetCollection(id);

            foreach (IViewableReview review in reviews)
            {
                viewcollection.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return viewcollection;
        }
        public async Task<List<FriendViewModel>> GetAllFriendsAsync(int id)
        {
            IReadUser users = UserFactory.CreateUserLogic();
            List<FriendViewModel> viewfriends = new List<FriendViewModel>();
            IReadOnlyCollection<IViewableFriend> friends = users.GetAllFriends(id);

            foreach (IViewableFriend user in friends)
            {
                viewfriends.Add(new FriendViewModel(user.UserID, user.FriendID, user.Username, user.Firstname, user.Lastname));
            }

            return viewfriends;
        }
        public async Task<List<FriendCollectionViewModel>>GetFriendCollectionAsync(int id, int friendid)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<FriendCollectionViewModel> viewcollection = new List<FriendCollectionViewModel>();
            IReadOnlyCollection<IViewableFriendCollection> friends = user.GetFriendCollection(id, friendid);

            foreach (IViewableFriendCollection friend in friends)
            {
                viewcollection.Add(new FriendCollectionViewModel(friend.ReviewID, friend.FriendID, friend.BeerID, friend.Rate, friend.Taste, friend.Description, friend.Datum));
            }

            return viewcollection;
        }
        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
