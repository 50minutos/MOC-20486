using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Reflection
{
    class Livro
    {
        public Livro()
        {
            id = Guid.NewGuid();
        }

        private Guid id;
        public Guid Id { get { return id; } }

        [Display("título do livro")]
        public String Titulo { get; set; }

        public override string ToString()
        {
            return String.Format("{0} -> {1}", id, Titulo);
        }

    }
}
