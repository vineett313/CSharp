using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethod.Test
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Example1_Test()
        {
            String obj = "Vineet".DoWelcome();
            Assert.AreEqual("Welcome Vineet", obj);
        }

        [TestMethod]
        public void Example2_Test()
        {
            ICompany obj = new Manager();
            Assert.AreEqual("Vineet", obj.GetEmployeeById(1).Name);
        }

        [TestMethod]
        public void Example3_Test()
        {
            int[] obj = new int[] { 1, 2, 3, 455, 6 };
            Assert.AreEqual(obj.GetCount(), obj.Length);
        }
    }
}
