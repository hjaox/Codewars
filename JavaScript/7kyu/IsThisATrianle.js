/*
https://www.codewars.com/kata/56606694ec01347ce800001b



Implement a function that accepts 3 integer values a, b, c. The function should return true if a triangle can be built with the sides of given length and false in any other case.

(In this case, all triangles must have surface greater than 0 to be accepted).
*/

function isTriangle(a,b,c)
{
  if(a === 0 || b === 0 || c === 0) {
    return false;
  }
  let s = [a,b,c].sort((a,b) => a-b);
  
   return s[2] < s[0]+s[1];
}