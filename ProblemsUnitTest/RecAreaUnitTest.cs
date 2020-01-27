using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class RecAreaUnitTest
    {
        [TestMethod]
        public void designerPdfViewerTestShouldReturnVal()
        {
            int[] ar = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7};
            int result = Problems.RecArea.designerPdfViewer(ar, "kholood");
            int result1 = Problems.RecArea.designerPdfViewer(ar, "abc");
            int result2 = Problems.RecArea.designerPdfViewer(ar, "zaba");
            int result3 = Problems.RecArea.designerPdfViewer(ar, "nasser");
            int result4 = Problems.RecArea.designerPdfViewer(ar, "ahmad");
            int result5 = Problems.RecArea.designerPdfViewer(ar, "eassa");
            Assert.AreEqual(35, result);
            Assert.AreEqual(9, result1);
            Assert.AreEqual(28, result2);
            Assert.AreEqual(30, result3);
            Assert.AreEqual(25, result4);
            Assert.AreEqual(25, result5);
        }
        [TestMethod]
        public void designerPdfViewerTestShouldReturn0()
        {
            int[] ar = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            int result = Problems.RecArea.designerPdfViewer(ar, "");
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void designerPdfViewerTestShouldReturnmax()
        {
            int[] ar = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            int result = Problems.RecArea.designerPdfViewer(ar, "abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual(182, result);
        }
    }
}
