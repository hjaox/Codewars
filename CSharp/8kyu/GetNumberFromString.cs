using System;
using System.Linq;

/*
https://www.codewars.com/kata/57a37f3cbb99449513000cd8/csharp


Write a function which removes from string all non-digit characters and parse the remaining to number. E.g: "hell5o wor6ld" -> 56

Function:

GetNumberFromString(string s)
*/

namespace CSharp._8kyu;

public class GetNumberFromString
{
    public static int GetNumberFromStringKata(string s)
    {
        return int.Parse(string.Concat(s.Where(character => char.IsDigit(character))));
    }
}