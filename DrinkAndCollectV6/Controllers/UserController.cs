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

        public ActionResult GetCollection(int id)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<ReviewViewModel> viewcollection = new List<ReviewViewModel>();
            try
            {
                IReadOnlyCollection<IViewableReview> reviews = user.GetCollection(id);

                foreach (IViewableReview review in reviews)
                {
                    viewcollection.Add(new ReviewViewModel(review.ReviewID, review.UserID, review.BeerID, review.Rate,
                        review.Taste, review.Description, review.Datum));
                }

                return View(viewcollection);
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        public ActionResult Index(string id = "f2a62e83-d2f3-4293-8b90-a0c8cfc36dec")
        {
            try
            {
                IReadUser users = UserFactory.CreateUserLogic();
                List<FriendViewModel> viewfriends = new List<FriendViewModel>();

                IReadOnlyCollection<IViewableFriend> friends = users.GetAllFriends(id);
                foreach (IViewableFriend user in friends)
                {
                    viewfriends.Add(new FriendViewModel(user.UserID, user.FriendID, user.Username));
                }

                return View(viewfriends);
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        public ActionResult GetFriendCollectionAsync(int id, int friendid)
        {
            IReadUser user = UserFactory.CreateUserLogic();
            List<FriendCollectionViewModel> viewcollection = new List<FriendCollectionViewModel>();
            try
            {
                IReadOnlyCollection<IViewableFriendCollection> friends = user.GetFriendCollection(id, friendid);

                foreach (IViewableFriendCollection friend in friends)
                {
                    viewcollection.Add(new FriendCollectionViewModel(friend.ReviewID, friend.FriendID, friend.BeerID,
                        friend.Rate, friend.Taste, friend.Description, friend.Datum));
                }

                return View(viewcollection);
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        public ActionResult AddFriend()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFriend(IFormCollection friend)
        {
            try
            {
                IReadUser users = UserFactory.CreateUserLogic();

                if (users.AddFriend(friend["UserID"], friend["FriendID"], friend["Username"]))
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
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }

        public ActionResult DeleteFriend(string userID, string friendID)
        {
            IReadUser users = UserFactory.CreateUserLogic();
            try
            {
                users.RemoveFriend(userID, friendID);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["bericht"] = ex.Message;
                return View();
            }
        }
    }
}
