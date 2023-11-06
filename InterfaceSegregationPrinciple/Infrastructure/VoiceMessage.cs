using InterfaceSegregationPrinciple.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Infrastructure
{
    internal class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; } = "";
        public string FromAddress { get; set; } = "";

        public byte[] Voice { get; set; } = Array.Empty<byte>();
        public void Send() => Console.WriteLine("Передача голосовой почты");
    }
}
