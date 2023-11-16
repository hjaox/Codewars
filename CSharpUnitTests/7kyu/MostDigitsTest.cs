using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class MostDigitsTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual(100, MostDigits.FindLongest(new int[] {1, 10, 100}));
        ClassicAssert.AreEqual(9000, MostDigits.FindLongest(new int[] {9000, 8, 800}));
        ClassicAssert.AreEqual(900, MostDigits.FindLongest(new int[] {8, 900, 500}));
    }
}