/*
https://www.codewars.com/kata/56e2f59fb2ed128081001328/csharp



Input: Array of elements

["h","o","l","a"]

Output: String with comma delimited elements of the array in th same order.

"h,o,l,a"

Note: if this seems too simple for you try the next level

Note2: the input data can be: boolean array, array of objects, array of string arrays, array of number arrays... 😕
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8kyu
{
    public class PrintingArrayElementsWithCommaDelimiters
    {
        public static string PrintArray(object[] array)
        {
            return string.Join(",", array.Select(item => item is Object[]? PrintArray(item as object[]) : item));
        }
    }
}
