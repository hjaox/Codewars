/*
https://www.codewars.com/kata/57f759bb664021a30300007d/train



Given a string made up of letters a, b, and/or c, switch the position of letters a and b (change a to b and vice versa). Leave any incidence of c untouched.

Example:

'acb' --> 'bca'
'aabacbaa' --> 'bbabcabb'
*/

namespace CSharp._7kyu;

public class Switcheroo
{
    public static string SwitcherooKata(string x)
    {
        return x.Replace('a', 't').Replace('b', 'a').Replace('t', 'b');
    }
}