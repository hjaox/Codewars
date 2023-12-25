/*
https://www.codewars.com/kata/57a6633153ba33189e000074



Count the number of occurrences of each character and return it as a (list of tuples) in order of appearance. For empty output return (an empty list).

Consult the solution set-up for the exact data structure implementation depending on your language.

Example:

orderedCount("abracadabra") == [['a', 5], ['b', 2], ['r', 2], ['c', 1], ['d', 1]]
*/

const orderedCount = function (text) {
    return text.split('').reduce((returnArr, curr, i) => {
      if(text.indexOf(curr) === i) {
        let occurrence = text.split('').filter(char => char === curr).length;
        returnArr.push([curr, occurrence])
      }
      return returnArr
    } ,[])
  }