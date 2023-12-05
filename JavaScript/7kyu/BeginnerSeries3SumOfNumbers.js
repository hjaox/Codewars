/*
https://www.codewars.com/kata/55f2b110f61eb01779000053


Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!

Examples (a, b) --> output (explanation)
(1, 0) --> 1 (1 + 0 = 1)
(1, 2) --> 3 (1 + 2 = 3)
(0, 1) --> 1 (0 + 1 = 1)
(1, 1) --> 1 (1 since both are same)
(-1, 0) --> -1 (-1 + 0 = -1)
(-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)
Your function should only return a number, not the explanation about how you get that number.
*/

function getSum(a, b)
{
  let x = 0;
  let y = 0;
  let sum = 0;

  if (a > b) {
    x = a;
    y = b;
  } else if (b > a) {
    x = b;
    y = a;
  } else {
    return a;
  }

  for (let i = y; i <= x; i++) {
    sum += i;
  }

  return sum;
}