using System;

namespace Diagrama_12
{
    class Program
    {
        static void Main(string[] args)
        {
             Conversor.CotacaoDolar = 5.24f;
            Conversor.CotacaoEuro = 5.90f;
            Conversor.CotacaoReal = 1;
            Console.WriteLine($"Um dolar equivale a: $ {Conversor.ConverterRealParaDolar(38f)} reais");
            Console.WriteLine($"O valor em dolar é de R$ {Conversor.ConverterRealParaDolar(467.99f)}");
            Console.WriteLine($"O valor em euro é de $ {Conversor.ConverterDolarParaEuro(78f)}");
        }
    }
}
