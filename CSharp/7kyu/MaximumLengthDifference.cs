/*
https://www.codewars.com/kata/5663f5305102699bad000056/train/csharp



You are given two arrays a1 and a2 of strings. Each string is composed with letters from a to z. Let x be any string in the first array and y be any string in the second array.

Find max(abs(length(x) − length(y)))

If a1 and/or a2 are empty return -1 in each language except in Haskell (F#) where you will return Nothing (None).

Example:
a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
mxdiflg(a1, a2) --> 13
*/

namespace CSharp._7kyu;

public class MaxLengthDifference {
    public static int Mxdiflg(string[] a1, string[] a2) {

        if(a1.Length == 0 || a2.Length == 0) {
        return -1;
        }

        int res1 = Math.Abs(a1.Select(str => str.Length).Max() - a2.Select(str => str.Length).Min());
        int res2 = Math.Abs(a2.Select(str => str.Length).Max() - a1.Select(str => str.Length).Min());

        return res1 > res2 ? res1 : res2;
    }
}