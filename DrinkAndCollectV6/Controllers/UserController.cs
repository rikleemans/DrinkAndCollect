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
    public class UserController : Controller
    {
        // GET: UserController
        public ActionResult Index()
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> reviewview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviews();

            foreach (IViewableReview review in reviews)
            {
                reviewview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(reviewview);
        }

        public ActionResult ReviewsByUser(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> reviewview = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetAllReviewsByUser(id);

            foreach (IViewableReview review in reviews)
            {
                reviewview.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(reviewview);
        }

        public ActionResult GetCollection(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewcollection = new List<ReviewViewModel>();
            IReadOnlyCollection<IViewableReview> reviews = user.GetCollection(id);

            foreach (IViewableReview review in reviews)
            {
                viewcollection.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum));
            }

            return View(viewcollection);
        }

        public ActionResult GetAllFriends(int id)
        {
            IReadUser users = UserFactory.CreateUserLogic();
            List<FriendViewModel> viewfriends = new List<FriendViewModel>();
            IReadOnlyCollection<IViewableFriend> friends = users.GetAllFriends(id);

            foreach (IViewableFriend user in friends)
            {
                viewfriends.Add(new FriendViewModel(user.UserID, user.FriendID, user.Username, user.Firstname, user.Lastname));
            }

            return View(viewfriends);
        }

        public ActionResult GetFriendCollectionAsync(int id, int friendid)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<FriendCollectionViewModel> viewcollection = new List<FriendCollectionViewModel>();
            IReadOnlyCollection<IViewableFriendCollection> friends = user.GetFriendCollection(id, friendid);

            foreach (IViewableFriendCollection friend in friends)
            {
                viewcollection.Add(new FriendCollectionViewModel(friend.ReviewID, friend.FriendID, friend.BeerID, friend.Rate, friend.Taste, friend.Description, friend.Datum));
            }

            return View(viewcollection);
        }
    }
}
