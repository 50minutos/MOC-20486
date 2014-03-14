using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ExtensionMethods
{
    class Program
    {

        static Func<char, bool> Avaliar = x => "aeiou".Contains(x);

        static void Main(string[] args)
        {
            var s = "batatinha";

            Console.WriteLine(s.GetLenght());

            //var vogais = s.Where(Avaliar);
            //var vogais = s.Where(AvaliarMetodo);
            
            var vogais = s.Where(x => "aeiou".Contains(x));

            foreach (var item in vogais)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadKey();
        }

        static bool AvaliarMetodo(char c) { return "aeiou".Contains(c); }
    }
}
