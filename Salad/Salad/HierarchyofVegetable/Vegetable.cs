using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable.Enums;

namespace Salad
{
    public abstract class Vegetable : Product
    {
        public Vegetable(double weight, double price, string company, Country createdcountry)
            : base(weight, price, company, createdcountry)
        {
        }

        public abstract TypeCycle Cycle { get; }
    }
}
