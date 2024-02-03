/*
https://www.codewars.com/kata/598106cb34e205e074000031/javascript



The Pied Piper has been enlisted to play his magical tune and coax all the rats out of town.

But some of the rats are deaf and are going the wrong way!

Kata Task
How many deaf rats are there?

Legend
P = The Pied Piper
O~ = Rat going left
~O = Rat going right
Example
ex1 ~O~O~O~O P has 0 deaf rats

ex2 P O~ O~ ~O O~ has 1 deaf rat

ex3 ~O~O~O~OP~O~OO~ has 2 deaf rats
*/

var countDeafRats = function(town) {
    let arr = [];
    
    for(let i = 0; i < town.length; i++) {
      let item = "";
      for(let j = 0; j < 2; j++) {
        if(town[i] === "P"){
          item = "P";
          break;
        }
        if(town[i] === " "){
          break;
        }
        
        item += town[i+j];
        if(item.length === 2) i++;
      }
      
      if(item) arr.push(item);
    }
    
    return arr.reduce((deafCount, rat, i) => {
      if(rat === "~O" && i > arr.indexOf("P")) deafCount++;
      if(rat === "O~" && i < arr.indexOf("P")) deafCount++;
      return deafCount;
    },0)
  }