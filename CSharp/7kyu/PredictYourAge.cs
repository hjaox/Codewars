using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7kyu
{
    public class PredictYourAge
    {
        public static int PredictAge(params int[] ages)
        {
            int[] agesCopy = ages.Select(age => (int)Math.Pow(age, 2)).ToArray();
            return (int)Math.Sqrt(agesCopy.Sum()) / 2;
        }
    }
}
