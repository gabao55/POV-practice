using System;

namespace POV
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado1 = PovCalculator.funcaoRetornaQuantitadePOV(0.1m, 90);
            int resultado2 = PovCalculator.funcaoRetornaQuantitadePOV(0.1m, 100);
            int resultado3 = PovCalculator.funcaoRetornaQuantitadePOV(0.2m, 70);

            Console.WriteLine(resultado1.ToString());
            Console.WriteLine(resultado2.ToString());
            Console.WriteLine(resultado3.ToString());
        }
    }

    public static class PovCalculator
    {
        public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) {
            return (int) Math.Truncate(porcentagem * totalNegociado / (1 - porcentagem));
        }
    }
}