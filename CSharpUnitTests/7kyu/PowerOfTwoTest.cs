using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class PowerOfTwoTest
{
    [Test]
    public void BasicTests()
    {
        Assert.That(PowerOfTwo.PowerOfTwoKata(2), Is.True);
        Assert.That(PowerOfTwo.PowerOfTwoKata(4096), Is.True);
        Assert.That(PowerOfTwo.PowerOfTwoKata(5), Is.False);
    }
}