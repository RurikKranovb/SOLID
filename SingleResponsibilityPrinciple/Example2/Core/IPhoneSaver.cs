using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Example2.Core
{
    public interface IPhoneSaver
    {
        void Save(Phone phone, string fileName);
    }
}
