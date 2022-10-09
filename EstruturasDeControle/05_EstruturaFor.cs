using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o número que você deseja a tabuada.");
            if (int.TryParse(Console.ReadLine(), out int numeroTabuada))
            {
                var sb = new StringBuilder();
                sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                sb.AppendLine($" TABUADA DO NÚMERO {numeroTabuada} ");
                sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                for (int i = 1; i < 11; i++)
                {
                    sb.AppendLine($"{numeroTabuada} X {i} = {(numeroTabuada * i)}");
                }

                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Isso não é um número!");
            }
        }
    }
}
