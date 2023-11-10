using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class PredictYourAgeTest
    {
        [Test]
        public void BasicTest()
        {
            ClassicAssert.AreEqual(86, PredictYourAge.PredictAge(65, 60, 75, 55, 60, 63, 64, 45));
            ClassicAssert.AreEqual(79, PredictYourAge.PredictAge(32, 54, 76, 65, 34, 63, 64, 45));
        }
    }
}
