using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad.Helper
{
    public class VegetableComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            var x = first as GroupofVegetable;
            var y = second as GroupofVegetable;

            if (x.Weight > y.Weight)
            {
                return 1;
            }
            else if (x.Weight < y.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
