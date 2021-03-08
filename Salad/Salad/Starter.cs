using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Salad.Helper;
using Salad.Services;
using Salad.Services.Abstractions;

namespace Salad
{
    public class Starter
    {
        private readonly ISaladService _saladService;

        public Starter()
        {
            _saladService = new SaladService();
        }

        public void Run()
        {
            ShowResult();
        }

        public void ShowResult()
        {
            var salad = _saladService.MakeSalad();
            Array.Sort(salad.Vegetables, new VegetableComparer());

            for (int i = 0; i < salad.Vegetables.Length; i++)
            {
                Console.WriteLine($"Name: {salad.Vegetables[i].Name} Weight: {salad.Vegetables[i].Weight} Calorie: {salad.Vegetables[i].Calories}");
            }

            Console.WriteLine($"Salad calorie: {salad.Calories}");

            var vegetables = salad.FindVegetable(30);

            for (int i = 0; i < vegetables.Length; i++)
            {
                Console.WriteLine($"Name: {vegetables[i].Name} TimeCreate: {vegetables[i].TimeCreate} Price: {vegetables[i].Price}");
            }
        }
    }
}
