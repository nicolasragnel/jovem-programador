using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    internal class ClasseDeValor
    {
        public double Valor { get; set; }
    }

    internal class AtribuicaoPorValorEReferencia
    {
        public static void Executar()
        {
            #region Atribuição por valor
            double valorDouble1 = 10;
            double valorDouble2 = valorDouble1;

            Console.WriteLine($"Valor 1: {valorDouble1}");
            Console.WriteLine($"Valor 2: {valorDouble2}");

            valorDouble1++;
            valorDouble2--;

            Console.WriteLine($"Valor 1: {valorDouble1}");
            Console.WriteLine($"Valor 2: {valorDouble2}");
            Console.WriteLine(String.Empty);
            #endregion

            #region Atribuição por referência
            // Gera novo endereço de memória e atribui o valor.
            var classeDeValor1 = new ClasseDeValor() { Valor = 10 };
            // Gera novo endereço de memória e atribui o valor.
            var classeDeValor2 = new ClasseDeValor() { Valor = 10 };
            // Ele aponta para o enderenço de memória.
            var classeDeValor3 = classeDeValor2;

            Console.WriteLine($"Valor classe 1: {classeDeValor1.Valor}");
            Console.WriteLine($"Valor classe 2: {classeDeValor2.Valor}");
            Console.WriteLine($"Valor classe 3: {classeDeValor3.Valor}");

            // Aponta para um valor diferente.
            classeDeValor1.Valor = 110;

            // Apontam para o mesmo valor
            classeDeValor2.Valor = 220;
            classeDeValor3.Valor = 380;
            //

            Console.WriteLine(string.Empty);
            Console.WriteLine($"Valor classe 1: {classeDeValor1.Valor}");
            Console.WriteLine($"Valor classe 2: {classeDeValor2.Valor}");
            Console.WriteLine($"Valor classe 3: {classeDeValor3.Valor}");

            classeDeValor3 = new ClasseDeValor() { Valor = 200 };

            Console.WriteLine(string.Empty);
            Console.WriteLine($"Valor classe 1: {classeDeValor1.Valor}");
            Console.WriteLine($"Valor classe 2: {classeDeValor2.Valor}");
            Console.WriteLine($"Valor classe 3: {classeDeValor3.Valor}");


            Console.WriteLine(string.Empty);
            Adicionar10(classeDeValor3);
            Console.WriteLine($"Valor classe 3: {classeDeValor3.Valor}");

            double valorDoublee = 10;
            Console.WriteLine(string.Empty);
            Console.WriteLine($"Valor double: {valorDoublee}");
            Console.WriteLine(string.Empty);
            Adicionar10(valorDoublee);
            Console.WriteLine($"Valor double: {valorDoublee}");
            #endregion
        }

        public static void Adicionar10(ClasseDeValor valor)
        {
            valor.Valor += 10;
        }
        public static void Adicionar10(double valor)
        {
            valor += 10;
        }
    }
}
