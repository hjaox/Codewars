using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/*
https://www.codewars.com/kata/57faece99610ced690000165/csharp


Remove all exclamation marks from the end of sentence.

Examples
"Hi!"     ---> "Hi"
"Hi!!!"   ---> "Hi"
"!Hi"     ---> "!Hi"
"!Hi!"    ---> "!Hi"
"Hi! Hi!" ---> "Hi! Hi"
"Hi"      ---> "Hi"
*/

namespace CSharp._8kyu
{
    public class ExclamationMarkSeriesNumber2
    {
        public static string Remove(string s)
        {
            return s.TrimEnd('!');
        }
    }
}
