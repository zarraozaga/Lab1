﻿using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Lab1;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class AdditionSteps
    {
        private Calculator _calculator;
        private double _result;

        public AdditionSteps(Calculator c)
        {
            _calculator = c;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        [When(@"I enter ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIEnterAndIntoTheCalculatorAndPressAdd(int p0, int p1)
        {
            _result = _calculator.Add(p0, p1);
        }

        [Then(@"the result should show ""(.*)"" on the screen")]
        public void ThenTheResultShouldShowOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
