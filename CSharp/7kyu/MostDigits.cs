/*
https://www.codewars.com/kata/58daa7617332e59593000006/csharp


Find the number with the most digits.

If two numbers in the argument array have the same number of digits, return the first one in the array.
*/

namespace CSharp._7kyu;

public class MostDigits {
    public static int FindLongest(int[] number) {
        return number.First(num => $"{num}".Length == $"{number.Max()}".Length);
    }
}