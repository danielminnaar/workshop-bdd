using Calculator;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the project is setup")]
        public void GivenTheProjectIsSetup()
        {
            _result = RetailCalculator.TotalAmount();
        }

        [Then(@"the test will pass")]
        public void ThenTheTestWillPass()
        {
            Assert.Equal(0, _result);
        }

    }
}
