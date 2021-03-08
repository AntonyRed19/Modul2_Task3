using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.Services.Abstractions;
using Salad.Vegetables;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Services
{
    public class SaladService : ISaladService
    {
        public SaladService()
        {
        }

        public VegetableSalad MakeSalad()
        {
            var vegebles = new GroupofVegetable[]
            {
               new Cucumber(25.55, 35, "Cucumber Product", Country.Russia),
               new Dill(10.55, 15, "Dill Product", Country.Latvia),
               new Potato(55.55, 45, "Potato Product", Country.Belarus),
               new Сarrot(45.55, 40, "Carrot Product", Country.Ukraine),
               new Сabbage(65.55, 65, "Cucumber Product", Country.Russia),
            };
            var calori = 0d;
            for (var i = 0; i < vegebles.Length; i++)
            {
                calori += vegebles[i].Calories;
            }

            return new VegetableSalad { Vegetables = vegebles, Calories = calori };
        }
    }
}
