using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestIsPositive : MSTestBase
    {
        [TestMethod]
        [DataRow(10, true)]
        [DataRow(-10, false)]
        [DataRow(10.5, true)]
        [DataRow(-10.5, false)]
        [DataRow("10", true)]
        [DataRow("-10", false)]
        [DataRow("10.5", true)]
        [DataRow("-10.5", false)]
        public void VerifyIsPositiveForCorrectValues(object input, bool expectedResult)
        {
            var actualResult = _calculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}



