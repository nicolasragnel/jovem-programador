using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            // tratamento para nulo
            string valor1 = null;
            Console.WriteLine(valor1?.Length);

            // Definindo valor caso nulo
            Console.WriteLine(valor1?.Length ?? 20);
        }
    }
}
