/*
https://www.codewars.com/kata/5a805d8cafa10f8b930005ba



Your task is to find the nearest square number, nearest_sq(n) or nearestSq(n), of a positive integer n.

For example, if n = 111, then nearest\_sq(n) (nearestSq(n)) equals 121, since 111 is closer to 121, the square of 11, than 100, the square of 10.

If the n is already the perfect square (e.g. n = 144, n = 81, etc.), you need to just return n.

Good luck :)
*/

function nearestSq(n){
    return Math.sqrt(n) === Math.floor(Math.sqrt(n)) ? n
  : n - (Math.floor(Math.sqrt(n))**2) < (Math.ceil(Math.sqrt(n))**2) - n ? Math.floor(Math.sqrt(n))**2 : Math.ceil(Math.sqrt(n))**2
}