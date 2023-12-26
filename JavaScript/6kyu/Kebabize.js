/*
https://www.codewars.com/kata/57f8ff867a28db569e000c4a/javascript


Modify the kebabize function so that it converts a camel case string into a kebab case.

"camelsHaveThreeHumps"  -->  "camels-have-three-humps"
"camelsHave3Humps"  -->  "camels-have-humps"
"CAMEL"  -->  "c-a-m-e-l"
Notes:

the returned string should only contain lowercase letters
*/


function kebabize(str) {
    return str.split('').reduce((retStr, char, i) =>  {
      if(/[a-z]/ig.test(char)) {
        retStr += char.toUpperCase() === char && i ? `-${char.toLowerCase()}` : char.toLowerCase();
      }
      return retStr
    }, '')
  }