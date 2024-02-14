'''
https://www.codewars.com/kata/57cff961eca260b71900008f/python



Given an array of numbers, check if any of the numbers are the character codes for lower case vowels (a, e, i, o, u).

If they are, change the array value to a string of that vowel.

Return the resulting array.
'''

def is_vow(inp):
    arr = []
    
    for char in inp:
        if(chr(char) in "aeiou"):
            arr.append(chr(char))
        else:
            arr.append(char)
            
    return arr