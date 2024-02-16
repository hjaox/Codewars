'''
https://www.codewars.com/kata/5831c204a31721e2ae000294/python



When provided with a String, capitalize all vowels

For example:

Input : "Hello World!"

Output : "HEllO WOrld!"

Note: Y is not a vowel in this kata.
'''

def swap(st):
    return "".join(char.upper() if char.lower() in "aeiou" else char for char in st)