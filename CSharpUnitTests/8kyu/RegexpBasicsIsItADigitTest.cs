using System;
using System.Text;
using System.Text.RegularExpressions;
using CSharp;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class RegexpBasicsIsItADigitTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(false, "".Digit());
            ClassicAssert.AreEqual(true, "7".Digit());
            ClassicAssert.AreEqual(false, " ".Digit());
            ClassicAssert.AreEqual(false, "a".Digit());
            ClassicAssert.AreEqual(false, "a5".Digit());
            ClassicAssert.AreEqual(false, "14".Digit());
        }
    }
}
