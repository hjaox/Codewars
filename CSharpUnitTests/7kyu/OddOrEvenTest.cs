using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class OddOrEvenTest {
    [Test]
    public void BasicTests() {
        ClassicAssert.AreEqual("even", OddOrEven.OddOrEvenKata(new int[] {0}));
        ClassicAssert.AreEqual("odd", OddOrEven.OddOrEvenKata(new int[] {1}));
        ClassicAssert.AreEqual("even", OddOrEven.OddOrEvenKata(new int[] {}));
    }

    [Test]
    public void EvenTests() {
        ClassicAssert.AreEqual("even", OddOrEven.OddOrEvenKata(new int[] {0, 1, 5}));
        ClassicAssert.AreEqual("even", OddOrEven.OddOrEvenKata(new int[] {0, 1, 3}));
        ClassicAssert.AreEqual("even", OddOrEven.OddOrEvenKata(new int[] {1023, 1, 2}));
    }

    [Test]
    public void OddTests() {
        ClassicAssert.AreEqual("odd", OddOrEven.OddOrEvenKata(new int[] {0, 1, 2}));
        ClassicAssert.AreEqual("odd", OddOrEven.OddOrEvenKata(new int[] {0, 1, 4}));
        ClassicAssert.AreEqual("odd", OddOrEven.OddOrEvenKata(new int[] {1023, 1, 3}));
    }
}