using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/59fca81a5712f9fa4700159a

Task Overview
Given a non-negative integer n, write a function to_binary/ToBinary which returns that number in a binary format.

Documentation:
Kata.ToBinary Method (Int32)
Returns the binary representation of a non-negative integer as an integer.

Syntax

public static int ToBinary(
int n
  )

Parameters
n
Type: System.Int32
The integer to convert.

Return Value
Type: System.Int32
The binary representation of the argument as an integer.

to_binary(1)  /* should return 1 
to_binary(5)  /* should return 101 
to_binary(11) /* should return 1011 


*/

namespace CSharp._8kyu
{
    public class CovertToBinary
    {
        public static int ToBinary(int num)
        {
            return Int32.Parse(Convert.ToString(num, 2));
        }
    }
}
