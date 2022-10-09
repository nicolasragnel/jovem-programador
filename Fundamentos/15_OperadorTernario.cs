using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacaoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar()
        {
            Console.WriteLine("Respostas válidas:");
            Console.WriteLine("I - Indeterminado:");
            Console.WriteLine("S - Sim:");
            Console.WriteLine("N - Não:");
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("Informe sua resposta:");
            var entrada = Console.ReadLine()?.ToUpper() ?? string.Empty ;

            if (entrada == "S" || entrada == "N" || entrada == "I")
            {
                var result = (entrada == "S" ? 1 : (entrada == "N" ? 2 : 0));
                Armazenar(result);
                Console.WriteLine("Armazenamento completo!");
            }
            else
            {
                Executar();
            }
        }

        public static void Armazenar(int valor)
        {
            Console.WriteLine($"Valor {valor} armazenado.");
        }
    }
}
