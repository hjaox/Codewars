using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/53da6d8d112bd1a0dc00008b/csharp


In this kata you will create a function that takes in a list and returns a list with the reverse order.

Examples (Input -> Output)
* [1, 2, 3, 4]  -> [4, 3, 2, 1]
* [9, 2, 0, 7]  -> [7, 0, 2, 9]
*/

namespace CSharp._8kyu
{
    public class ReverseListOrder
    {
        public static List<int> ReverseList(List<int> list)
        {
            return list.ToArray().Reverse().ToList();
        }
    }
}
