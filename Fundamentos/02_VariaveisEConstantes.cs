using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        /*
         * Todas palavras em azul são reservadas do C#.
         * 
         * Para criação de variáveis utilizamos camelCase
         * 
         * Para criação de constantes utilizamos snake_case, porém, sempre em MAIÚSCULO.
         * 
         * Para criar propriedades, utilizamos PascalCase.
         */

        // Como declarar uma costante
        const double VALOR_PI = 3.14;

        public static void Executar() {
            // Formas de declarar variáveis:
            // Somente declaração:
            int var1;
            // Declarando com valor:
            int var2 = 10;

            // O separador de casas decimais no código sempre será '.', seguindo o padrão americado.
            // Ao ser apresentado no console, ele é de acordo com a linguagem do sistema (Idioma da máquina).

            // Como declarar uma variável.
            double raio = 4.5;
            // area da circunferencia <- não faça isso. Dê preferencia por nomes claros, sem a necessidade de comentários.

            // Como alterar o valor de uma variável.
            raio = 5.5;

            // Dá erro, não é possível alterar uma constante.
            //VALOR_PI = 3.1415;

            double area = VALOR_PI * (raio * raio);
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estamosEmAula = true;
            Console.WriteLine("Estamos em aula: " + estamosEmAula);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte pontosPlacar = sbyte.MinValue;
            Console.WriteLine("O placar está em: " + pontosPlacar);

            short salario = short.MaxValue;
            Console.WriteLine("Salário: R$" + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int: " + menorValorInt);

            // O Underline pode ser utilizado para facilitar a digitação ou entendimento. Não é obrigatório.
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long: " + menorValorLong);

            ulong populacaoMundial = 8_000_000_000;
            Console.WriteLine("População Mundial: " + populacaoMundial);

            float precoComputador = 3299.99F;
            Console.WriteLine("Preço Computador: " + precoComputador);

            double valorEmConta = 100.00;
            Console.WriteLine("Valor em conta: " + valorEmConta);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Valor máximo Decimal: " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);
        }
    }
}
