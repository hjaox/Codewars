using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class AStrangeTripToTheMarketTest
    {
        [Test]
        public void BasicTests()
        {
            string testInput = "Your girlscout cookies are ready to ship. Your total comes to tree fiddy";
            Assert.That(AStrangeTripToTheMarket.IsLockNessMonster(testInput), Is.True);

            testInput = "Yo, I heard you were on the lookout for Nessie. Let me know if you need assistance.";
            Assert.That(AStrangeTripToTheMarket.IsLockNessMonster(testInput), Is.False);
        }
    }
}
