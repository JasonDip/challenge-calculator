using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace challenge_calculator.UnitTests
{
    [TestClass]
    public class InputParserTests
    {
        [TestMethod]
        public void parseStringToList_TwoNumbers_ReturnsEqualList()
        {
            List<int> numbers = new List<int>();
            List<int> expectedNumbers = new List<int>() { 5000, 1 };

            numbers = InputParser.parseStringToList("5000,1");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void parseStringToList_NumberAndLetters_LettersReturnedAs0()
        {
            List<int> numbers = new List<int>();
            List<int> expectedNumbers = new List<int>() { 5, 0 };

            numbers = InputParser.parseStringToList("5, tyty");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void parseStringToList_BlankNumber_BlanksAre0()
        {
            List<int> numbers = new List<int>();
            List<int> expectedNumbers = new List<int>() { 5, 0 };

            numbers = InputParser.parseStringToList("5, ");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }
    }
}
