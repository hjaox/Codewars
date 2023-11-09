using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class SortNumbersTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(SortNumbers.SortNumbersFunc(new int[] { 1, 2, 3, 10, 5 }), Is.Ordered.Ascending);
        }

        [Test]
        public void ReturnsNewArray()
        {
            int[] testInput = { 5, 4, 3, 2, 1 };
            Assert.That(SortNumbers.SortNumbersFunc(testInput), Is.Not.SameAs(testInput));
        }
    }
}
