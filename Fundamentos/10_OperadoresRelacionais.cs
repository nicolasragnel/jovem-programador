using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar() {
            // double nota = 6.0;
            Console.Write("Digite a nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            // Maior que
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);

            // Menor que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);

            if ((nota < 0) || (nota > 10))
            {
                Console.WriteLine("Essa nota é inválida.");
            }

            // Igual a
            Console.WriteLine("Perfeito? {0}", nota == 10.0);

            // Diferente de
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);

            // Maior ou igual a
            Console.WriteLine("Passou por média? {0}", nota >= notaDeCorte);

            // Menor que
            Console.WriteLine("Recuperação? {0}", nota < notaDeCorte);

            // Menor ou igual a
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
