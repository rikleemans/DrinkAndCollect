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
    public class UserCollectionController : Controller
    {
        // GET: UserCollectionController
        public ActionResult Index()
        {
            return View();
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

                if (users.AddReview(Convert.ToInt32(review["ReviewID"]), Convert.ToInt32(review["UserID"]), Convert.ToInt32(review["BeerID"]), Convert.ToInt32(review["Rate"]), review["Taste"], review["Description"], Convert.ToDateTime(review["Datum"])))
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

        // GET: UserController/Delete/5
        //public ActionResult DeleteReview(int id)
        //{
        //    return View();
        //}

        // POST: UserController/Delete/5
        public ActionResult DeleteReview(int id)
        {
            IReadUserCollection users = UserCollectionFactory.CreateUserCollectionLogic();
            try
            {
                users.RemoveReview(id);
                return View();
            }
            catch
            {
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

                if (users.AddFriend(Convert.ToInt32(friend["UserID"]), Convert.ToInt32(friend["FriendID"]), friend["Username"], friend["Firstname"], friend["Lastname"]))
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

        // GET: UserController/Delete/5
        //public ActionResult DeleteFriend(int id)
        //{
        //    return View();
        //}

        // POST: UserController/Delete/5
        public ActionResult DeleteFriend(int userID, int friendID)
        {
            IReadUser users = UserFactory.CreateUserLogic();
            try
            {
                users.RemoveFriend(userID, friendID);
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
