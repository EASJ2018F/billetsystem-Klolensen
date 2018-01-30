using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilletLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibTests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCPrisTest()
        {
            MC mc = new MC("45", new DateTime(1990, 4, 28));

            int result = mc.Pris();

            Assert.AreEqual(125, result);
        }

        [TestMethod()]
        public void MCKøretøjTest()
        {
            MC mc = new MC("45", new DateTime(1990, 4, 28));

            string result = mc.Køretøj();

            Assert.AreEqual("MC", result);
        }
    }
}
