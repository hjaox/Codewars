using CSharp._7kyu;

namespace CSharpUnitTests._7kyu;

[TestFixture]
public class AlphabetSymmetryTest {
    [Test]
    public void BasicTests() {

        Assert.That(AlphabetSymmetry.Solve(new List<string> {"abode", "ABc", "xyzD"}), Is.EqualTo(new List<int> {4, 3, 1}));
        Assert.That(AlphabetSymmetry.Solve(new List<string> {"abide", "ABc", "xyz"}), Is.EqualTo(new List<int> {4, 3, 0}));
        Assert.That(AlphabetSymmetry.Solve(new List<string> {"IAMDEFANDJKL", "thedefgh", "xyzDEFghijabc"}), Is.EqualTo(new List<int> {6, 5, 7}));
        Assert.That(AlphabetSymmetry.Solve(new List<string> {"encode", "abc", "xyzD", "ABmD"}), Is.EqualTo(new List<int> {1, 3, 1, 3}));
    }
}