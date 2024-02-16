'''
https://www.codewars.com/kata/559f44187fa851efad000087/python



Write a function that removes every lone 9 that is inbetween 7s.

"79712312" --> "7712312"
"79797"    --> "777"
'''

def seven_ate9(str_):
    ret = ""
    count = 0;
    
    for number in str_:
        if(number == "9" and count > 0 and count < len(str_) - 1):
            if(str_[count - 1] != "7" or str_[count + 1] != "7"):
                ret += number
        else:
            ret += number
        count += 1
    
    return ret