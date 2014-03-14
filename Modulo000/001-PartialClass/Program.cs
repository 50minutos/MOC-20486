using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PartialClass
{
    /*internal*/
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa(); //CLR -> CLS
            //Pessoa p = new Pessoa();

            p.Codigo = 1;
            p.Nome = "ADÃO";
            p.Sexo = 'M';

            var q = new Pessoa
            {
                Codigo = 2, 
                Nome = "EVA", 
                Sexo = 'F'
            };

            Console.WriteLine("{0} -> {1} - {2}", p.Codigo, p.Nome, p.Sexo);

            p.Acordar();
            p.Comer();
            p.Comer("MACARRÃO");
            p.Dormir();

            Console.WriteLine();

            Console.WriteLine(q);

            Console.ReadKey();
        }
    }

    partial class Pessoa
    {
        public void Acordar() { Console.WriteLine("acordou"); }
        public void Comer(String oQue = "nada") { Console.WriteLine("comeu " + oQue); }
        public void Dormir() { Console.WriteLine("dormiu"); }
    }
}
