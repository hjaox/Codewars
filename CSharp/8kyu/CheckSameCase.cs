using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/csharp


Write a function that will check if two given characters are the same case.

If either of the characters is not a letter, return -1
If both characters are the same case, return 1
If both characters are letters, but not the same case, return 0
Examples
'a' and 'g' returns 1

'A' and 'C' returns 1

'b' and 'G' returns 0

'B' and 'g' returns 0

'0' and '?' returns -1
*/

namespace CSharp._8kyu
{
    public class CheckSameCase
    {
        public static int SameCase(char a, char b)
        {
            if (!Char.IsLetter(a) || !Char.IsLetter(b)) return -1;

            return Char.IsUpper(a) == Char.IsUpper(b) ? 1 : 0;
        }
    }
}
