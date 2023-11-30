/*
https://www.codewars.com/kata/5583090cbe83f4fd8c000051


Convert number to reversed array of digits
Given a random non-negative number, you have to return the digits of this number within an array in reverse order.

Example(Input => Output):
35231 => [1,3,2,5,3]
0 => [0]
*/

function digitize(n) {
    let a = [];
    let b = n.toString();
    let c = parseInt(b,10);
  
    for (i = 0; i < b.length; i++) {
      let d = parseInt(b[b.length - 1 - i], 10);
      a.push(d);    
    }  
    return a
}