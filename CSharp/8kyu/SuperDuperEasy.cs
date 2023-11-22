using System.Text.RegularExpressions;

namespace CSharp._8kyu;

/*
https://www.codewars.com/kata/55a5bfaa756cfede78000026/train/csharp


Make a function that returns the value multiplied by 50 and increased by 6. If the value entered is a string it should return "Error".

Note: in C#, you'll always get the input as a string, so the above applies if the string isn't representing a double value.
*/

public class SuperDuperEasy
{
    public static string Problem(string a) {
        return Regex.IsMatch(a, @"^[\d.]+$") ? ((int) (decimal.Parse(a) * 50) + 6).ToString() : "Error";
    }
}