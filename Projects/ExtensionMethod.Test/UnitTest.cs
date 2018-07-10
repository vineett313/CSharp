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
            Manager obj = new Manager();
            Assert.AreEqual("Vineet", obj.GetEmployeeById(1).Name);
        }
    }
}
