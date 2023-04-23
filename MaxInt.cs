using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    internal class MaxInt
    {
        public int maximumValue(int firstvalue, int secondvalue, int thirdvalue)
        {
            if (firstvalue.CompareTo(secondvalue) > 0 && (firstvalue.CompareTo(thirdvalue) > 0))
            {
                return firstvalue;
            }
            else if (secondvalue.CompareTo(firstvalue) > 0 && (secondvalue.CompareTo(thirdvalue) > 0))
            { 
                return secondvalue; 
            }
            else if (thirdvalue.CompareTo(firstvalue) > 0 && (thirdvalue.CompareTo(secondvalue) > 0))
            {
                return thirdvalue;
            }
            else
            {
               return 0; ;
            }

        }
    }
}
