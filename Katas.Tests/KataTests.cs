using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void SumWithOutHighestAndLowestNumber()
        {
            var kata = new Kata();
            Assert.AreEqual(16, kata.SumWithOutHighestAndLowestNumber(new[] { 6, 2, 1, 8, 10 }));
            Assert.AreEqual(6, kata.SumWithOutHighestAndLowestNumber(new[] { 1, 1, 11, 2, 3 }));
        }
    }
}
