using CSharp;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class IsItANumberTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(IsItANumber.IsDigit("s2324"), Is.EqualTo(false));
            Assert.That(IsItANumber.IsDigit("-234.4"), Is.EqualTo(true));

        }
    }
}