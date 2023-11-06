using OpenClosed_Principle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle.Infrastructure
{
    internal class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void MakeDinner(MealBase[] menu)
        {
            foreach (MealBase meal in menu)
                meal.Make();
        }

        //Strategy
        //public void MakeDinner(IMeal meal)
        //{
        //    meal.Make();
        //}

        //public void MakeDinner()
        //{
        //    Console.WriteLine("Чистим картошку");
        //    Console.WriteLine("Ставим почищенную картошку на огонь");
        //    Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        //    Console.WriteLine("Посыпаем пюре специями и зеленью");
        //    Console.WriteLine("Картофельное пюре готово");
        //}
    }
}
