using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class SortTheGiftCodeTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual("abcdef", SortTheGiftCode.SortTheGiftCodeKata("abcdef"));
        ClassicAssert.AreEqual("kpqsuvy", SortTheGiftCode.SortTheGiftCodeKata("pqksuvy"));
        ClassicAssert.AreEqual("abcdefghijklmnopqrstuvwxyz", SortTheGiftCode.SortTheGiftCodeKata("zyxwvutsrqponmlkjihgfedcba"));
    }
}