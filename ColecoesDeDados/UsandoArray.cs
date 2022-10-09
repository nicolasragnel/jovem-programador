using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class UsandoArray
    {
        public static void Executar()
        {
            int[] numeros1 = new int[6];
            numeros1[0] = 20;
            Console.WriteLine(string.Join(',', numeros1));
            //numeros1[7] = 30;

            int[] numeros2 = new int[]
            {
                6,80,90,40,70,
            };
            numeros2[1] = 22;
            Console.WriteLine(string.Join(',', numeros2));
        }
    }
}
