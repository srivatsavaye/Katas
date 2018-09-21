using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.Tests
{
    [TestClass]
    public class KataTests
    {
        private readonly Kata kata = new Kata();
        [TestMethod]
        public void DeNico()
        {
            Assert.AreEqual("secretinformation", kata.DeNico("crazy", "cseerntiofarmit on  "));
            //Assert.AreEqual("secretinformation", kata.DeNico("crazy", "cseerntiofarmit on"));
            //Assert.AreEqual("abcd", kata.DeNico("abc", "abcd"));
            //Assert.AreEqual("1234567890", kata.DeNico("ba", "2143658709"));
            //Assert.AreEqual("message", kata.DeNico("a", "message"));
            //Assert.AreEqual("key", kata.DeNico("key", "eky"));
        }

        [TestMethod]
        public void IsMerge()
        {
            Assert.AreEqual(true, kata.isMerge("Bahamas", "Bahas", "Bananas from am"));
        }

        [TestMethod]
        public void IsAllPossibilities()
        {
            Assert.AreEqual(false, kata.IsAllPossibilities(null));
            Assert.AreEqual(false, kata.IsAllPossibilities(new int[] { }));
            Assert.AreEqual(false, kata.IsAllPossibilities(new[]
            {
                0,
                2,
                19,
                4,
                4,
                3,
                2,
                1,
                0,
                3,
                2,
                10,
                4,
                1,
                6,
                1,
                1,
                8,
                3,
                1,
                1,
                0,
                1,
                2,
                3,
                1,
                2,
                3,
                4,
                0,
                -1,
                2,
                3,
                0,
                2,
                3,
                0
            }));
            //Assert.AreEqual(false, kata.IsAllPossibilities(new[]{ 6, 2, 4, 2, 2, 2, 1, 5, 0, 0 }));

            Assert.AreEqual(false, kata.IsAllPossibilities_copied(new[] { 6, 2, 4, 2, 2, 2, 1, 5, 0, 0 }));
        }

        [TestMethod]
        public void SumWithOutHighestAndLowestNumber()
        {
            Assert.AreEqual(16, kata.SumWithOutHighestAndLowestNumber(new[] { 6, 2, 1, 8, 10 }));
            Assert.AreEqual(6, kata.SumWithOutHighestAndLowestNumber(new[] { 1, 1, 11, 2, 3 }));
        }

        [TestMethod]
        public void FlipBit()
        {
            Assert.AreEqual(7, kata.FlipBit(15, 4));
            Assert.AreEqual(1, kata.FlipBit(0, 1));
            Assert.AreEqual(14, kata.FlipBit(15, 1));
            Assert.AreEqual(32768, kata.FlipBit(0, 16));
            Assert.AreEqual(255, kata.FlipBit(127, 8));
        }

        [TestMethod]
        public void BouncingBall()
        {
            Assert.AreEqual(3, kata.BouncingBall(3.0, 0.66, 1.5));
            Assert.AreEqual(15, kata.BouncingBall(30.0, 0.66, 1.5));
        }

        [TestMethod]
        public void BuyingACar()
        {
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
