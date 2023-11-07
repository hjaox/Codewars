using System;
using System.Text;
using System.Text.RegularExpressions;

/*
https://www.codewars.com/kata/567bf4f7ee34510f69000032

Implement String#digit? (in Java StringUtils.isDigit(String)), which should return true if given object is a digit (0-9), false otherwise.
*/

namespace CSharp
{
    public static class RegexpBasicsIsItADigit
    {
        public static bool Digit(this string str)
        {
            return Regex.IsMatch(str, @"^\d\z");
        }
    }
}
