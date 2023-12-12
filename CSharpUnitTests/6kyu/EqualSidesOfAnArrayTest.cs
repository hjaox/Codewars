using CSharp._6kyu;

namespace CSharpUnitTests._6kyu;

[TestFixture]
public class EqualSidesOfAnArrayTest {
    [Test]
    public void BasicTests() {
        ClassicAssert.AreEqual(3,EqualSidesOfAnArray.FindEvenIndex(new int[] {1,2,3,4,3,2,1}));
        ClassicAssert.AreEqual(1,EqualSidesOfAnArray.FindEvenIndex(new int[] {1,100,50,-51,1,1}));
        ClassicAssert.AreEqual(-1,EqualSidesOfAnArray.FindEvenIndex(new int[] {1,2,3,4,5,6}));
        ClassicAssert.AreEqual(3,EqualSidesOfAnArray.FindEvenIndex(new int[] {20,10,30,10,10,15,35}));
    }
}