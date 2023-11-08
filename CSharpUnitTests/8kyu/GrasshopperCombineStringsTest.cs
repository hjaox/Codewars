using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;
using NUnit.Framework.Legacy;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class GrasshopperCombineStringsTest
    {
        [Test]
        public void BasicTest()
        {
            ClassicAssert.AreEqual("James Stevens", GrasshopperCombineStrings.CombineNames("James", "Stevens"));
        }
    }
}
