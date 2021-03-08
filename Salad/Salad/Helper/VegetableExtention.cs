using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Helper
{
    public static class VegetableExtention
    {
        public static GroupofVegetable[] FindVegetable(this VegetableSalad salad, double weight)
        {
            var temp = new GroupofVegetable[salad.Vegetables.Length];
            for (var i = 0; i < temp.Length; i++)
            {
                var item = salad.Vegetables[i];
                if (item.Weight > weight)
                {
                    temp[i] = salad.Vegetables[i];
                }
            }

            var tempResult = ArrayHelper.CleanCapacity(temp);
            var result = new GroupofVegetable[tempResult.Length];

            for (var i = 0; i < result.Length; i++)
            {
                result[i] = tempResult[i] as GroupofVegetable;
            }

            return result;
        }
    }
}
