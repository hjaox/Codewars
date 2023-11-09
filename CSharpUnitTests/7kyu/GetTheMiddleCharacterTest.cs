using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class GetTheMiddleCharacterTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(GetTheMiddleCharacter.GetMiddle("test"), "es");
            ClassicAssert.AreEqual(GetTheMiddleCharacter.GetMiddle("testing"), "t");
            ClassicAssert.AreEqual(GetTheMiddleCharacter.GetMiddle("middle"), "dd");
            ClassicAssert.AreEqual(GetTheMiddleCharacter.GetMiddle("A"), "A");
        }
    }
}
