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

        [TestMethod]
        public void FlipBit()
        {
            var kata = new Kata();
            Assert.AreEqual(7, kata.FlipBit(15, 4));
            Assert.AreEqual(1, kata.FlipBit(0, 1));
            Assert.AreEqual(14, kata.FlipBit(15, 1));
            Assert.AreEqual(32768, kata.FlipBit(0, 16));
            Assert.AreEqual(255, kata.FlipBit(127, 8));
        }

        [TestMethod]
        public void BouncingBall()
        {
            var kata = new Kata();
            Assert.AreEqual(3, kata.BouncingBall(3.0, 0.66, 1.5));
            Assert.AreEqual(15, kata.BouncingBall(30.0, 0.66, 1.5));
        }

        [TestMethod]
        public void BuyingACar()
        {
            var kata = new Kata();
            int[] r = new int[] { 6, 766 };
            var actualResult = kata.BuyingACar(2000, 8000, 1000, 1.5);
            Assert.AreEqual(6, actualResult[0]);
            Assert.AreEqual(766, actualResult[1]);

            actualResult = kata.BuyingACar(12000, 8000, 1000, 1.5);
            Assert.AreEqual(0, actualResult[0]);
            Assert.AreEqual(4000, actualResult[1]);
        }
    }
}
