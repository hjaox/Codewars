using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class NumberOfDecimalDigitsTest {
    [Test]
    public void BasicTests() {
        Assert.That(NumberOfDecimalDigits.Digits(5ul), Is.EqualTo(1));
        Assert.That(NumberOfDecimalDigits.Digits(12345ul), Is.EqualTo(5));
        Assert.That(NumberOfDecimalDigits.Digits(9876543210ul), Is.EqualTo(10));
    }
}