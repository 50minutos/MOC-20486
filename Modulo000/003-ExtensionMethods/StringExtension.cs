using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_ExtensionMethods
{
    /// <summary>
    /// classe de extensão para Strings
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Obtém o comprimento da String 
        /// </summary>
        /// <param name="s">String que terá o comprimento retornado</param>
        /// <returns>comprimento da string</returns>
        public static int GetLenght(this String s)
        {
            var retorno = 0;

            foreach (var item in s)
            {
                retorno++;
            }

            return retorno;
        }
    }
}
