using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkAndCollectV4.Models;
using Logic.Factory;
using Logic.Interface;

namespace DrinkAndCollectServer.Controllers
{
    public class ReviewController : Controller
    {
        [HttpPut]
        [ValidateAntiForgeryToken]
        public async void UpdateReview(ReviewViewModel reviews)
        {
            IReadReview review = ReviewFactory.CreateReviewLogic();

            try
            {
                review.UpdateReview(reviews.ReviewID, reviews.UserID, reviews.BeerID, reviews.Rate, reviews.Taste, reviews.Description, reviews.Datum);
            }
            catch
            {
                View();
            }

        }
    }
}
