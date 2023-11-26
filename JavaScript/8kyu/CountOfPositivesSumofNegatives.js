/*
https://www.codewars.com/kata/576bb71bbbcf0951d5000044/javascript

DESCRIPTION:
Given an array of integers.

Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

If the input is an empty array or is null, return an empty array.

Example
For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].
*/

function countPositivesSumNegatives(input) {
  let a = 0;
  let b = 0;
  let c = [];
  if (!input || input.length === 0) {
    return c;
  } else if (input.length > 0) {
    for (let i = 0; i < input.length; i++) {
      console.log(input[i]);
      if (input[i] > 0) {
        a++;
      } else {
        b += input[i];
      }
    }
    c.push(a);
    c.push(b);
    return c;
  }
}
