using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7kyu
{
    public class RotateForAMax
    {
        public static long MaxRot(long n)
        {
            string strNum = n.ToString();
            long max = n;

            for(int i = 0; i < strNum.Length - 1; i++)
            {
                strNum = strNum.Substring(0, i) + strNum.Substring(i + 1) + strNum[i];

                if(Int64.Parse(strNum) > max) max = Int64.Parse(strNum);
            }

            return max;
        }
    }
}
