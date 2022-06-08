using ChequePorExtenso.ConsoleApp;
using NUnit.Framework;

namespace ChequePorExtenso.Tests
{
    public class Tests
    {
        private Conversor conversor;

        [SetUp]
        public void Setup()
        {
            conversor = new Conversor();
        }

        [Test]
        public void DeveConverter523ParaExtenso()
        {
            var result = conversor.ConverterNumero("523");

            Assert.AreEqual("quinhentos e vinte e três", result);
        }

        [Test]
        public void DeveConverter652mil519ParaExtenso()
        {
            var result = conversor.ConverterNumero("652.519");

            Assert.AreEqual("seiscentos e cinquenta e dois mil quinhentos e dezenove", result);
        }
    }
}