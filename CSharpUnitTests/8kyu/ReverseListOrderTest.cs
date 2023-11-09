using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class ReverseListOrderTest
    {
        [Test]
        public void BasicTests()
        {
            List<int> testInput = new List<int> { 1, 2, 3, 4 };
            List<int> expected = new List<int> { 4, 3, 2, 1 };
            Assert.That(ReverseListOrder.ReverseList(testInput), Is.EqualTo(expected));
        }

        [Test]
        public void ReturnsNewArray()
        {
            List<int> testInput = new List<int> { 1, 2, 3, 4, 5 };
            Assert.That(ReverseListOrder.ReverseList(testInput), Is.Not.SameAs(testInput));
        }
    }
}
