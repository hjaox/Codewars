/*
https://www.codewars.com/kata/52685f7382004e774f0001f7/typescript


Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)

HH = hours, padded to 2 digits, range: 00 - 99
MM = minutes, padded to 2 digits, range: 00 - 59
SS = seconds, padded to 2 digits, range: 00 - 59
The maximum time never exceeds 359999 (99:59:59)

You can find some examples in the test fixtures.
*/

export function humanReadable(seconds:number):string {
    let hh = Math.floor(seconds / 3600);
    let mm = Math.floor((seconds - (3600 * hh)) / 60);
    let ss = seconds - ((3600 * hh) + (60 * mm));
    
    return `${hh.toString().padStart(2, "0")}:${mm.toString().padStart(2, "0")}:${ss.toString().padStart(2, "0")}`
  }