/*
https://www.codewars.com/kata/57a2013acf1fa5bfc4000921


Write a function which calculates the average of the numbers in a given list.

Note: Empty arrays should return 0.
*/

function findAverage(array) {
    if (array.length === 0) {
        return 0;
    }
    return array.reduce((a,b) => a + b, 0)/array.length
  }