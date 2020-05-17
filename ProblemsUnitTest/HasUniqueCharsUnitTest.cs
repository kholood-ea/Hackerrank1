using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class HasUniqueCharsUnitTest
    {
        [TestMethod]
        public void CheckWordShouldReturnFalse_AllCharsDuplicate()
        {
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("aaaaaaaaaaaaa"));

        }

        [TestMethod]
        public void CheckWordShouldReturnFalse_1st2CharsDuplicate()
        {
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("aabcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("bbcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("ccdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("ddefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("eefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("ffghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("gghijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("hhijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("iijklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("jjklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("kklmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("llmnopqrstuvwxyz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("aa"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("allmnopqrstuvwxyza"));




        }

        [TestMethod]
        public void CheckWordShouldReturnFalse_last2CharsDuplicate()
        {
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvwxyzz"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvwxyy"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvwxx"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvww"));
            Assert.AreEqual(false, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvv"));

        }


        [TestMethod]
        public void CheckWordShouldReturnTrue()
        {
            Assert.AreEqual(true, Problems.HasUniqueChars.CheckWord("abcdefghijklmnopqrstuvwxyz"));
            Assert.AreEqual(true, Problems.HasUniqueChars.CheckWord("abcdefghijk lmnopqrstuvwxyz"));
            Assert.AreEqual(true, Problems.HasUniqueChars.CheckWord(""));
            Assert.AreEqual(true, Problems.HasUniqueChars.CheckWord("aA"));

        }

    }
}
