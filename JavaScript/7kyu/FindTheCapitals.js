/*
https://www.codewars.com/kata/539ee3b6757843632d00026b



Instructions
Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.

Example (Input --> Output)
"CodEWaRs" --> [0,3,4,6]
*/

var capitals = function (word) {
  return word.split('').map((x,y) => {
    if(x === x.toUpperCase()) {
        return y
    }
  }).filter(x => x != undefined)
};