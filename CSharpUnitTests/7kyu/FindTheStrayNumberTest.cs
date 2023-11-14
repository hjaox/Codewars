using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class FindTheStrayNumberTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(2, FindTheStrayNumber.Stray(new int[] {1, 1, 2}));
        }
    }
}