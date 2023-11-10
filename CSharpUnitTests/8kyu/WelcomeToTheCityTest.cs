using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class WelcomeToTheCityTest
    {
        [Test]
        public void BasicTests()
        {
            ClassicAssert.AreEqual("Hello, John Smith! Welcome to Phoenix, Arizona!", WelcomeToTheCity.SayHello(new string[] { "John", "Smith" }, "Phoenix", "Arizona"));
        }
    }
}
