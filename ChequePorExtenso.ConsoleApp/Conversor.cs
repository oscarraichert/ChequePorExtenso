using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.ConsoleApp
{
    public class Conversor
    {
        Dictionary<string, string> CasaSingular;
        Dictionary<string, string> CasaDezena;
        Dictionary<string, string> CasaCentena;

        public Conversor()
        {
            CasaSingular = new Dictionary<string, string>
            {
                {"1", "um"},
                {"2", "dois"},
                {"3", "três"},
                {"4", "quatro"},
                {"5", "cinco"},
                {"6", "seis"},
                {"7", "sete"},
                {"8", "oito"},
                {"9", "nove"}
            };

            CasaDezena = new Dictionary<string, string>
            {
                {"1", "dez"},
                {"2", "vinte"},
                {"3", "trinta"},
                {"4", "quarenta"},
                {"5", "cinquenta"},
                {"6", "sessenta"},
                {"7", "setenta"},
                {"8", "oitenta"},
                {"9", "noventa"}
            };

            CasaCentena = new Dictionary<string, string>
            {
                {"1", "cento"},
                {"2", "duzentos"},
                {"3", "trezentos"},
                {"4", "quatrocentos"},
                {"5", "quinhentos"},
                {"6", "seiscentos"},
                {"7", "setecentos"},
                {"8", "oitocentos"},
                {"9", "novecentos"}
            };
        }

        public void ConverterNumero()
        {
            string input = Console.ReadLine();

            var stringsSeparadas = input.Split('.').ToList();
            var numeroConvertido = TransformarEmExtenso(stringsSeparadas);

            var frase = string.Join("", numeroConvertido);

            Console.WriteLine(frase);
        }

        private List<string> TransformarEmExtenso(List<string> classesNumericas)
        {
            string espaco = " "; //34.456
            string e = "e ";

            List<string> numerosConvertidos = new();

            var dictionaries = new[] { CasaSingular, CasaDezena, CasaCentena };

            classesNumericas.Reverse();

            foreach (var classe in classesNumericas)
            {
                var classeReversa = classe.Reverse().ToList(); //43.654

                for (int i = 0; i < classe.Length; i++)
                {
                    var numero = dictionaries[i][$"{classeReversa[i]}"];
                    numerosConvertidos.Add(numero);
                }
            }

            numerosConvertidos.Reverse();

            return numerosConvertidos;
        }
    }
}