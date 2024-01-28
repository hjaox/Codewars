/*
https://www.codewars.com/kata/56e9e4f516bcaa8d4f001763/javascript



Description:

We want to generate a function that computes the series starting from 0 and ending until the given number.

Example:
Input:

> 6
Output:

0+1+2+3+4+5+6 = 21

Input:

> -15
Output:

-15<0

Input:

> 0
Output:

0=0
*/

var SequenceSum = (function() {
    function SequenceSum() {}
  
    SequenceSum.showSequence = function(count) {
      let str = '';
      let sum = 0;
      if(!count) return `0=0`;
      if(count < 0) return `${count}<0`;
      
      for(let i = 0; i <= count; i++){
        str += count !== i ? `${i}+` : `${i}`;
        sum += i;
        if(count === i) str += ` = ${sum}`
      }
      return str;
    };
  
    return SequenceSum;
  
  })();