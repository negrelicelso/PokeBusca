using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeBusca.Utilitarios
{
    public class UtilitariosPoke
    {
        public string CapitalizarPrimeiraLetra(string palavra)
        {
            return Char.ToUpper(palavra[0]) + palavra.Substring(1);
        }
    }
}
