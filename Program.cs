using System;

namespace POV
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int resultado1 = program.funcaoRetornaQuantitadePOV(0.1m, 90);
            int resultado2 = program.funcaoRetornaQuantitadePOV(0.1m, 100);
            int resultado3 = program.funcaoRetornaQuantitadePOV(0.2m, 70);

            Console.WriteLine(resultado1.ToString());
            Console.WriteLine(resultado2.ToString());
            Console.WriteLine(resultado3.ToString());
        }

        int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado) {
            return (int) Math.Truncate(porcentagem * totalNegociado / (1 - porcentagem));
        }
    }
}