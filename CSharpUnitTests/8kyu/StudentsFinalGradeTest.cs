using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp._8kyu;

namespace CSharpUnitTests._8kyu
{
    [TestFixture]
    public class StudentsFinalGradeTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(StudentsFinalGrade.FinalGrade(100, 12), Is.EqualTo(100));
            Assert.That(StudentsFinalGrade.FinalGrade(85, 5), Is.EqualTo(90));
        }
    }
}
