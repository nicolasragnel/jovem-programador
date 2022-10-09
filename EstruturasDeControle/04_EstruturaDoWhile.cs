using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            var pegueiNumero = true;
            do
            {
                Console.WriteLine("Favor informar um número.");
                if (double.TryParse(Console.ReadLine(), out double valor))
                {
                    pegueiNumero = false;
                    Console.WriteLine("Obrigado!");
                }
                else
                {
                    Console.WriteLine("Isso não é um número!");
                }

            } while (pegueiNumero);
        }
    }
}
