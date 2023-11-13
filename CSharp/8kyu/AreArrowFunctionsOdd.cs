using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/559f80b87fa8512e3e0000f5/csharp

Time to test your basic knowledge in functions! Return the odds from a list:

[1, 2, 3, 4, 5]  -->  [1, 3, 5]
[2, 4, 6]        -->  []
*/

namespace CSharp._8kyu
{
    public class AreArrowFunctionsOdd
    {
        public static List<int> Odds(List<int> values) => values.Where(num => num % 2 != 0).ToList();
    }
}
