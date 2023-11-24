using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class SwitcherooTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual("bac", Switcheroo.SwitcherooKata("abc"));
        ClassicAssert.AreEqual("bbbacccabbb", Switcheroo.SwitcherooKata("aaabcccbaaa"));
        ClassicAssert.AreEqual("ccccc", Switcheroo.SwitcherooKata("ccccc"));
    }
}