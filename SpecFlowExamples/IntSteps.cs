using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowExamples
{
    [Binding]
    public sealed class IntSteps
    {
        private Calculator calculator;

        public IntSteps()
        {
            calculator = new Calculator();
        }

        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {            
            this.calculator.Enter(number);
        }

        [When("I press add")]
        public void WhenIPressAdd()
        {
            this.calculator.Add();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
            int actualResult = this.calculator.Display;
            Assert.AreEqual(result, actualResult);
        }
    }
}
