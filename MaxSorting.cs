using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{

    public class GenericMaximum<T> where T : IComparable<T>
    {
        private T[] values;

        public GenericMaximum(params T[] values)
        {
            this.values = values;
        }

        public T Maximum()
        {
            if (values.Length == 0)
            {
              
                return default;
            }
            else if (values.Length == 1)
            {
                return values[0];
            }
            else
            {
                Array.Sort(values);
                return values[values.Length - 1];
            }
        }
    }

}
