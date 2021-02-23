using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.Vegetables;
using Salad.HierarchyofVegetable;

namespace Salad
{
    public class Salad
    {
        private readonly GroupofVegetable[] _groupofVegetable;
        private readonly GroupofVegetable _groupofVegetables;
        private readonly RealiseComaparer _realise;
        public Salad()
        {
            _groupofVegetable = new GroupofVegetable[]
            {
               new Bow { Calories = 95.55, Color = "White", Name = "Bow", TypeCycle = TypeCycle.TwoYear, TypeofGroup = TypeofGroup.Leafy, Weight = 50,  TypeTaste = TypeTaste.Awful },
               new Cucumber { Calories = 55.55, Color = "Green", Name = "Cucumber", TypeCycle = TypeCycle.OneYear, TypeofGroup = TypeofGroup.RootVegetables, Weight = 100, TypeTaste = TypeTaste.Normal },
               new Dill { Calories = 95.55, Color = "Green", Name = "Dill", TypeCycle = TypeCycle.OneYear, TypeofGroup = TypeofGroup.Leafy, Weight = 80, TypeTaste = TypeTaste.Normal },
               new Potato { Calories = 95.55, Color = "Green", Name = "Bow", TypeCycle = TypeCycle.TwoYear, TypeofGroup = TypeofGroup.Leafy, Weight = 150, TypeTaste = TypeTaste.Good },
               new Сabbage { Calories = 95.55, Color = "Green", Name = "Bow", TypeCycle = TypeCycle.TwoYear, TypeofGroup = TypeofGroup.Leafy, Weight = 250, TypeTaste = TypeTaste.Good },
               new Сarrot { Calories = 95.55, Color = "Green", Name = "Bow", TypeCycle = TypeCycle.TwoYear, TypeofGroup = TypeofGroup.Leafy, Weight = 375, TypeTaste = TypeTaste.Excellent }
            };
        }

        public GroupofVegetable[] GetAll()
        {
            return _groupofVegetable;
        }

        public int AddCalories()
        {
            var count = 0;
            foreach (var vegetable in _groupofVegetable)
            {
                vegetable.Calories += count;
            }

            return count;
        }

        public GroupofVegetable[] MakeSalad()
        {
            var display = 0;
            display = Console.WriteLine($"U make a Salad with {_groupofVegetables.Name} and Salad have {AddCalories().ToString()}");
            return display;
        }
    }
}
