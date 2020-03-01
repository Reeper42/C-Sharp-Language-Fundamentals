
using NUnit.Framework;
using SG.Calculator.BLL;
using System;

namespace SG.Calculator.Tests
{
    [TestFixture]
    public class SimpleMathTests
    {
        [TestCase(4, 2, 2)]
        [TestCase(13, 6, 2)]
        [TestCase(-20, 5, -4)]
        public void IntegerDivision(int x, int y, int expected)
        {
            SimpleMath math = new SimpleMath();
            int actual = math.Divide(x, y);
            Assert.AreEqual(expected, actual);
        }
    }
}
