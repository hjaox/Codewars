using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
https://www.codewars.com/kata/55f73f66d160f1f1db000059/csharp

DESCRIPTION:
Combine strings function
Create a function named (Combine_names) that accepts two parameters (first and last name). The function should return the full name.

Example:

CombineNames("James", "Stevens")
returns:

"James Stevens"
*/

namespace CSharp._8kyu
{
    public class GrasshopperCombineStrings
    {
        public static string CombineNames(string name1, string name2)
        {
            return $"{name1} {name2}";
        }
    }
}
