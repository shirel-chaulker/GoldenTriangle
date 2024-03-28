using NUnit.Framework;
using System;

namespace MyAppTests
{
    //-----------------------------------
    // check page

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            int result = 120;
            Assert.AreEqual(120, result);
        }
        [Test]
        public void TestMethod2()
        {
            int result = 44;
            Assert.AreNotEqual(120, result);

        }

    }
 
}
