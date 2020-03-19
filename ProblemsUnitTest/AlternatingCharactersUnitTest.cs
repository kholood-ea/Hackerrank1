using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemsUnitTest
{
    [TestClass]
    public class AlternatingCharactersUnitTest
    {
        [TestMethod]
        public void alternatingCharactersShouldReturnValue()
        {
            Assert.AreEqual(3,Problems.AlternatingCharacters.alternatingCharacters("aaaa"));
            Assert.AreEqual(4, Problems.AlternatingCharacters.alternatingCharacters("BBBBB"));
            Assert.AreEqual(4, Problems.AlternatingCharacters.alternatingCharacters("AAABBB"));
            Assert.AreEqual(6, Problems.AlternatingCharacters.alternatingCharacters("AAABBBAABB"));
            Assert.AreEqual(4, Problems.AlternatingCharacters.alternatingCharacters("AABBAABB"));
            Assert.AreEqual(1, Problems.AlternatingCharacters.alternatingCharacters("ABABABAA"));
            Assert.AreEqual(3, Problems.AlternatingCharacters.alternatingCharacters("ABBABBAA"));

        }
        [TestMethod]
        public void alternatingCharactersShouldReturn0()
        {
            Assert.AreEqual(0, Problems.AlternatingCharacters.alternatingCharacters("ababab"));
            Assert.AreEqual(0, Problems.AlternatingCharacters.alternatingCharacters("BABABA"));

        }
    }
}
