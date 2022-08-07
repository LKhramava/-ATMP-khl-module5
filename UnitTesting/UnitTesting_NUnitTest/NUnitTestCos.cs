using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestCos : NUnitTestBase
    {
        [Test]
        [TestCase(0, 1)]
        [TestCase(60, 0.5)]
        [TestCase(90, 0)]
        [TestCase(270, 0)]
        [TestCase(360, 1)]
        [TestCase("0", 1)]
        [TestCase("60", 0.5)]
        [TestCase("90", 0)]
        [TestCase("270", 0)]
        [TestCase("360", 1)]
        public void VerifyCosForCorrectValues(object input, double expectedResult)
        {
            double inputInRadians = (Convert.ToDouble(input) * (Math.PI)) / 180;
            
            var actualResult = _calculator.Cos(inputInRadians);
            actualResult = Math.Round(actualResult, 1);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void VerifyIncorrectInput()
        {
            Assert.Throws<NotFiniteNumberException>(() => _calculator.Cos("test1"));
        }
    }
}



