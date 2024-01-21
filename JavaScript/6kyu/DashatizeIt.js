/*
https://www.codewars.com/kata/58223370aef9fc03fd000071/javascript



Given an integer, return a string with dash '-' marks before and after each odd digit, but do not begin or end the string with a dash mark.

Ex:

274 -> '2-7-4'
6815 -> '68-1-5'
*/

function dashatize(num) {
    let numArr = num
      .toString()
      .split('')
      .filter(char => /[0-9]/g.test(char));
    
    return numArr
    .map((num, i) => {
      if(!i) {
        if(num % 2 && numArr.length > 1) return `${(num)}-`
        return num
      } 
      
      if(i === numArr.length - 1 ) {
        if(num % 2) return `-${(num)}`
        return num
      }
      
      if(!(+num % 2)) return num
      
      return `-${(num)}-`
    })
    .join('')
    .replace(/--/g,'-')
  }