using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class ServiceLaneUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] arr = { 2, 3, 1, 2, 3, 2, 3, 3};
            int[][] jaggedArray2 = new int[][]
{
    new int[] { 0, 3},
    new int[] {  4, 6},
    new int[] { 6, 7 },
        new int[] {  3, 5 },
            new int[] { 0, 7},


};
            int[] result = { 1,2,3,2,1};
            int[] result2 = Problems.ServiceLane.serviceLane(jaggedArray2, arr);
            CollectionAssert.AreEqual(result, result2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] arr = { 1, 2, 2, 2, 1 };
            int[][] jaggedArray2 = new int[][]{
             new int[] { 2, 3},
             new int[] {  1, 4},
             new int[] { 2, 4 },
             new int[] {  2, 4 },
            new int[] { 2, 3},};
            int[] result = { 2, 1, 1, 1, 2 };
            int[] result2 = Problems.ServiceLane.serviceLane(jaggedArray2, arr);
            CollectionAssert.AreEqual(result, result2);
        }
    }
}
