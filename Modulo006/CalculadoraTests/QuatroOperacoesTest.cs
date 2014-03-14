using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Calculadora;

namespace CalculadoraTests
{
    [TestClass]
    public class QuatroOperacoesTest
    {
        [TestMethod]
        public void TestSomar()
        {
            //preparação
            var x = 1;
            var y = 2;

            var z = x + y; //resultado esperado 

            //execução
            var r = QuatroOperacoes.Somar(x, y);

            //validação
            Assert.AreEqual(z, r);
        }
    }
}
