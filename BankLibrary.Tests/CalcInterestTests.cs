using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Xunit.Sdk;
using BankingLibrary;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [Test]
        public void InterestCalculation_testing()
        {
            int ExpectedResult = 20;
            ICalcInterest calcInterest = new CalcInterest();
            int actualResult = calcInterest.Calculate(1000, 2, 1);
            NUnit.Framework.Assert.That(actualResult, Is.EqualTo(ExpectedResult));

        }

    }
}