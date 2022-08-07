using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]

    public class NUnitTestAbs : NUnitTestBase
    {
        [Test]
        [TestCase(-123, 123)]
        [TestCase(123, 123)]
        [TestCase(-12.3, 12.3)]
        [TestCase(-12.7, 12.7)]

        [TestCase(12.3, 12.3)]
        [TestCase(0, 0)]
        [TestCase("-123", 123)]
        [TestCase("123", 123)]
        [TestCase("-12.3", 12.3)]
        [TestCase("-12.7", 12.7)]
        [TestCase("12.3", 12.3)]
        [TestCase("0", 0)]
        public void VerifyAbsForCorrectValues(object input, double expectedAbs)
        {
            var valueAbs = _calculator.Abs(input);
            Assert.AreEqual(expectedAbs, valueAbs);
        }

        [Test]
        public void VerifyIncorrectInput()
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Abs("test1"));
        }
    }
}

