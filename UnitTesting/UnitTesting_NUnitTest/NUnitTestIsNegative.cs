using CSharpCalculator;
using NUnit.Framework;

namespace UnitTesting_NUnitTest
{
    [TestFixture]
    [Parallelizable(scope: ParallelScope.All)]
    public class NUnitTestIsNegative : NUnitTestBase
    {
        [Test]
        [TestCase(10, false)]
        [TestCase(-10, true)]
        [TestCase(10.5, false)]
        [TestCase(-10.5, true)]
        [TestCase("10", false)]
        [TestCase("-10", true)]
        [TestCase("10.5", false)]
        [TestCase("-10.5", true)]
        public void VerifyIsNegativeForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}



