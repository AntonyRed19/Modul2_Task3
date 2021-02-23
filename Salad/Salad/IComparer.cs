using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
        public interface IComparer
        {
            int Compare(object o1, object o2);
        }
}
