/*
https://www.codewars.com/kata/514a024011ea4fb54200004b



Write a function that when given a URL as a string, parses out just the domain name and returns it as a string. For example:

* url = "http://github.com/carbonfive/raygun" -> domain name = "github"
* url = "http://www.zombie-bites.com"         -> domain name = "zombie-bites"
* url = "https://www.cnet.com"                -> domain name = cnet"
*/

function domainName(url){
    return /^http/.test(url) && !(/www/g.test(url)) ? (""+url.match(/\/[\w\d-]+\./)).slice(1,-1)
    : (/^http/.test(url) && (/www/g.test(url))) || (/^www/.test(url)) ? (""+url.match(/\.[\w\d-]+\./)).slice(1,-1)
    : (""+url.match(/[\w\d-]+\./)).slice(0,-1)
  }