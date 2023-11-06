using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

/*
https://www.codewars.com/kata/570e8ec4127ad143660001fd

You can print your name on a billboard ad. Find out how much it will cost you. Each character has a default price of £30, but that can be different if you are given 2 parameters instead of 1 (allways 2 for Java).

You can not use multiplier "*" operator.

If your name would be Jeong-Ho Aristotelis, ad would cost £600. 20 leters * 30 = 600 (Space counts as a character).
*/

namespace CSharp
{
    public class NameOnBillboard
    {
        public static double Billboard(string name, double price = 30)
        {
            double cost = 0;

            for (int i = 0; i < name.Length; i++)
            {
                cost += price;
            }

            return cost;
        }
    }
}
