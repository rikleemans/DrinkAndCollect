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
    public class CategoryTests
    {
        private readonly Category _style = new Category(new CategoryTestDal());

        [TestMethod]
        public void AddCategory_User_AddCategory()
        {
            CategoryDTO category = new CategoryDTO(2, "kaas");

            bool output = _style.AddCategory(2, "kaas");

            Assert.IsTrue(output);
        }

        [TestMethod]
        public void RemoveCategory_User_RemoveCategory()
        {
            int number = 1;
            var expected = true;

            var response = _style.RemoveCategory(number);

            Assert.AreEqual(expected, response);
        }
    }
}
