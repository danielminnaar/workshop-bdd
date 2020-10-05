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
        private decimal _wrongQuantity;
        private int _quantity;
        private double _price;
        private string _countryCode;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"the quantity is (.*)")]
        public void GivenTheQuantityIs(string p0)
        {
            var success = int.TryParse(p0, out _quantity);
            if (!success)
                decimal.TryParse(p0, out _wrongQuantity);
        }

        [Given(@"the price is (.*)")]
        public void GivenThePriceIs(double p0)
        {
            _price = p0;
        }

        [Then(@"the total amount will be (.*)")]
        public void ThenTheTotalAmountWillBe(double p0)
        {
            Assert.Equal(p0, RetailCalculator.TotalAmount(_quantity, _price, _countryCode));
        }

        [Then(@"the total amount will be error")]
        public void ThenTheTotalAmountWillBeError()
        {
            try
            {
                RetailCalculator.TotalAmount((int)_wrongQuantity, _price, _countryCode);
                Assert.True(false);
            }
            catch
            {
                Assert.True(true);
            }
        }
        [Given(@"the country code is '(.*)'")]
        public void GivenTheCountryCodeIs(string p0)
        {
            _countryCode = p0;
        }

    }
}
