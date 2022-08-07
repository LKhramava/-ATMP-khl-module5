using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]

namespace UnitTesting_MSTest
{
    [TestClass]
    public class MSTestAbs : MSTestBase
    {
        [TestMethod]
        [DataRow(-123, 123)]
        [DataRow(123, 123)]
        [DataRow(-12.3, 12.3)]
        [DataRow(-12.7, 12.7)]
        [DataRow(12.3, 12.3)]
        [DataRow(0, 0)]
        [DataRow("-123", 123)]
        [DataRow("123", 123)]
        [DataRow("-12.3", 12.3)]
        [DataRow("12.3", 12.3)]
        public void VerifyAbsForCorrectValues(object input, double expectedAbs)
        {
            var valueAbs = _calculator.Abs(input);
            Assert.AreEqual(expectedAbs, valueAbs);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NotFiniteNumberException))]
        public void VerifyIncorrectInput()
        {
            _calculator.Abs("test1");
        }
    }
}
