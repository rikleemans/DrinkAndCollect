using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dal.Interface;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Asn1.BC;
using Test.TestDal;

namespace Test
{
    [TestClass]
    public class StyleTests 
    {
        private readonly Style _style= new Style(new StyleTestDal());
        [TestMethod]
        public void AddCategory_User_AddCategory()
        {
            int getal = 2;
            string woord = "kaas";

            bool output = _style.AddStyle(getal, woord);

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void RemoveCategory_User_RemoveCategory()
        {
            int number = 1;
            var expected = true;

            var response = _style.RemoveStyle(number);

            Assert.AreEqual(expected, response);
        }
    }
}
