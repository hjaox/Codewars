using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class ThinkfulNumberDrillsBlueAndRedMarblesTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(ThinkfulNumberDrillsBlueAndRedMarbles.GuessBlue(5, 5, 2, 3), Is.EqualTo(0.6));
            Assert.That(ThinkfulNumberDrillsBlueAndRedMarbles.GuessBlue(5, 7, 4, 3), Is.EqualTo(0.2));
            Assert.That(ThinkfulNumberDrillsBlueAndRedMarbles.GuessBlue(12, 18, 4, 6), Is.EqualTo(0.4));
        }
    }
}
