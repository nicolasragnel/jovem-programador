using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeControle
{
    internal class BreakContinue
    {
        public static void Executar()
        {
            var random = new Random();
            var meuNumero = random.Next(1, 100);

            for (int i = 1; i < 101; i++)
            {
                if (i == meuNumero)
                {
                    Console.WriteLine($"Meu programinha achou o número {meuNumero}!");
                }
                else
                {
                    continue;
                }

                var ehPar = i % 2 == 0;
                if (ehPar)
                {
                    Console.WriteLine($"Esse número é par!");
                }
                else
                {
                    Console.WriteLine($"Esse número é ímpar!");
                }

                break;
            }
        }
    }
}
