/*
https://www.codewars.com/kata/5413759479ba273f8100003d/javascript



Write a function reverse which reverses a list (or in clojure's case, any list-like data structure)

(the dedicated builtin(s) functionalities are deactivated)
*/

reverse = function(array) {
    const arr = [];
    
    for(let i = 0; i < array.length; i++) {
      arr.unshift(array[i])
    }
    
    return arr
  }