using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Core
{
    internal interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}
