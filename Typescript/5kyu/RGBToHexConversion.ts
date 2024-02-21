/*
https://www.codewars.com/kata/513e08acc600c94f01000001/typescript



The rgb function is incomplete. Complete it so that passing in RGB decimal values will result in a hexadecimal representation being returned. Valid decimal values for RGB are 0 - 255. Any values that fall out of that range must be rounded to the closest valid value.

Note: Your answer should always be 6 characters long, the shorthand with 3 will not work here.

Examples (input --> output):
255, 255, 255 --> "FFFFFF"
255, 255, 300 --> "FFFFFF"
0, 0, 0       --> "000000"
148, 0, 211   --> "9400D3"
*/

export function rgb(r: number, g: number, b: number): string {
    if(r < 0) r = 0;
    if(g < 0) g = 0;
    if(b < 0) b = 0;
    if(r > 255) r = 255;
    if(g > 255) g = 255;
    if(b > 255) b = 255;
    
    let rStr = r.toString(16).length === 2 ? r.toString(16).toUpperCase() : "0" + r.toString(16).toUpperCase();
    let gStr = g.toString(16).length === 2 ? g.toString(16).toUpperCase() : "0" + g.toString(16).toUpperCase();
    let bStr = b.toString(16).length === 2 ? b.toString(16).toUpperCase() : "0" + b.toString(16).toUpperCase();
    
    return rStr + gStr + bStr;
  }