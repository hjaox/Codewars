using CSharp._8kyu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class CovertToBinaryTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(1, CovertToBinary.ToBinary(1));
            ClassicAssert.AreEqual(10, CovertToBinary.ToBinary(2));
            ClassicAssert.AreEqual(11, CovertToBinary.ToBinary(3));
            ClassicAssert.AreEqual(101, CovertToBinary.ToBinary(5));
        }
    }
}
