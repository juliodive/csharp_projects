

namespace CotacaoDoDolar {
    class ConversorDeMoeda {
        public static double Iof = 6.0;
        public static double Cotacao(double dolar, double quantia) {
            double result = dolar * quantia;
            return result + result * Iof / 100; 
        }

    }
}
