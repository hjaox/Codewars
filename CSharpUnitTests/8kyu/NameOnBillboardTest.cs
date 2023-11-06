using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

/*
https://www.codewars.com/kata/570e8ec4127ad143660001fd

You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1 (allways 2 for Java).

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).
*/

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
