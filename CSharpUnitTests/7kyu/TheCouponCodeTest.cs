using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class TheCouponCodeTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(true, TheCouponCode.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
            ClassicAssert.AreEqual(false, TheCouponCode.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
}
