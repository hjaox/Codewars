/*
https://www.codewars.com/kata/52449b062fb80683ec000024/javascript



The marketing team is spending way too much time typing in hashtags.
Let's help them with our own Hashtag Generator!

Here's the deal:

It must start with a hashtag (#).
All words must have their first letter capitalized.
If the final result is longer than 140 chars it must return false.
If the input or the result is an empty string it must return false.
Examples
" Hello there thanks for trying my Kata"  =>  "#HelloThereThanksForTryingMyKata"
"    Hello     World   "                  =>  "#HelloWorld"
""                                        =>  false
*/

function generateHashtag (str) {
    if(!str || !/\w/g.test(str)) return false;
    
    let result = "#" + (str.trim()
      .split(" ")
      .filter(item => /\w+/gi.test(item))
      .map(word => word[0].toUpperCase() + word.slice(1).toLowerCase())
      .join(""))
    
    return result.length > 140 ? false : result;
  }