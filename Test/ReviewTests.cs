using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logic;


namespace Test
{
    [TestClass]
    public class ReviewTests
    {
        private readonly Review _review = new();
        
        [TestMethod]
        public void ReviewSearch_User_Response()
        {

            int numberid = 1;
            string name = "review";
            DateTime date = DateTime.Now;
            string datestring = date.ToLongDateString();
            var expected = (numberid, numberid, numberid, numberid, name, name, datestring);
            var output = _review.GetAllReviews();
            Assert.AreEqual(expected, output);
        }

        [TestMethod]
        public void ReviewAdd_User_AddResponse()
        {
            int numberid = 1;
            string name = "review";
            DateTime date = DateTime.Now;
            string datestring = date.ToLongDateString();
            var output = _review.AddReview();
        }
    }
}
//ReviewID, UserID, BeerID, Rate, Taste, Description, Datum