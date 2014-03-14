using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class QuatroOperacoes
    {
        public static double Somar(double a, double b) { return a + b; }
        public static double Subtrair(double a, double b) { return a - b; }
        public static double Multiplicar(double a, double b) { return a * b; }
        public static double Dividir(double a, double b) { return a / b; }
        
        public static void FazerNada() { }

        public static double OutroSomar(double x, double y) { return Somar(x, y); }
    }
}
