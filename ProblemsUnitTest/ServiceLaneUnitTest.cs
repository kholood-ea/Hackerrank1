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
            int[][] array2D = new int[4][];
            array2D={ { 0, 3 }, { 4, 6 }, { 6, 7 }, { 3, 5 }, { 0, 7 } };
            int[] result = { 1,2,3,2,1};
            int[] result2 = Problems.ServiceLane.serviceLane(array2D,arr);
        }
    }
}
