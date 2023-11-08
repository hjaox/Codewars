using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class CheckSameCaseTest
    {
        [Test]
        public void TrueTests()
        {
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('a', 'u'));
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('A', 'U'));
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('Q', 'P'));
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('w', 'y'));
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('c', 'm'));
            ClassicAssert.AreEqual(1, CheckSameCase.SameCase('N', 'W'));
        }

        [Test]
        public void FalseTests()
        {
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('a', 'U'));
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('A', 'u'));
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('Q', 'p'));
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('w', 'Y'));
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('c', 'M'));
            ClassicAssert.AreEqual(0, CheckSameCase.SameCase('N', 'w'));
        }   
            
        [Test]
        public void NotLetters()
        {   
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('a', '*'));
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('A', '%'));
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('Q', '1'));
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('w', '-'));
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('c', '8'));
            ClassicAssert.AreEqual(-1, CheckSameCase.SameCase('N', ':'));
        }
    }
}
