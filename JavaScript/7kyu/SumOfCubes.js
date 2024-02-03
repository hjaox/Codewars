/*
https://www.codewars.com/kata/59a8570b570190d313000037/javascript



Write a function that takes a positive integer n, sums all the cubed values from 1 to n (inclusive), and returns that sum.

Assume that the input n will always be a positive integer.

Examples: (Input --> output)

2 --> 9 (sum of the cubes of 1 and 2 is 1 + 8)
3 --> 36 (sum of the cubes of 1, 2, and 3 is 1 + 8 + 27)
*/

function sumCubes(n){
    return Array.from({length:n + 1}, (_, i) => i).reduce((sum, num) => sum += Math.pow(num, 3),0);
  }