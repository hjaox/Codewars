'''
https://www.codewars.com/kata/57ab2d6072292dbf7c000039/python



There are 32 letters in the Polish alphabet: 9 vowels and 23 consonants.

Your task is to change the letters with diacritics:

ą -> a,
ć -> c,
ę -> e,
ł -> l,
ń -> n,
ó -> o,
ś -> s,
ź -> z,
ż -> z
and print out the string without the use of the Polish letters.

For example:

"Jędrzej Błądziński"  -->  "Jedrzej Bladzinski"
'''

def correct_polish_letters(st): 
    dia = {
        "ą" : "a",
        "ć" : "c",
        "ę" : "e",
        "ł" : "l",
        "ń" : "n",
        "ó" : "o",
        "ś" : "s",
        "ź" : "z",
        "ż" : "z"
    }
    
    return "".join(char if char not in dia else dia[char] for char in st)