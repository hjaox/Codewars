using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class IsItANumber
    {
        public static bool IsDigit(string s)
        {
            return double.TryParse(s, out double num);
        }
    }
}
