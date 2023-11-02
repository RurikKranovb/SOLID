using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Infrastructure
{
    public class Report
    {
        public string Text { get; set; } = "";

        public void GoToFirstPage() => Console.WriteLine("Переход к первой странице");

        public void GoToLastPage() => Console.WriteLine("Переход к последней странице");

        public void GoToPage(int pageNumber) => Console.WriteLine($"Переход к станице {pageNumber}");

        //Перенос в отдельный класс
        //public void Print()
        //{
        //    Console.WriteLine("Печать отчета");
        //    Console.WriteLine(Text);
        //}

    }
}
