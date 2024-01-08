/*
https://www.codewars.com/kata/529eef7a9194e0cbc1000255/javascript



An anagram is the result of rearranging the letters of a word to produce a new word (see wikipedia).

Note: anagrams are case insensitive

Complete the function to return true if the two arguments given are anagrams of each other; return false otherwise.

Examples
"foefet" is an anagram of "toffee"

"Buckethead" is an anagram of "DeathCubeK"
*/

var isAnagram = function(test, original) {
    if(test.length !== original.length) return false
    
    for(let i = 0; i < test.length; i++) {
      if(!original.toLowerCase().includes(test[i].toLowerCase())) return false
      if(original.toLowerCase().split('').filter(x => x === test[i].toLowerCase()).length !== test.toLowerCase().split('').filter(x => x === test[i].toLowerCase()).length) return false
    }
    
    return true
  };