using System;
using MyApp.Utilities;
using NUnit.Framework;

namespace MyAppTests.UnitTests
{
    [TestFixture]
    public class TestFilesIO
    {
        private string path;
        private FilesIO filesIO; // creating a object of filesio

        [OneTimeSetUp] // this method will run before all the test to initialize the variables
        public void Init()
        {
            path = @"C:\Users\shire\source\repos\GoldenTriangle\MyAppTests\TestData\";
            filesIO = new FilesIO(path);
        }

        [Test]
        public void Test01_ReadTextPositive()
        {
            string actual = filesIO.ReadText("test-text-input.txt");
            string expected = "hello my name is zerubabbel";
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test02_ReadTextNegative()
        {
            string actual = filesIO.ReadText("test-text-input.txt");
            string expected = "kuku";
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Test03_WritePositive()
        {
            string file = "test-text-input.txt";
            string text = "Test Automation at atid College Rockes !!!";
            try
            {
                filesIO.WriteText(file, text);
                string actual = filesIO.ReadText(file);
                Assert.AreEqual(text, actual, "Failed to compare file text to expected");
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
