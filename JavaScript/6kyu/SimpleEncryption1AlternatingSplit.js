/*
https://www.codewars.com/kata/57814d79a56c88e3e0000786




Implement a pseudo-encryption algorithm which given a string S and an integer N concatenates all the odd-indexed characters of S with all the even-indexed characters of S, this process should be repeated N times.

Examples:

encrypt("012345", 1)  =>  "135024"
encrypt("012345", 2)  =>  "135024"  ->  "304152"
encrypt("012345", 3)  =>  "135024"  ->  "304152"  ->  "012345"

encrypt("01234", 1)  =>  "13024"
encrypt("01234", 2)  =>  "13024"  ->  "32104"
encrypt("01234", 3)  =>  "13024"  ->  "32104"  ->  "20314"
Together with the encryption function, you should also implement a decryption function which reverses the process.

If the string S is an empty value or the integer N is not positive, return the first argument without changes.
*/


function encrypt(text, n) {
    let a = 0;
    let ans = text;
    if(!text || !n) {
       return text
       }
    
    while(a<n) {
      let b = '';
      let c = '';
      
      for(let i = 1; i < ans.length; i += 2){
        b += ans[i];
      }
      for(let x = 0; x < ans.length; x += 2){
        c += ans[x];
      }
      a++;
      ans = b+c;
    }
    
    return ans
  
  }
  
  function decrypt(encryptedText, n) {
      let ans2 = encryptedText;
      let a = 0;
      let b = 0;
    if(!encryptedText || !n) {
      return encryptedText
    }
      
      if(encryptedText.length%2 === 0) {
          a = encryptedText.length/2;
      } else {
          a = Math.ceil(encryptedText.length/2) -1
      }
  
      while(b<n){
          let ans = '';
          for(let i = 0; i < ans2.length/2; i++){
              if(i+a < ans2.length){
                  ans+=ans2[i+a];           
              }
              if(i < a) {
                  ans+=ans2[i];
              }
          }
          b++;
          ans2 = ans;
      }
      return ans2
  }