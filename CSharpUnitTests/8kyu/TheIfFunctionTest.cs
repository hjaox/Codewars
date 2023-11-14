using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class TheIfFunctionTest
    {
        [Test]
        public void BasicTests()
        {
            bool testVal = false;

            TheIfFunction.If(true, () => testVal = true, () => testVal = false);

            Assert.That(testVal, Is.True);

            TheIfFunction.If(false, () => testVal = true, () => testVal = false);

            Assert.That(testVal, Is.False);
        }
    }
}