using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Vegetables
{
    public class Сarrot : GroupofVegetable
    {
        public Сarrot(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public TypeTaste TypeTaste => TypeTaste.Normal;
        public override TypeCycle Cycle => TypeCycle.ManyYear;

        public override TypeGenerative TypeofGenerative => TypeGenerative.Root;

        public override string Name => "Carrot";
        public override double Calories => 315.13;
        public override string Color => "Yellow";
        public override DateTime TimeCreate => DateTime.UtcNow;

        public override TypeofGroup TypeofGroup => TypeofGroup.RootVegetables;
    }
}
