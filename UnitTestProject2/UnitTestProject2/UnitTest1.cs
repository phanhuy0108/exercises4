using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int result = Program.Ceil((float)2.3);
            Assert.AreEqual(3, result);

            int result2 = Program.Ceil(-2.3f);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestFloor(){
            int result1 = Program.Floor((float)2.3);
            Assert.AreEqual(2, result1);

            int result2 = Program.Floor(-2.3f);
            Assert.AreEqual(-3,result2);
        }

    }
}
