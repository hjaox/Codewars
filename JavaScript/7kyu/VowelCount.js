/*
https://www.codewars.com/kata/54ff3102c1bad923760001f3


Return the number (count) of vowels in the given string.

We will consider a, e, i, o, u as vowels for this Kata (but not y).

The input string will only consist of lower case letters and/or spaces.
*/

function getCount(str) {
    if (str.length > 0 && str != ' ') {
        if (str.match(/[aeiou]/ig) != null)
        {
            return str.match(/[aeiou]/ig).length
        } else {
            return 0;
        }
    } else {
        return 0
    }
  }