using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/587c2d08bb65b5e8040004fd/

An NBA game runs 48 minutes (Four 12 minute quarters). Players do not typically play the full game, subbing in and out as necessary. Your job is to extrapolate a player's points per game if they played the full 48 minutes.

Write a function that takes two arguments, ppg (points per game) and mpg (minutes per game) and returns a straight extrapolation of ppg per 48 minutes rounded to the nearest tenth. Return 0 if 0.

Examples:

Kata.NbaExtrap(12, 20) => 28.8
Kata.NbaExtrap(10, 10) => 48
Kata.NbaExtrap(5, 17)  => 14.1
Kata.NbaExtrap(0, 0)   => 0
Notes:
All inputs will be either be an integer or float.
Follow your dreams!
*/

namespace CSharp
{
    public class NBAFull48MinutesAverage
    {
        public static double NbaExtrap(double ppg, double mpg)
        {
            return ppg > 0 ? Math.Round((ppg / mpg) * 48.0, 1) : 0;
        }
    }
}
