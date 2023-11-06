using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
