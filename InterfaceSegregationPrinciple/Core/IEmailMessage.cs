using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Core
{
    internal interface IEmailMessage
    {
        string Subject { get; set; }
    }
}
