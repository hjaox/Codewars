using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class MaxLengthDifferenceTest {
    [Test]
    public void BasicTests() {
        string[] s1 = new string[]{"hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"};
        string[] s2 = new string[]{"cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"};
        ClassicAssert.AreEqual(13, MaxLengthDifference.Mxdiflg(s1, s2));
    }
}