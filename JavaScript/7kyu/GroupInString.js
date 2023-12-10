/*
https://www.codewars.com/kata/5ee8ba31b44cc30032cbce04


In this kata you have to find whether same elements of the string are grouped together.

Example

Input	Output
112233	true
11223311	false

Explanation
In first example same elements are grouped together: (11)(22)(33), hence it should return true
In the second example there are two different groups of 1's: (11)2233(11), hence it should return false
*/

function isConsecutive(str) {
    let x = str.split('').filter((a,b) => b === 0 || a != str[b-1])
    for (let i = 0; i < x.length; i++) {
      for (let y = x.length - 1; y > i; y--) {
        if (x[i] === x[y]) {
          return false
        }
      }
    }
    return true
  }