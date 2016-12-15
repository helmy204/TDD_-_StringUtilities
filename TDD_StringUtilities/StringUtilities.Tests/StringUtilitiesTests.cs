using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace StringUtilities.Tests
{
    [TestClass]
    public class StringUtilitiesTests
    {
        [TestMethod]
        public void ShouldFindOneYInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "y";
            int expectedResult = 1;

            StringUtilitiesClass stringUtilitiesClass = new StringUtilitiesClass();

            int actualResult = stringUtilitiesClass.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldFindTwoSInMysterious()
        {
            string stringToCheck = "mysterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtilitiesClass stringUtilitiesClass = new StringUtilitiesClass();

            int actualResult = stringUtilitiesClass.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void SearchShouldBeCaseInSensetive()
        {
            string stringToCheck = "mySterious";
            string stringToFind = "s";
            int expectedResult = 2;

            StringUtilitiesClass stringUtilitiesClass = new StringUtilitiesClass();

            int actualResult = stringUtilitiesClass.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ShouldBeAbleToHandleNulls()
        {
            string stringToCheck = null;
            string stringToFind = "s";
            int expectedResult = -1;

            StringUtilitiesClass stringUtilitiesClass = new StringUtilitiesClass();

            int actualResult = stringUtilitiesClass.CountOccurences(stringToCheck, stringToFind);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
