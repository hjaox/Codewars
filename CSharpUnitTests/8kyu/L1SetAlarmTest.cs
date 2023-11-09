using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class L1SetAlarmTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(L1SetAlarm.SetAlarm(true, true), Is.False);
            Assert.That(L1SetAlarm.SetAlarm(false, true), Is.False);
            Assert.That(L1SetAlarm.SetAlarm(true, false), Is.True);
            Assert.That(L1SetAlarm.SetAlarm(false, false), Is.False);
        }
    }
}
