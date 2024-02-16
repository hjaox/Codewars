'''
https://www.codewars.com/kata/51c89385ee245d7ddf000001/python



Complete the solution so that it returns a formatted string. The return value should equal "Value is VALUE" where value is a 5 digit padded number.

Example:

solution(5)  # should return "Value is 00005"
'''

def solution(value):
    pad = (5 - len(str(value))) * "0"
    return f"Value is {pad}{value}"