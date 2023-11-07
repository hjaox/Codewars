using System;
using System.Text;
using System.Text.RegularExpressions;

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
