using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SingleResponsibilityPrinciple.Infrastructure
{
    internal class Printer
    {
        public void PrintReport(Report report)
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(report.Text);
        }
    }
}
