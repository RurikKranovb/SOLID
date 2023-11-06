using OpenClosed_Principle.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_Principle.Infrastructure
{
    internal class SaladMeal /*: IMeal*/ : MealBase
    {
        //public void Make()
        //{
        //    Console.WriteLine("Нарезаем помидоры и огурцы");
        //    Console.WriteLine("Посыпаем зеленью, солью и специями");
        //    Console.WriteLine("Поливаем подсолнечным маслом");
        //    Console.WriteLine("Салат готов");
        //}

        protected override void Cook()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
        }

        protected override void FinalSteps()
        {
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }

        protected override void Prepare()
        {
            Console.WriteLine("Моем помидоры и огурцы");
        }
    }
}
