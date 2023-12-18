using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class SleighAuthenticationTest {
    [Test]
    public void BasicTests() {
        Assert.That(SleighAuthentication.Authenticate("Santa Claus", "Ho Ho Ho!"));
        Assert.That(!SleighAuthentication.Authenticate("Santa", "Ho Ho Ho!"));
        Assert.That(!SleighAuthentication.Authenticate("Santa Claus", "Ho Ho!"));
        Assert.That(!SleighAuthentication.Authenticate("jhoffner", "CodeWars"));
    }
}