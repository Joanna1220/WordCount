using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using ConsoleApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestChar
    {
        [TestMethod]
        public void TestChar()
        {
            string file = @"D:\\201731107105\\test.txt";
            WordCounter w = new WordCounter();
            Assert.AreEqual(w.CountChar(file),44);
        }
    }
    public class UnitTestLine
    {
        [TestMethod]
        public void TestLine()
        {
            string file = @"D:\\201731107105\\test.txt";
            WordCounter w = new WordCounter();
            Assert.AreEqual(w.CountLines(file), 2);
        }
    }
    public class UnitTest
    {
        [TestMethod]
        public void Test()
        {
            string file = @"D:\\201731107105\\test.txt";
            WordCounter w = new WordCounter();
            w.WordFrequency(file);
            Assert.AreEqual(w.CountWords(file), 5);
        }
    }

}
