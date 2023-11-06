using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/57126304cdbf63c6770012bd

Given a string s, write a method (function) that will return true if its a valid single integer or floating number or false if its not.

Valid examples, should return true:

isDigit("3")
isDigit("  3  ")
isDigit("-3.23")
should return false:

isDigit("3-4")
isDigit("  3   5")
isDigit("3 5")
isDigit("zero")
*/

namespace CSharp
{
    public class IsItANumber
    {
        public static bool IsDigit(string s)
        {
            return double.TryParse(s, out double num);
        }
    }
}
