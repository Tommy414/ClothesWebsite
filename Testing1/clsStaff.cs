using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class clsStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff s = new clsStaff();
            Assert.IsNotNull(s);
        }
    }
}
