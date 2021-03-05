using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Vegetables
{
    public class Cucumber : GroupofVegetable
    {
        public Cucumber(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public TypeTaste TypeTaste => TypeTaste.Normal;
        public override TypeCycle Cycle => TypeCycle.OneYear;

        public override TypeGenerative TypeofGenerative => TypeGenerative.Stem;

        public override string Name => "Cucumber";
        public override double Calories => 95.44;
        public override string Color => "Green";
        public override DateTime TimeCreate => DateTime.UtcNow;

        public override TypeofGroup TypeofGroup => TypeofGroup.Tubers;
    }
}
