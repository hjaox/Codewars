/*
https://www.codewars.com/kata/555eded1ad94b00403000071



Task:
Your task is to write a function which returns the sum of following series upto nth term(parameter).

Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
Rules:
You need to round the answer to 2 decimal places and return it as String.

If the given value is 0 then it should return 0.00

You will only be given Natural Numbers as arguments.

Examples:(Input --> Output)
1 --> 1 --> "1.00"
2 --> 1 + 1/4 --> "1.25"
5 --> 1 + 1/4 + 1/7 + 1/10 + 1/13 --> "1.57"
*/

function SeriesSum(n)
{
  let a = 1;
  let sum = 1;
  let b = 4;
  let c = 0;
  if (n === 0) {
    return c.toFixed(2) + ''
  }
  while (a < n) {
    sum += 1/b;
    b += 3;
    a++;
  }
  return ((Math.round(sum*100))/100).toFixed(2) + ''
}