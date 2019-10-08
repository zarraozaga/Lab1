using System;
using TechTalk.SpecFlow;

namespace ICT3101_Calculator.UnitTests
{
    [Binding]
    public class DivisionSteps
    {
        [When(@"I have entered ""(.*)"" into the calculator")]
        public void WhenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I have entered ""(.*)"" in the calculatorand press divide")]
        public void WhenIHaveEnteredInTheCalculatorandPressDivide(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
