using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            //var x = 10; => int x = 10;

            dynamic obj;

            var r = new Random();

            int n = r.Next(1, 3);

            if (n == 1)
                obj = new Object();
            else
                obj = new Random();

            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
            //Console.WriteLine(obj.ToIstring());

            obj = 10;
            obj = "opa";

            Console.ReadKey();
        }
    }
}
