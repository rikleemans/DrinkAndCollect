using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV4.Models;
using Logic.Factory;
using Logic.Interface;
using Microsoft.AspNetCore.Http;

namespace DrinkAndCollectServer.Controllers
{
    public class UserCollectionController : Controller
    {
        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void AddReview(ReviewViewModel review)
        {
            IReadUserCollection user = UserCollectionFactory.CreateUserCollectionLogic();

            try
            {
                user.AddReview(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum);
            }
            catch
            {
                View();
            }

        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async void RemoveReview(ReviewViewModel review)
        {
            IReadUserCollection user = UserCollectionFactory.CreateUserCollectionLogic();

            try
            {
                user.RemoveReview(review.ReviewID, review.UserID, review.BeerID, review.Rate, review.Taste, review.Description, review.Datum);
            }
            catch
            {
                View();
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async void AddFriend(FriendViewModel friend)
        {
            IReadUserCollection friends = UserCollectionFactory.CreateUserCollectionLogic();

            try
            {
                friends.AddFriend(friend.UserID, friend.FriendID, friend.Username, friend.Firstname, friend.Lastname);
            }
            catch
            {
                View();
            }

        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public async void RemoveFriend(FriendViewModel friend)
        {
            IReadUserCollection friends = UserCollectionFactory.CreateUserCollectionLogic();

            try
            {
                friends.RemoveFriend(friend.UserID, friend.FriendID, friend.Username, friend.Firstname, friend.Lastname);
            }
            catch
            {
                View();
            }

        }
    }
}
