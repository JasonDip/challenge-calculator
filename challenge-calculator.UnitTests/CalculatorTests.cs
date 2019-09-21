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
            List<double> numbers = new List<double>() { 20 };

            double result = Calculator.Add(numbers);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_2Numbers_ReturnsCorrectResult()
        {
            List<double> numbers = new List<double>() { 1, 5 };

            double result = Calculator.Add(numbers);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Add_3Numbers_ReturnsCorrectResult()
        {
            List<double> numbers = new List<double>() { 1, 2, 0 };

            double result = Calculator.Add(numbers);

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void Add_12Numbers_ReturnsCorrectResult()
        {
            List<double> numbers = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            double result = Calculator.Add(numbers);

            Assert.AreEqual(78, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Add_NegativeNumbers_CreatesException()
        {
            Calculator.allowNegativeNumbers = false;
            List<double> numbers = new List<double>() { 1, 2, 3, -4, -5 };

            double result = Calculator.Add(numbers);
        }

        [TestMethod]
        public void Add_HigherThanUpperLimitNumber_NumberIsIgnored()
        {
            List<double> numbers = new List<double>() { 2, Calculator.upperBound+1, 6 };

            double result = Calculator.Add(numbers);

            Assert.AreEqual(8, result);
        }
    }
}
