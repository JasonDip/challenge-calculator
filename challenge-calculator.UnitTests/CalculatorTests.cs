using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace challenge_calculator.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_OneNumber_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 20 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_TwoNumbers_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 1, 5000 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(5001, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Add_ThreeNumbers_ThrowException()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int result = Calculator.Add(numbers);
        }
    }
}
