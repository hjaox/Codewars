using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/57b58827d2a31c57720012e8/csharp

DESCRIPTION:
In this kata you will have to write a function that takes litres and pricePerLitre (in dollar) as arguments.

Purchases of 2 or more litres get a discount of 5 cents per litre, purchases of 4 or more litres get a discount of 10 cents per litre, and so on every two litres, up to a maximum discount of 25 cents per litre. But total discount per litre cannot be more than 25 cents. Return the total cost rounded to 2 decimal places. Also you can guess that there will not be negative or non-numeric inputs.

Good Luck!

Note
1 Dollar = 100 Cents
*/

namespace CSharp._8kyu
{
    public class FuelCalculatorTotalCost
    {
        public static double FuelPrice(double litres, double pricePerLitre)
        {
            double q = Math.Floor(litres / 2);
            return Math.Round((pricePerLitre * litres) - (q < 5? litres * (q * 0.05) : litres * 0.25), 2);
        }
    }
}
