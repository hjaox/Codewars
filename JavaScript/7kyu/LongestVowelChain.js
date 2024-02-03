/*
https://www.codewars.com/kata/59c5f4e9d751df43cf000035/javascript


The vowel substrings in the word codewarriors are o,e,a,io. The longest of these has a length of 2. Given a lowercase string that has alphabetic characters only (both vowels and consonants) and no spaces, return the length of the longest vowel substring. Vowels are any of aeiou.

Good luck!
*/

function solve(s){
    return Math.max(...s.match(/[aeiou]+/gi).map(set => set.length));
  }