using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Lambda
{
    class Program
    {
        static Func<int, int> Dobro = x => x * 2;
        static Func<int, bool> Par = x => x % 2 == 0;
    
        static void Main(string[] args)
        {
            //in => out
            //x => x
            //y => 2 * y
            //(x, y) => x + y

            Console.WriteLine(Dobro(25));
            Console.WriteLine(Par(50));

            Console.ReadKey();
        }
    }
}
