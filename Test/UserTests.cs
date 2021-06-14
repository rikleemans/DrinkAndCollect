using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Interface;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.TestDal;

namespace Test
{
    [TestClass]
    public class UserTests
    {
        private readonly User _user = new User(new UserTestDal());

        [TestMethod]
        public void GetReview_User_GetReview()
        {
            string user = "f105cc42-4ec0-43bb-a38f-47b2e0bc618a";

            var response = _user.GetAllReviewsByUser(user);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public void AddBeerInfo_User_AddBeer()
        {

            bool output = _user.AddFriend("6b05e551-b9a7-46a1-8755-34be1a46fab1", "f105cc42-4ec0-43bb-a38f-47b2e0bc618a", "test456@gmail.com");

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void RemoveBeerInfo_User_RemoveBeer()
        {
            string userid = "6b05e551-b9a7-46a1-8755-34be1a46fab1";
            string friendid = "f105cc42-4ec0-43bb-a38f-47b2e0bc618a";
            var expected = true;

            var response = _user.RemoveFriend(userid, friendid);

            Assert.AreEqual(expected, response);
        }
    }
}
