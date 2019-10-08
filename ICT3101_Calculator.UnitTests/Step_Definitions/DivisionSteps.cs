using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Lab1;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class DivisionSteps 
    {
        private Calculator _calculator;
        private double _result;

        public DivisionSteps(Calculator calc)
        {
            _calculator = calc;
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be Infinity on the screen")]
        public void ThenTheDivisionResultShouldBeInfinityOnTheScreen()
        {
            Assert.That(_result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
