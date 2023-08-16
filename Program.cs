using System;

namespace ComparacaoStrings
{
        internal class Program
    {
        private static void Main(string[] args)
        {
            var texto = "Este texto é um teste";

            Console.WriteLine(texto.Contains("teste")); //este texto contém a palavra teste?
            Console.WriteLine(texto.Contains("Teste")); //este texto contém a palavra teste com T?

            //Ignorando o case-sensitive:
            Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));


            //Outra forma de comparação
            Console.WriteLine(texto.CompareTo("Testando"));
            Console.WriteLine(texto.CompareTo("testando"));
            


        }
    }

}