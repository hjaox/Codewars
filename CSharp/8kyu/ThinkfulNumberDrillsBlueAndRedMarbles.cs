using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class ThinkfulNumberDrillsBlueAndRedMarbles
    {
        public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
        {
            return (double)(blueStart - bluePulled) / (blueStart + redStart - (bluePulled + redPulled));
        }
    }
}
