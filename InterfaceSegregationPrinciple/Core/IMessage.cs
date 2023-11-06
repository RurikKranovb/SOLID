using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple.Core
{
    public interface IMessage
    {
        //void Send();
        //string Text { get; set; }
        //string Subject { get; set; }
        //string ToAddress { get; set; }
        //string FromAddress { get; set; }

        //byte[] Voice { get; set; }

        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
