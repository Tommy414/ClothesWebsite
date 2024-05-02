using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class clsOrder
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsOrder anOrder = new clsOrder();
            Assert.IsNotNull(anOrder);
        }
    }
}
