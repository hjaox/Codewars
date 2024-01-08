/*
https://www.codewars.com/kata/56a946cd7bd95ccab2000055/javascript


Your task is simply to count the total number of lowercase letters in a string.

Examples
"abc" ===> 3

"abcABC123" ===> 3

"abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 3

"" ===> 0;

"ABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~" ===> 0

"abcdefghijklmnopqrstuvwxyz" ===> 26
*/

function lowercaseCount(str){
    if(!str || !/[a-z]+/g.test(str)) return 0;
    return str.match(/[a-z]+/g).reduce((longStr, string) => longStr += string, '').length || 0
  }