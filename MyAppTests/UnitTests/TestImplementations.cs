using System;
using NUnit.Framework;
using MyApp.Utilities;

namespace MyAppTests.UnitTests
{
    [TestFixture]
    public class TestImplementations
    {
        [Test]
        public void Test01_ReverseNumbersPositive()
        {
            int expexted = 54321;
            int actual = Implementations.ReverseNumbers(12345);
            try
            {
                Assert.AreEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
        [Test]
        public void Test02_ReverseNumbersNegative()
        {
            int expexted = 101;
            int actual = Implementations.ReverseNumbers(12345);
            try
            {
                Assert.AreNotEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
        [Test]
        public void Test03_FacturialPositive()
        {
            int expexted = 120;
            int actual = Implementations.CalculateFacturial(5);
            try
            {
                Assert.AreEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
        [Test]
        public void Test04_FacturialNegative()
        {
            int expexted = 123;
            int actual = Implementations.CalculateFacturial(5);
            try
            {
                Assert.AreNotEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
        [Test]
        public void Test05_LongestWordPositive()
        {
            string text = "Test Automation at atid College Rockes !!!";
            string expexted = "Automation";
            string actual = Implementations.LogestWord(text.Split(' '));
            try
            {
                Assert.AreEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
        [Test]
        public void Test06_LongestWordNegative()
        {
            string text = "Test Automation at atid College Rockes !!!";
            string expexted = "atid";
            string actual = Implementations.LogestWord(text.Split(' '));
            try
            {
                Assert.AreNotEqual(expexted, actual, "actual and expected do not match");
                Console.WriteLine("Test Passed");
            }
            catch (Exception message)
            {
                Console.WriteLine("Test Failed, see Details:" + message);
                Assert.Fail("Test Failed, see Details:" + message);
            }
        }
    }
}
