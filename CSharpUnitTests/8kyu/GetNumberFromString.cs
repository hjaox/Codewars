using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class GetNimberFromStringTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual(1, GetNumberFromString.GetNumberFromStringKata("1"));
        ClassicAssert.AreEqual(123, GetNumberFromString.GetNumberFromStringKata("123"));
        ClassicAssert.AreEqual(7, GetNumberFromString.GetNumberFromStringKata("this is number: 7"));
    }
}