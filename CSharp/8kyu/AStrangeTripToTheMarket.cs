using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CSharp._8kyu
{
    public class AStrangeTripToTheMarket
    {
        public static bool IsLockNessMonster(string sentence)
        {
            return Regex.IsMatch(sentence, @"tree fiddy|3\.50", RegexOptions.IgnoreCase);
        }
    }
}
