/*
https://www.codewars.com/kata/530e15517bc88ac656000716



ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".
*/

function rot13(message){
    return message.split('').map(x => {
      if (x.toUpperCase().charCodeAt()+13 > 90 && (/[A-Za-z]/).test(x)) {
        if (x === x.toUpperCase()) {
          return String.fromCharCode(64+(x.toUpperCase().charCodeAt()+13-90));
        } else {
          return String.fromCharCode(64+(x.toUpperCase().charCodeAt()+13-90)).toLowerCase();
        }
      } else if (x.toUpperCase().charCodeAt()+13 < 91 && (/[A-Za-z]/).test(x)){
        if (x === x.toUpperCase()) {
          return String.fromCharCode(x.toUpperCase().charCodeAt()+13);        
        } else {
          return String.fromCharCode(x.toUpperCase().charCodeAt()+13).toLowerCase();  
        }
      } else {
        return x
      }
    }).join('')
  }