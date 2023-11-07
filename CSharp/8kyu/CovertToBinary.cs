using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class CovertToBinary
    {
        public static int ToBinary(int num)
        {
            return Int32.Parse(Convert.ToString(num, 2));
        }
    }
}
