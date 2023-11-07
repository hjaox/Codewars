using CSharp;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTests
{
    [TestFixture]
    public class NBAFull48MinutesAverageTest
    {
        [Test]
        public void BasicTest()
        {
            ClassicAssert.AreEqual(28.8, NBAFull48MinutesAverage.NbaExtrap(12, 20));
            ClassicAssert.AreEqual(48.0, NBAFull48MinutesAverage.NbaExtrap(10, 10));
            ClassicAssert.AreEqual(14.1, NBAFull48MinutesAverage.NbaExtrap(5, 17));
            ClassicAssert.AreEqual(0, NBAFull48MinutesAverage.NbaExtrap(0, 0));
            ClassicAssert.AreEqual(42.6, NBAFull48MinutesAverage.NbaExtrap(30.8, 34.7));
            ClassicAssert.AreEqual(32.5, NBAFull48MinutesAverage.NbaExtrap(22.9, 33.8));
        }
    }
}
