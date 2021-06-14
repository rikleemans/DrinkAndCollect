using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.TestDal;

namespace Test
{
    [TestClass]
    class UserTests
    {
        private readonly UserCollection _usercollection = new UserCollection(new UserCollectionTestDal());

        [TestMethod]
        public void AddFriend_User_AddFriend()
        {

        }
    }
}
