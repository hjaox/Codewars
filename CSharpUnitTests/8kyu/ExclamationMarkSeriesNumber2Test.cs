using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class ExclamationMarkSeriesNumber2Test
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(ExclamationMarkSeriesNumber2.Remove("Hi!"), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarkSeriesNumber2.Remove("Hi!!!"), Is.EqualTo("Hi"));
            Assert.That(ExclamationMarkSeriesNumber2.Remove("!Hi"), Is.EqualTo("!Hi"));
            Assert.That(ExclamationMarkSeriesNumber2.Remove("Hi! Hi"), Is.EqualTo("Hi! Hi"));
            Assert.That(ExclamationMarkSeriesNumber2.Remove("Hi"), Is.EqualTo("Hi"));
        }
    }
}
