using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable;
using Salad.HierarchyofVegetable.Enums;

namespace Salad.Services.Abstractions
{
    public interface ISaladService
    {
        VegetableSalad MakeSalad();
    }
}
