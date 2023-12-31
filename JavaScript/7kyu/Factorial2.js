/*
https://www.codewars.com/kata/57a049e253ba33ac5e000212/javascript



Your task is to write function factorial.

https://en.wikipedia.org/wiki/Factorial
*/

function factorial(n){
    if(n === 0) return 1;
    
    return Array.from({length: n}, (_,i) => i+1).reverse().reduce((retNum, num) => retNum *= num);
  }