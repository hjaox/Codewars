using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class SuperDuperEasyTest {

    [Test]
    public void BasicTests() {
        ClassicAssert.AreEqual("Error", SuperDuperEasy.Problem("hello"));
        ClassicAssert.AreEqual("56", SuperDuperEasy.Problem("1"));
        ClassicAssert.AreEqual("256", SuperDuperEasy.Problem("5"));
        ClassicAssert.AreEqual("6", SuperDuperEasy.Problem("0"));
        ClassicAssert.AreEqual("66", SuperDuperEasy.Problem("1.2")); 
    }
}