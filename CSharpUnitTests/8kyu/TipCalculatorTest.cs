using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class TipCalculatorTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual(4, TipCalculator.CalculateTip(20, "Excellent"));
        ClassicAssert.AreEqual(3, TipCalculator.CalculateTip(26.95, "good"));
    }
}