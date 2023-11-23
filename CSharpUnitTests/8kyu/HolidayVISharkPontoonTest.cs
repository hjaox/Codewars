using CSharp._8kyu;

namespace CSharpUnitTests._8kyu;

[TestFixture]
public class HolidayVISharkPontoonTest
{
    [Test]
    public void BasicTests()
    {
        ClassicAssert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(12, 50, 4, 8, true));
        ClassicAssert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(12, 50, 4, 8, false));
        ClassicAssert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(7, 55, 4, 16, true));
        ClassicAssert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(24, 0, 4, 8, true));
        ClassicAssert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(40, 35, 3, 20, true));
        ClassicAssert.AreEqual("Alive!", HolidayVISharkPontoon.Shark(7, 8, 3, 4, true));
        ClassicAssert.AreEqual("Shark Bait!", HolidayVISharkPontoon.Shark(7, 8, 3, 4, false));
    }
}