using System;
using System.Globalization;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class FormatandoNumero
    {

        public static void Executar() {
            double valor = 28.195;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));

            int inteiro = 236;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
