using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class FuelCalculatorTotalCostTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(FuelCalculatorTotalCost.FuelPrice(5, 1.23), Is.EqualTo(5.65));
            Assert.That(FuelCalculatorTotalCost.FuelPrice(8, 2.5), Is.EqualTo(18.40));
            Assert.That(FuelCalculatorTotalCost.FuelPrice(5, 5.6), Is.EqualTo(27.50));
        }

        [Test]
        public void AdditionalTests()
        {
            Assert.That(FuelCalculatorTotalCost.FuelPrice(169, 12.71), Is.EqualTo(2105.74));
            Assert.That(FuelCalculatorTotalCost.FuelPrice(7, 35.14), Is.EqualTo(244.93));
        }
    }
}
