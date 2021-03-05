using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.HierarchyofVegetable.Enums;

namespace Salad
{
    public abstract class Product
    {
        public Product(double weight, double price, string company, Country createdcountry)
        {
            Weight = weight;
            Price = price;
            Company = company;
            CreatedCountry = createdcountry;
        }

        public abstract string Name { get; }

        public abstract double Calories { get;  }

        public abstract string Color { get; }

        public abstract DateTime TimeCreate { get; }

        public Country CreatedCountry { get; }
        public string Company { get; }

        public double Weight { get; }
        public double Price { get; }
    }
}
