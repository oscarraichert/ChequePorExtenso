using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.ConsoleApp
{
    public class Classe
    {
        public string Unidade;
        public string Dezena;
        public string Centena;

        public override string ToString()
        {
            return VerificarCasas();
        }

        private string VerificarCasas()
        {
            if (Centena == null)
            {
                return $"{Dezena} e {Unidade}";
            }

            if (Dezena == null)
            {
                return $"{Unidade}";
            }

            return $"{Centena} e {Dezena} e {Unidade}";
        }
    }
}
