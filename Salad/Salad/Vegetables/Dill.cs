using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Vegetables
{
    public class Dill : GroupofVegetable
    {
        public Dill(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public TypeTaste TypeTaste => TypeTaste.Badly;
        public override TypeCycle Cycle => TypeCycle.TwoYear;

        public override TypeGenerative TypeofGenerative => TypeGenerative.Root;

        public override string Name => "Dill";
        public override double Calories => 95.44;
        public override string Color => "Green";
        public override DateTime TimeCreate => DateTime.UtcNow;

        public override TypeofGroup TypeofGroup => TypeofGroup.RootVegetables;
    }
}
