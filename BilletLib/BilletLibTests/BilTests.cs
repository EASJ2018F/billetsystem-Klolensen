using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void BilPrisTest()
        {
            Bil bil = new Bil("45", new DateTime(1990, 3, 12), false);

            int result = bil.Pris();

            Assert.AreEqual(240, result);
        }

        [TestMethod()]
        public void BilKøretøjTest()
        {
            Bil bil = new Bil("45", new DateTime(1990, 3, 12), false);

            string result = bil.Køretøj();

            Assert.AreEqual("Bil", result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void BilNummerpladeExceptionTest()
        {
            Bil bil = new Bil("12345678", new DateTime(1990, 3, 12), false);
        }
    }
}