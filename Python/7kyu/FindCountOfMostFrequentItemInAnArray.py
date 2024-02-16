'''
https://www.codewars.com/kata/56582133c932d8239900002e/python


Complete the function to find the count of the most frequent item of an array. You can assume that input is an array of integers. For an empty array return 0

Example
input array: [3, -1, -1, -1, 2, 3, -1, 3, -1, 2, 4, 9, 3]
ouptut: 5 
The most frequent number in the array is -1 and it occurs 5 times.
'''

def most_frequent_item_count(collection):
    if(len(collection) == 0):
        return 0
    
    dict = {}
    max = 0
    
    for number in collection:
        if(number in dict):
            dict[number] += 1
        else:
            dict[number] = 1
    
    for key, val in dict.items():
        if(val > max):
            max = val
    
    return max
    