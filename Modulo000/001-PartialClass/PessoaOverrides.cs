﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PartialClass
{
    partial class Pessoa
    {
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
