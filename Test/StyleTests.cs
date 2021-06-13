using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Dal.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Org.BouncyCastle.Asn1.BC;

namespace Test
{
    [TestClass]
    public class StyleTests 
    {
        [TestMethod]
        public void Test()
        {
            var output = new StyleDal();
            output.RemoveStyle(5);
        }

        [TestMethod]
        public void test1()
        {
            var output = new StyleDal();
            output.AddStyle(new StyleDTO(5, "NL"));
        }
    }
}
