using CSharpCalculator;
using NUnit.Framework;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.Fixtures)]
    public class NUnitTestIsPositive : NUnitTestBase
    {
        [Test]
        [TestCase(10, true)]
        [TestCase(-10, false)]
        [TestCase(10.5, true)]
        [TestCase(-10.5, false)]
        [TestCase("10", true)]
        [TestCase("-10", false)]
        [TestCase("10.5", true)]
        [TestCase("-10.5", false)]
        public void VerifyIsPositiveForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}



