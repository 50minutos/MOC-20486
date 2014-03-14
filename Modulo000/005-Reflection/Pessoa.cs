using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Reflection
{
    class Pessoa
    {
        [Display("código da pessoa")]
        public int Codigo { get; set; }

        [Display("nome da pessoa")]
        public String Nome { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", Codigo, Nome);
        }
    }
}
