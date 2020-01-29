using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class CatsAndMouseUnitTest
    {
        [TestMethod]
        public void WhoCaoughtTheMouse()
        {
            Assert.AreEqual("Cat B", Problems.CatsAndMouse.catAndMouse(1, 2, 3));
            Assert.AreEqual("Cat A", Problems.CatsAndMouse.catAndMouse(6, 2, 7));
            Assert.AreEqual("Mouse C", Problems.CatsAndMouse.catAndMouse(1, 3, 2));
            Assert.AreEqual("Mouse C", Problems.CatsAndMouse.catAndMouse(0, 0, 0));

        }
    }
}
