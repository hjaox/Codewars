using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class AlphabetWarTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual("Right side wins!", AlphabetWar.AlphabetWarKata("z"));
            ClassicAssert.AreEqual("Let's fight again!", AlphabetWar.AlphabetWarKata("zdqmwpbs"));
            ClassicAssert.AreEqual("Right side wins!", AlphabetWar.AlphabetWarKata("zzzzs"));
            ClassicAssert.AreEqual("Left side wins!", AlphabetWar.AlphabetWarKata("wwwwwwz"));
        }
    }
}