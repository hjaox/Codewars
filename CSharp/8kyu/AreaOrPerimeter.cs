﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/5ab6538b379d20ad880000ab

You are given the length and width of a 4-sided polygon. The polygon can either be a rectangle or a square.
If it is a square, return its area. If it is a rectangle, return its perimeter.

Example(Input1, Input2 --> Output):

6, 10 --> 32
3, 3 --> 9
Note: for the purposes of this kata you will assume that it is a square if its length and width are equal, otherwise it is a rectangle.
*/


namespace CSharp._8kyu
{
    public class AreaOrPerimeter
    {
        public static int AreaOrPerimeterFunc(int l, int w)
        {
            return l == w ? l * w : (2 * l) + (2 * w);
        }
    }
}
