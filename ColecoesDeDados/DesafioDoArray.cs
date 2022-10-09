using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class DesafioDoArray
    {
        public static void Executar()
        {
            var arrayOriginal = new string[]
            {
                "Marco",
                "Denis",
                "Marcos",
                "Caio"
            };

            var auxArray = new string[arrayOriginal.Length + 1];

            int index = 0;
            foreach(var valor in arrayOriginal)
            {
                auxArray[index] = valor;
                index++;
            }

            auxArray[index] = "Bryan";

            Console.WriteLine(String.Join(',', arrayOriginal));
            Console.WriteLine(String.Join(',', auxArray));
        }
    }
}
