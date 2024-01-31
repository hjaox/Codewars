using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._8kyu
{
    public class PrintingArrayElementsWithCommaDelimiters
    {
        public static string PrintArray(object[] array)
        {
            return string.Join(",", array);
        }
    }
}
