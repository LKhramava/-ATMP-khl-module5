using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestSqrt : MSTestBase
    {
        [TestMethod]
        [DataRow(81, 9)]
        [DataRow(-81, double.NaN)]
        [DataRow(0.09, 0.3)]
        [DataRow(-0, 0)]
        [DataRow(0, 0)]
        [DataRow("81", 9)]
        [DataRow("-81", double.NaN)]
        [DataRow("0.09", 0.3)]
        [DataRow("-0", 0)]
        [DataRow("0", 0)]
        public void VerifySqrtForCorrectValues(object input, double expectedResult)
        {
            var actualResult = _calculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.FormatException))]
        public void VerifyIncorrectInput()
        {
            _calculator.Sqrt("test1");
        }
    }
}

