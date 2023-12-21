/*
https://www.codewars.com/kata/5208f99aee097e6552000148



Complete the solution so that the function will break up camel casing, using a space between words.

Example
"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/

function solution(string) {
    let start = 0;
    let end = 0;
    let words = [];
    
    for(let i = 0; i < string.length; i++) {
      start = end;
      if(string[i] === string[i].toUpperCase()) {
        end = i;
        words.push(string.substring(start, end))
      }
    }
    words.push(string.substring(end))
    return words.join(' ')    
  }