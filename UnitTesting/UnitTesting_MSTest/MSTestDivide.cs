using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestDivide : MSTestBase
    {
        [TestMethod]
        [DataRow(4, 4, 1)]
        [DataRow(8.28, 2.3, 3.6)]
        [DataRow(-300, -5, 60)]
        [DataRow(7, -7, -1)]
        [DataRow(0, 3, 0)]
        [DataRow(3, 0, double.PositiveInfinity)]
        public void VerifyDivideTwoDoubles(double firstInput, double secondInput, double expectedResult)
        {
            var actualResult = _calculator.Divide(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }

}
