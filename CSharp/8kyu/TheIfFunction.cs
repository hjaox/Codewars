using System;
/*
https://www.codewars.com/kata/54147087d5c2ebe4f1000805/train/csharp


Create a function called _if which takes 3 arguments: a value bool and 2 functions (which do not take any parameters): func1 and func2

When bool is truthy, func1 should be called, otherwise call the func2.

Example:
Kata.If(true, () => Console.WriteLine("True"), () => Console.WriteLine("False"));
// write "True" to console
*/

namespace CSharp._8kyu
{
    public class TheIfFunction
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if(condition) {
                func1();
            } else {
                func2();
            }
        }
    }
}