using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/57eaec5608fed543d6000021/csharp


Given a mixed array of number and string representations of integers, add up the non-string integers and subtract the total of the string integers.

Return as a number.
*/

namespace CSharp._7kyu
{
    public class DivideAndConquer
    {
        public static int DivCon(Object[] objArray)
        {
            return objArray.Sum(numObj => numObj is int ? (int)numObj : -Convert.ToInt32(numObj));
        }
    }
}
