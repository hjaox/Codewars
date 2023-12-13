using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class UEFAEURO2016Test {
    [Test]
    public void BasicTests() {
        ClassicAssert.AreEqual("At match Germany - Ukraine, Germany won!", UEFAEURO2016.UefaEuro2016(new [] { "Germany", "Ukraine"}, new [] { 2, 0 }));
        ClassicAssert.AreEqual("At match Belgium - Italy, Italy won!", UEFAEURO2016.UefaEuro2016(new [] { "Belgium", "Italy"}, new [] { 0, 2 }));
        ClassicAssert.AreEqual("At match Portugal - Iceland, teams played draw.", UEFAEURO2016.UefaEuro2016(new [] { "Portugal", "Iceland"}, new [] { 1, 1 }));
    }
}