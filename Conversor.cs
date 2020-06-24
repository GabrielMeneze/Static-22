namespace Diagrama_12
{
    public class Conversor
    {
                public static float CotacaoDolar { get; set; }
        public static float CotacaoEuro { get; set; }

        public static float CotacaoReal { get; set; }

        public static float ConverterRealParaDolar(float valor){
            return CotacaoReal * CotacaoDolar;
        }

        public static float ConverterDolarParaReal(float valor){
            return valor * CotacaoDolar;
        }
        public static float ConverterRealParaEuro(float valor){
            return valor / CotacaoEuro;

        }
        public static float ConverterEuroParaReal(float valor){
            return valor * CotacaoEuro;

        }
        public static float ConverterDolarParaEuro(float valor){
            return valor / CotacaoEuro;

        }
        public static float ConverterEuroParaDolar(float valor){
            return valor * CotacaoEuro;

        }


    }
}