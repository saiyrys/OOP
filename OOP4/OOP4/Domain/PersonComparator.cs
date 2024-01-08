using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Domain
{
    public class PersonComparator<T> : IComparer<T> where T : Person
    {
        public int Compare(T o1, T o2)
        {
            int result = string.Compare(o1.GetName(), o2.GetName(), StringComparison.Ordinal);

            if (result == 0)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }
    }
}
