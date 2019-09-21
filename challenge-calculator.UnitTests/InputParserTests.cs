using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace challenge_calculator.UnitTests
{
    [TestClass]
    public class InputParserTests
    {
        [TestMethod]
        public void ParseStringToList_TwoNumbers_ReturnsEqualList()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 5000, 1 };

            numbers = InputParser.ParseStringToList("5000,1");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_NumberAndLetters_LettersReturnedAs0()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 5, 0 };

            numbers = InputParser.ParseStringToList("5, tyty");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_BlankNumber_BlanksAre0()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 5, 0 };

            numbers = InputParser.ParseStringToList("5, ");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_NewLineDelimiter_ReturnsEqualList()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 1, 2, 3 };

            numbers = InputParser.ParseStringToList("1\n2\n3");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_SlashNDelimiter_ReturnsEqualList()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 1, 2, 3 };

            numbers = InputParser.ParseStringToList("1\\n2\\n3");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_NewLineAndCommaMixedDelimiter_ReturnsEqualList()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 1, 2, 3 };

            numbers = InputParser.ParseStringToList("1\\n2,3");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }

        [TestMethod]
        public void ParseStringToList_CustomSingleCharacterDelimiter_ReturnsEqualList()
        {
            List<double> numbers = new List<double>();
            List<double> expectedNumbers = new List<double>() { 2, 5 };

            numbers = InputParser.ParseStringToList("//;\\n2;5");

            CollectionAssert.AreEqual(expectedNumbers, numbers);
        }
    }
}
