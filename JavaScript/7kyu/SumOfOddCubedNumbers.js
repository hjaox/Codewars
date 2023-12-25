/*
https://www.codewars.com/kata/580dda86c40fa6c45f00028a


Find the sum of the odd numbers within an array, after cubing the initial integers. The function should return undefined if any of the values aren't numbers.
*/

function cubeOdd(arr) {
    const filteredArr = arr.map(num => num * num * num).filter(num => num % 2 !== 0);
    return !filteredArr.includes(NaN) ? filteredArr.reduce((sum, num) => sum += num, 0) : undefined
  }