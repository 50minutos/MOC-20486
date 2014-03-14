using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Reflection
{
    class DisplayAttribute : Attribute
    {
        private String txt;

        public DisplayAttribute(String txt)
        {
            this.txt = txt;
        }

        public override string ToString()
        {
            return txt;
        }
    }
}
