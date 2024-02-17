/*
https://www.codewars.com/kata/583ade15666df5a64e000058/typescript


This kata is about converting numbers to their binary or hexadecimal representation:

If a number is even, convert it to binary.
If a number is odd, convert it to hex.
Numbers will be positive. The hexadecimal string should be lowercased.
*/

export function evensAndOdds(n: number): string {
  
    return n % 2 ? n.toString(16) : n.toString(2)
  }