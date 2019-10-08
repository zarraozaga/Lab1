using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Lab1;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class MTBFSteps
    {
        private Calculator _calculator;
        private double _result;

        public MTBFSteps(Calculator c)
        {
            _calculator = c;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(double p0, double p1)
        {
            _result = _calculator.MTBF(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(double p0, double p1)
        {
            _result = _calculator.Availability(p0, p1);
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(double p0)
        {
            Assert.AreEqual(_result, p0, 0.00001);

        }
    }
}
