using System;
using HelloWorldForJenkins;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            Assert.AreEqual("Hello World", Program.CreateMessge());
        }
    }
}
