using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class DefineACardSuitTest {
    [Test]
    public void BasicTests() {

        ClassicAssert.AreEqual("clubs", DefineACardSuit.DefineSuit("3♣"), "Should return clubs with \"3♣\"");
        ClassicAssert.AreEqual("spades", DefineACardSuit.DefineSuit("Q♠"), "Should return spades with \"Q♠\"");
        ClassicAssert.AreEqual("diamonds", DefineACardSuit.DefineSuit("9♦"), "Should return diamonds with \"9♦\"");
        ClassicAssert.AreEqual("hearts", DefineACardSuit.DefineSuit("J♥"), "Should return hearts with \"J♥\"");
    }
}