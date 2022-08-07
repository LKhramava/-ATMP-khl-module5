using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestMultiply : MSTestBase
    {
        [TestMethod]
        [DataRow(3, 4, 12)]
        [DataRow(11.7, 2.3, 26.91)]
        [DataRow(-120, -5, 600)]
        [DataRow(7, -7, -49)]
        [DataRow(double.MaxValue, 10, double.MaxValue)]
        [DataRow(0, 3, 0)]
        public void VerifyMultiplyTwoDoubles(double firstInput, double secondInput, double expectedResult)
        {
            var actualResult = _calculator.Multiply(firstInput, secondInput);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
