using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Object obj = null;

            Console.Write("Você quer um [L]ivro ou uma [P]essoa? ");

            String resposta = Console.ReadLine().ToUpper();

            if (resposta.Equals("L"))
                obj = new Livro();
            else if (resposta.Equals("P"))
                obj = new Pessoa();
            else
                return;

            var t = obj.GetType();

            foreach (var item in t.GetProperties())
            {
                if (item.CanWrite)
                {
                    var txt = item.Name;

                    var atts = item.GetCustomAttributes(typeof(DisplayAttribute), true);

                    if(atts.Length != 0)
                    {
                        txt = atts[0].ToString(); 
                    }

                    Console.Write("Qual o conteúdo de {0}? ", txt);
                    var conteudo = Console.ReadLine();

                    item.SetValue(obj, Convert.ChangeType(conteudo, item.PropertyType));
                }
            }

            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
