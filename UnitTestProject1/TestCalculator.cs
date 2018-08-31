using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculator
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void testadd()
        {
            tests.Calculator testCalculator = new tests.Calculator();

            int resExpected = 4;
            int resActual = 0;

            resActual = testCalculator.addi(1, 3);

            Assert.AreEqual(resExpected, resActual);
        }
    }
}
