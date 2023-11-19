using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class BasicSubclassesAdamAndEveTest {
    [Test]
    public void BasicTests() {
        Human[] humans = BasicSubclassesAdamAndEve.Create();
        Assert.That(humans[0] is Man);
    }
}