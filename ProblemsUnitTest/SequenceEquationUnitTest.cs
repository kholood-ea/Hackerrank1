using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class SequenceEquationUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> given = new List<int>{2,3,1};
            List<int> result = new List<int>{2,3,1 };
            CollectionAssert.AreEqual(result, Problems.SequenceEquation.permutationEquation(given));

            List<int> given1 = new List<int> { 4, 3, 5,1,2 };
            List<int> result1 = new List<int> { 1, 3, 5,4,2 };
            CollectionAssert.AreEqual(result1, Problems.SequenceEquation.permutationEquation(given1));

        }
    }
}
