using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salad
{
    public class RealiseComaparer : IComparer<GroupofVegetable>
    {
        private readonly GroupofVegetable[] _groupofVegetable;
        private readonly GroupofVegetable _group;

        public int CompareTo(GroupofVegetable vegetable)
        {
            return _group.Weight.CompareTo(vegetable.Weight);
        }

        public int Compare(GroupofVegetable vegetable1, GroupofVegetable vegetable2)
        {
            if (vegetable1.Weight > vegetable2.Weight)
            {
                return 1;
            }
            else if (vegetable1.Weight < vegetable2.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void Sort()
        {
            Array.Sort(_groupofVegetable);
        }
    }
}
