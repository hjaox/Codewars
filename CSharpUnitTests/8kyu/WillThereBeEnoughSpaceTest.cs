using CSharp._8kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class WillThereBeEnoughSpaceTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(WillThereBeEnoughSpace.Enough(10, 5, 5), Is.EqualTo(0));
            Assert.That(WillThereBeEnoughSpace.Enough(100, 60, 50), Is.EqualTo(10));
            Assert.That(WillThereBeEnoughSpace.Enough(20, 5, 5), Is.EqualTo(0));
        }
    }
}
