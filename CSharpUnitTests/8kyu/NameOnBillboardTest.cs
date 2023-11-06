using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharpUnitTests
{
    [TestFixture]
    public class NameOnBillboardTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(NameOnBillboard.Billboard("Jeong-Ho Aristotelis"), Is.EqualTo(600));
            Assert.That(NameOnBillboard.Billboard("CODEWARS", 5), Is.EqualTo(40));
        }

        [Test]
        public void ZeroTest()
        {
            Assert.That(NameOnBillboard.Billboard("CODEWARS", 0), Is.EqualTo(0));
        }

        [Test]
        public void DoesNotContainMultiSignTest() { }
    }
}
