using System;
using MyApp.Utilities;
using NUnit.Framework;

namespace MyAppTests.IntegrationTests
{
    [TestFixture]
    public class TestFilesImp
    {
        private string path;
        private FilesIO filesIO;

        [OneTimeSetUp]
        public void Init()
        {
            path = @"C:\Users\shire\source\repos\GoldenTriangle\MyAppTests\TestData\";
            filesIO = new FilesIO(path);
        }

        [Test]
        public void Test01_ReadAndVerifyReverseNumbersPositive()
        {
          int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
          int actual = Implementations.ReverseNumbers(content);  
          Assert.AreEqual(54321, actual, "Failed to compare text in file to expexted");
        }
        [Test]
        public void Test02_ReadAndVerifyReverseNumbersNegative()
        {
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int actual = Implementations.ReverseNumbers(content);
            Assert.AreNotEqual(54322, actual, "Failed to compare text in file to expexted");
        }
        [Test]
        public void Test03_ReadAndVerifyLongestWordPositive()
        {
          string content = filesIO.ReadText("test-text-input.txt");
          string actual = Implementations.LogestWord(content.Split(' '));
          string expected = "Automation";
          Assert.AreEqual(expected, actual, "Failed to compare text in file to expexted");
        }
        [Test]
        public void Test04_ReadAndVerifyLongestWordNegative()
        {
            string content = filesIO.ReadText("test-text-input.txt");
            string actual = Implementations.LogestWord(content.Split(' '));
            string expected = "atid";
            Assert.AreNotEqual(expected, actual, "Failed to compare text in file to expexted");
        }
        [Test]
        public void Test05_ReadAndVerifyFacturialPositive()
        {
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int actual = Implementations.CalculateFacturial(content);
            Assert.AreEqual(120, actual, "Failed to compare text in file to expexted");
        }
        [Test]
        public void Test06_ReadAndVerifyFacturialNegative()
        {
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int actual = Implementations.CalculateFacturial(content);
            Assert.AreNotEqual(122, actual, "Failed to compare text in file to expexted");
        }
    }
}
