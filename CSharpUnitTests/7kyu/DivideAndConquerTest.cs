using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._7kyu;

namespace CSharpUnitTests._7kyu
{
    [TestFixture]
    public class DivideAndConquerTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(2, DivideAndConquer.DivCon(new object[] { 9, 3, "7", "3" }));
            ClassicAssert.AreEqual(14, DivideAndConquer.DivCon(new object[] { "5", "0", 9, 3, 2, 1, "9", 6, 7 }));
            ClassicAssert.AreEqual(13, DivideAndConquer.DivCon(new object[] { "3", 6, 6, 0, "5", 8, 5, "6", 2, "0" }));
            ClassicAssert.AreEqual(11, DivideAndConquer.DivCon(new object[] { "1", "5", "8", 8, 9, 9, 2, "3" }));
            ClassicAssert.AreEqual(61, DivideAndConquer.DivCon(new object[] { 8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7 }));
            ClassicAssert.AreEqual(-6, DivideAndConquer.DivCon(new object[] { "0", "1", "2", "3" }));
            ClassicAssert.AreEqual(6, DivideAndConquer.DivCon(new object[] { 0, 1, 2, 3 }));
            ClassicAssert.AreEqual(0, DivideAndConquer.DivCon(new object[] { 1, "1" }));
            ClassicAssert.AreEqual(-2, DivideAndConquer.DivCon(new object[] { -1, "1" }));
            ClassicAssert.AreEqual(2, DivideAndConquer.DivCon(new object[] { 1, "-1" }));
            ClassicAssert.AreEqual(1, DivideAndConquer.DivCon(new object[] { 1 }));
            ClassicAssert.AreEqual(-1, DivideAndConquer.DivCon(new object[] { "1" }));
            ClassicAssert.AreEqual(0, DivideAndConquer.DivCon(new object[] { }));
        }
    }
}
