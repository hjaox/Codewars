/*
https://www.codewars.com/kata/54d512e62a5e54c96200019e



Given a positive number n > 1 find the prime factor decomposition of n. The result will be a string with the following form :

 "(p1**n1)(p2**n2)...(pk**nk)"
with the p(i) in increasing order and n(i) empty if n(i) is 1.

Example: n = 86240 should return "(2**5)(5)(7**2)(11)"
*/

function primeFactors(n){
    let ans = [n];
    let a = 0;
    let b = 0;
    let c = 0;
    let d = {};
    let e = '';
  
    while(isNotPrime(ans[ans.length-1])) {
      c = ans[ans.length-1];
      for(let i = 2; i < c; i++) {
        if(c%i === 0) {
          a = i;
          b = (c/i);
          ans.pop();
          ans.push(a,b)
          break;
        }
      }
    }
    
    d = ans.reduce((a,b) => {    
      if(a[b]) {
        a[b]++
      } else {
        a[b] = 1
      }
      return a
    },{})
  
    for(const key in d) {
      if(d[key] === 1) {
        e+=`(${key})`
      } else {
        e+=`(${key}**${d[key]})`
      }
    }
    
    return e
  
  }
  
  const isNotPrime = x => {
    for(let i = 2; i < x; i++) {
      if(x%i === 0) {
        return true
      }
    }
    return false
  }