using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace challenge_calculator.UnitTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_1Number_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 20 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_2Numbers_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 1, 5000 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(5001, result);
        }

        [TestMethod]
        public void Add_3Numbers_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 1, 2, 0 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_12Numbers_ReturnsCorrectResult()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            int result = Calculator.Add(numbers);

            Assert.AreEqual(78, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Add_NegativeNumbers_CreatesException()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, -4, -5 };

            int result = Calculator.Add(numbers);
        }
    }
}
