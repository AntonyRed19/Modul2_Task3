using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.HierarchyofVegetable
{
    public abstract class GenerativeVegetable : Vegetable
    {
        public GenerativeVegetable(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public abstract TypeGenerative TypeofGenerative { get; }
    }
}
