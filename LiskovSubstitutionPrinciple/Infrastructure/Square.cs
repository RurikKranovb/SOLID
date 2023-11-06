using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple.Infrastructure
{
    internal class Square : Core.Rectangle
    {
        public override int Width
        {
            get => base.Width; set
            {
                base.Width = value;
                base.Height = value;
            }
        }
        public override int Height
        {
            get => base.Height; set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }
}
