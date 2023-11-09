using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp


Finish the solution so that it sorts the passed in array of numbers. If the function passes in an empty array or null/nil value then it should return an empty array.

For example:

SortNumbers(new int[] { 1, 2, 10, 50, 5 }); // should return new int[] { 1, 2, 5, 10, 50 }
SortNumbers(null); // should return new int[] { }
*/

namespace CSharp._7kyu
{
    public class SortNumbers
    {
        public static int[] SortNumbersFunc(int[] nums)
        {
            return nums?.OrderBy(x => x).ToArray() ?? new int[0];
        }
    }
}
