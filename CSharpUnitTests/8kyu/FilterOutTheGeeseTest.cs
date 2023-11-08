using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharp;
using NUnit.Framework.Interfaces;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class FilterOutTheGeeseTest
    {
        [Test]
        public void BasicTests()
        {
            string[] testInput = { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" };
            string[] expected = { "Mallard", "Hook Bill", "Crested", "Blue Swedish" };

            Assert.That(FilterOutTheGeese.GooseFilter(testInput), Is.EqualTo(expected));

            testInput = new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" };
            expected = new string[] { "Mallard", "Barbary", "Hook Bill", "Blue Swedish", "Crested" };

            Assert.That(FilterOutTheGeese.GooseFilter(testInput), Is.EqualTo(expected));

            testInput = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };
            expected = new string[] { };

            Assert.That(FilterOutTheGeese.GooseFilter(testInput), Is.EqualTo(expected));
        } 
    }
}
