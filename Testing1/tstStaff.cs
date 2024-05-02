using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Creating an instance of a class
            clsStaff StaffMember = new clsStaff();
            Assert.IsNotNull(StaffMember);
        }
    }
}
