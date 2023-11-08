using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp;

namespace CSharpUnitTests
{
    [TestFixture]
    public class AreaOrPerimeterTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual(AreaOrPerimeter.AreaOrPerimeterFunc(4,4), 16);
            ClassicAssert.AreEqual(AreaOrPerimeter.AreaOrPerimeterFunc(6, 10), 32);
        }
    }
}
