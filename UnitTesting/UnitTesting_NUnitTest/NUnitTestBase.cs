using CSharpCalculator;
using NUnit.Framework;
using System;

namespace UnitTesting_NUnitTest
{
	public class NUnitTestBase
	{
        protected Calculator _calculator;

        [SetUp]
        public void TestInit()
        {
            //preconditions for test
            _calculator = new Calculator();
        }

        [TearDown]
        public void TestClean()
        {
            //post conditions for test
        }
    }
}
