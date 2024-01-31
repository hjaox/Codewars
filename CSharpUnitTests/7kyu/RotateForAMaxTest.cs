using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class RotateForAMaxTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(RotateForAMax.MaxRot(38458215), Is.EqualTo(85821534));
            Assert.That(RotateForAMax.MaxRot(195881031), Is.EqualTo(988103115));
            Assert.That(RotateForAMax.MaxRot(896219342), Is.EqualTo(962193428));
            Assert.That(RotateForAMax.MaxRot(69418307), Is.EqualTo(94183076));
        }
    }
}
