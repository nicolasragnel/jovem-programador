using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    internal class ParametroopcionalMetodo
    {
        public static void CriarLembrete(string lembrete, int tempo = 2000)
        {
            // Espera para executar a próxima linha
            Thread.Sleep(tempo);
            Console.WriteLine(lembrete);
        }
    }
}
