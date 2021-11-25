using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DataAccessLayer.Utils
{
    public static class StringUtils
    {
        /// <summary>
        /// Capitalizar todas as iniciais das palavras 
        /// </summary>
        public static string ToTitleCase(this string param)
        {
            var cultura = new CultureInfo("pt-BR", false).TextInfo;
            var resultado = cultura.ToTitleCase(param);

            return resultado;
        }
    }
}
