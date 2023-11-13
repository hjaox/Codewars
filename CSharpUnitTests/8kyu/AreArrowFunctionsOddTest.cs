using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class AreArrowFunctionsOddTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(AreArrowFunctionsOdd.Odds(new List<int>()), Is.Empty);
            Assert.That(AreArrowFunctionsOdd.Odds(new List<int> { 2, 4, 6}), Is.Empty);
            Assert.That(AreArrowFunctionsOdd.Odds(new List<int> { 1, 3, 5 }), Is.EqualTo(new List<int> { 1, 3, 5 }));
            Assert.That(AreArrowFunctionsOdd.Odds(new List<int> { 1, 2, 3, 4, 5, 6 }), Is.EqualTo(new List<int> { 1, 3, 5 }));

        }
    }
}
