using CSharpCalculator;
using NUnit.Framework;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestMultiply : NUnitTestBase
    {
        [Test]
        [TestCase(3, 4, 12)]
        [TestCase(11.7, 2.3, 26.91)]
        [TestCase(-120, -5, 600)]
        [TestCase(7, -7, -49)]
        [TestCase(double.MaxValue, 10, double.MaxValue)]
        [TestCase(0, 3, 0)]
        public void VerifyMultiplyTwoDoubles(double firstInput, double secondInput, double expectedResult)
        {
            var actualResult = _calculator.Multiply(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
