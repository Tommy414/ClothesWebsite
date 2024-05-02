using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsStock aStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(aStock);
        }
    }
}
