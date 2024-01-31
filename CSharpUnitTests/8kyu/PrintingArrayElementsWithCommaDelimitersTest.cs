using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class PrintingArrayElementsWithCommaDelimitersTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.That(PrintingArrayElementsWithCommaDelimiters.PrintArray(new object[] { 2, 4, 5, 2}), Is.EqualTo("2,4,5,2"));
        }
    }
}
