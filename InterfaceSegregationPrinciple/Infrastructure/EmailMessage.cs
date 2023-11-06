using InterfaceSegregationPrinciple.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Infrastructure
{
    internal class EmailMessage : IEmailMessage
    {
        public string Text { get; set; } = "";
        public string Subject { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";

        public void Send() => Console.WriteLine("Отправляем по Email сообщение: {Text}");
    }
}
