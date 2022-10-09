using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            Console.WriteLine("Informe um número");
            int num1 = int.Parse(Console.ReadLine() ?? "0");
            // num1 = 7;
            num1 += 10; // num1 = num1 + 10 -> 17;
            num1 -= 3; // num1 = num1 - 3 -> 14;
            num1 *= 5; // num1 = num1 * 5 -> 70;
            num1 /= 2; // num1 = num1 / 2 -> 35;
            // num1 = 0;

            Console.WriteLine(num1);

            // Gabiarra
            // Console.WriteLine(((double)num1 / 2));

            int a = 1;
            int b = a; // b = 1

            a++; // a = a + 1;
            b--; // b = b - 1;

            int df = a + 5;
            df++;

            Console.WriteLine($"{a} {b} {df}");

            //// Não se preocupe com o código
            //dynamic c = new System.Dynamic.ExpandoObject();
            //c.nome = "João";

            //dynamic d = c;
            //d.nome = "Maria";

            //Console.WriteLine(c.nome);
        }
    }
}
