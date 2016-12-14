using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        Program p = new Program();

        [TestMethod]
        public void TestMethod1()
        {
            bool expected = true;
            bool actual = p.IsAnagramOrPalindrome("anna");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool expected = true;
            bool actual = p.IsAnagramOrPalindrome("aaaaaaaa");
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod3()
        {
            bool expected = true;
            bool actual = p.IsAnagramOrPalindrome("aaaaaaaab");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool expected = false;
            bool actual = p.IsAnagramOrPalindrome("caaaaaaaab");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool expected = true;
            bool actual = p.IsAnagramOrPalindrome("donotbobtonod");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool expected = false;
            bool actual = p.IsAnagramOrPalindrome("owefhijpfwai");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod7()
        {
            bool expected = true;
            bool actual = p.IsAnagramOrPalindrome("igdedgide");
            Assert.AreEqual(expected, actual);
        }
    }
}
