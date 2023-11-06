using OpenClosed_Principle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle.Infrastructure
{
    internal class PotatoMeal /*: IMeal*/ : MealBase
    {
        //public void Make()
        //{
        //    Console.WriteLine("Чистим картошку");
        //    Console.WriteLine("Ставим почищенную картошку на огонь");
        //    Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        //    Console.WriteLine("Посыпаем пюре специями и зеленью");
        //    Console.WriteLine("Картофельное пюре готово");
        //}

        protected override void Cook()
        {
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Варим около 30 минут");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Чистим и моем картошку");
        }
    }
}
