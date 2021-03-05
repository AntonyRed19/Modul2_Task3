using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Vegetables
{
    public class Potato : GroupofVegetable
    {
        public Potato(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public TypeTaste TypeTaste => TypeTaste.Good;
        public override TypeCycle Cycle => TypeCycle.OneYear;

        public override TypeGenerative TypeofGenerative => TypeGenerative.Fetus;

        public override string Name => "Potato";
        public override double Calories => 315.13;
        public override string Color => "Yellow";
        public override DateTime TimeCreate => DateTime.UtcNow;

        public override TypeofGroup TypeofGroup => TypeofGroup.Bulbous;
    }
}
