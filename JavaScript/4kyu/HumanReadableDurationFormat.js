/*
https://www.codewars.com/kata/52742f58faf5485cae000b9a/javascript


Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.

It is much easier to understand with an example:

* For seconds = 62, your function should return 
    "1 minute and 2 seconds"
* For seconds = 3662, your function should return
    "1 hour, 1 minute and 2 seconds"
For the purpose of this Kata, a year is 365 days and a day is 24 hours.

Note that spaces are important.

Detailed rules
The resulting expression is made of components like 4 seconds, 1 year, etc. In general, a positive integer and one of the valid units of time, separated by a space. The unit of time is used in plural if the integer is greater than 1.

The components are separated by a comma and a space (", "). Except the last component, which is separated by " and ", just like it would be written in English.

A more significant units of time will occur before than a least significant one. Therefore, 1 second and 1 year is not correct, but 1 year and 1 second is.

Different components have different unit of times. So there is not repeated units like in 5 seconds and 1 second.

A component will not appear at all if its value happens to be zero. Hence, 1 minute and 0 seconds is not valid, but it should be just 1 minute.

A unit of time must be used "as much as possible". It means that the function should not return 61 seconds, but 1 minute and 1 second instead. Formally, the duration specified by of a component must not be greater than any valid more significant unit of time.
*/

function formatDuration (seconds) {
    if(!seconds) return 'now';
    
    let years = 0;
    let days = 0;
    let hours = 0;
    let minutes = 0;
    let second = 0;
    
    if(seconds >= 31536000) {
        years += Math.floor(seconds / 31536000);
        seconds -= 31536000 * years;
    }
    
    if(seconds >= 86400) {
        days += Math.floor(seconds / 86400);
        seconds -= 86400 * days;
    }
    
    if(seconds >= 3600) {
        hours += Math.floor(seconds / 3600);
        seconds -= 3600 * hours;
    }
    
    if(seconds >= 60) {
        minutes += Math.floor(seconds / 60);
        seconds -= 60 * minutes;
    }
    
    if(seconds) {
        second += seconds;
    }
    
    
    let yearsStr = years ? `${years} year${years > 1 ? `s` : ''}` : 0;
    let daysStr = days ? `${days} day${days > 1 ? `s` : ''}` : 0;
    let hoursStr = hours ? `${hours} hour${hours > 1 ? `s` : ''}` : 0;
    let minutesStr = minutes ? `${minutes} minute${minutes > 1 ? `s` : ''}` : 0;
    let secondStr = second ? `${second} second${second > 1 ? `s` : ''}` : 0;
      
    let returnStr = [yearsStr, daysStr, hoursStr, minutesStr, secondStr].filter(item => item);
    
    return returnStr.length > 1 ? returnStr.reduce((str, item, i) => {
      if(i === returnStr.length - 1) {
        str += `and ${item}`;
        return str;
      }
      
      if(i === returnStr.length - 2) {
        str += `${item} `
        return str;
      }
      
      str += `${item}, `;
      return str;
    }, '') : returnStr[0]
  }