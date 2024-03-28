using System;
using MyApp.Utilities;
using NUnit.Framework;

namespace MyAppTests.E2ETests
{
    [TestFixture]
    public class TestAll
    {
        private string path;
        private FilesIO filesIO;

        [OneTimeSetUp]
        public void Init()
        {
            path = @"C:\Users\shire\source\repos\GoldenTriangle\MyAppTests\TestData\";
            filesIO = new FilesIO(path);
        }
        //E2E flow - reverse numbers
        // part 1:read from text-num-input file
        //part 2: call reverse numbers function with the content read in part 01
        //part 3: write to result-file returned value of reverse numbers function
        //part 4: read from result text file
        // prat 5: verify (assert) the content from results text file to expected
        
        [Test]
        public void Test01_E2E_ReverseNumbersPositive()
        {
            int expected = 54321;
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int reversedNumber = Implementations.ReverseNumbers(content);
            filesIO.WriteText("test-result.txt", reversedNumber.ToString());
            int actual= Int32.Parse(filesIO.ReadText("test-result.txt"));
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test02_E2E_ReverseNumbersNegative()
        {
            int expected = 54322;
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int reversedNumber = Implementations.ReverseNumbers(content);
            filesIO.WriteText("test-result.txt", reversedNumber.ToString());
            int actual = Int32.Parse(filesIO.ReadText("test-result.txt"));
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Test03_E2E_FacturialPositive()
        {
            int expected = 120;
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int Calculate = Implementations.CalculateFacturial(content);
            filesIO.WriteText("test-result.txt", Calculate.ToString());
            int actual = Int32.Parse(filesIO.ReadText("test-result.txt"));
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test04_E2E_FacturialNegative()
        {
            int expected = 122;
            int content = Int32.Parse(filesIO.ReadText("test-num-input.txt"));
            int Calculate = Implementations.CalculateFacturial(content);
            filesIO.WriteText("test-result.txt", Calculate.ToString());
            int actual = Int32.Parse(filesIO.ReadText("test-result.txt"));
            Assert.AreNotEqual(expected, actual);
        }
        [Test]
        public void Test05_E2E_LongestWordPositive()
        {
            string expected = "Automation";
            string content = filesIO.ReadText("test-text-input.txt");
            string longestWord = Implementations.LogestWord(content.Split(' '));
            filesIO.WriteText("test-result.txt", longestWord);
            string actual = filesIO.ReadText("test-result.txt");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test06_E2E_LongestWordNegative()
        {
            string expected = "atid";
            string content = filesIO.ReadText("test-text-input.txt");
            string longestWord = Implementations.LogestWord(content.Split(' '));
            filesIO.WriteText("test-result.txt", longestWord);
            string actual = filesIO.ReadText("test-result.txt");
            Assert.AreNotEqual(expected, actual);
        }

    }
}
