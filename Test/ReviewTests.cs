using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Logic;


namespace Test
{
    [TestClass]
    public class ReviewTests
    {
        private readonly UserCollection _usercollection = new();

        [TestMethod]
        public void ReviewAdd_User_AddResponseTrue()
        {
            int numberid = 6;
            string name = "review";
            string user = "f105cc42-4ec0-43bb-a38f-47b2e0bc618a";
            DateTime date = DateTime.Now;

            var output = _usercollection.AddReview(numberid, user, numberid, numberid, name , name, date);

            Assert.IsNotNull(output);
        }

        [TestMethod]
        public void ReviewAdd_User_AddResponseFalse()
        {
            int numberid = 6;
            string name = "review";
            string user = "f105cc42-4ec0-43bb-a38f-47b2e0bc618a";
            DateTime date = DateTime.Now;

            var output = _usercollection.AddReview(numberid, user, numberid, numberid, name, name, date);

            Assert.IsNull(output);
        }

        [TestMethod]
        public void ReviewRemove_User_RemoveResponseTrue()
        {
            int numberid = 6;

            var output = _usercollection.RemoveReview(numberid);

            Assert.IsTrue(output);
        }
    }
}