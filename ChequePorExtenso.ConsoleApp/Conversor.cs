using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChequePorExtenso.ConsoleApp
{
    public class Conversor
    {
        readonly Dictionary<char, string> CasaSingular;
        readonly Dictionary<char, string> CasaDezena;
        readonly Dictionary<char, string> CasaCentena;
        readonly List<string> NomeClasse;

        public Conversor()
        {
            CasaSingular = new Dictionary<char, string>
            {
                {'0', ""},
                {'1', "um"},
                {'2', "dois"},
                {'3', "três"},
                {'4', "quatro"},
                {'5', "cinco"},
                {'6', "seis"},
                {'7', "sete"},
                {'8', "oito"},
                {'9', "nove"}
            };

            CasaDezena = new Dictionary<char, string>
            {
                {'0', ""},
                {'1', "dez"},
                {'2', "vinte"},
                {'3', "trinta"},
                {'4', "quarenta"},
                {'5', "cinquenta"},
                {'6', "sessenta"},
                {'7', "setenta"},
                {'8', "oitenta"},
                {'9', "noventa"}
            };

            CasaCentena = new Dictionary<char, string>
            {
                {'0', ""},
                {'1', "cento"},
                {'2', "duzentos"},
                {'3', "trezentos"},
                {'4', "quatrocentos"},
                {'5', "quinhentos"},
                {'6', "seiscentos"},
                {'7', "setecentos"},
                {'8', "oitocentos"},
                {'9', "novecentos"}
            };

            NomeClasse = new List<string>
            {
                {""},
                {"mil"},
                {"milhões"},
                {"bilhões"},
                {"trilhões"},
                {"quatrilhão"},
                {"quintilhão"},
                {"sextilhão"},
                {"septilhão"},
                {"octilhão"}
            };
        }

        public string ConverterNumero(string input)
        {
            var stringsSeparadas = input.Split('.').ToList();
            var classesEmExtenso = CriarClassesETransformarEmString(stringsSeparadas);
            var x = NomeandoClasses(classesEmExtenso);

            return string.Join(' ', x).Trim();
        }

        private List<string> NomeandoClasses(List<Classe> classesEmExtenso) 
        {
            List<string> classesNomeadas = new();

            classesEmExtenso.Reverse();

            var numClasses = classesEmExtenso.Count;

            for (int i = 0; i < numClasses; i++)
            {
                classesNomeadas.Add($"{classesEmExtenso[i]} {NomeClasse[i]}");
            }

            classesNomeadas.Reverse();

            return classesNomeadas;
        }

        private List<Classe> CriarClassesETransformarEmString(List<string> classesNumericas)
        {
            List<Classe> classes = new();

            foreach (var classe in classesNumericas)
            {
                var reverso = classe.Reverse().ToArray();

                var classeExtenso = new Classe
                {
                    Unidade = CasaSingular[reverso[0]],
                    Dezena = classe.Length > 1 ? CasaDezena[reverso[1]] : null,
                    Centena = classe.Length > 2 ? CasaCentena[reverso[2]] : null
                };

                classes.Add(classeExtenso);
            }

            return classes;
        }
    }
}