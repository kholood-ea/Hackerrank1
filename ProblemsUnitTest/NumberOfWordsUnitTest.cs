using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class NumberOfWordsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s="thisHelloWorld" ;
                int x = 3;
            int y = Problems.NumberOfWords.camelcase(s);
            Assert.AreEqual(x, y);

        }
    }
}
