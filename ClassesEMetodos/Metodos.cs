using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    public class Calculadora
    {
        private double Valor1 { get; set; }
        private double Valor2 { get; set; }

        public Calculadora(double valor1, double valor2) {
            Valor1 = valor1;
            Valor2 = valor2;
        }

        // Receita para criar método
        // 1- Nível de acesso
        // 2- Retorno do método => Tipo do valor que vai ser retornado.
        //  Void => Método sem retorno.
        // 3- Nome do Método (Deve ser único)

        /* Oq é a assinatura do método?
         * A assinatura do método se trata de tudo que está entre os () na declaração.
         * Isso é tido como um identificador único, em casos de sobrecarga.
         * 
         * Por exemplo:
         * Método: double FazerMedia(double valor1, double valor2, double valor3)
         * 
         * No método assima podemos afirmar que sua assinatura possui três elementos (Parâmetros)
         * Assinatura: [Double, Double e Double].
         * 
         * Todo elemento na assinatura do método ou construtor é chamado de parâmetro.
         */

        // Assinatura: []
        public double Soma()
        {
            var resultado = Valor1 + Valor2;
            return resultado;
        }

        //// Assinatura: [int]
        //public double Soma(int a)
        //{
        //    return 0;
        //}

        //// Assinatura: [double]
        //public double Soma(double a)
        //{
        //    // Variáveis não possuem assinatura. Por isso não é possível fazer:
        //    string Textu = "";
        //    double Textu = 8;

        //    return 0;
        //}

        public string ExisteParAqui()
        {
            var contador = 0;
            contador += Valor1 % 2 == 0 ? 1 : 0;
            contador += Valor2 % 2 == 0 ? 1 : 0;

            if (contador > 0)
            {
                return string.Format("Existe {0} valores pares.", contador);
            }
            else
            {
                return "Não existe valores pares.";
            }
        }
    }

    public class CalculadoraEmCadeia { 
        /*
         * 1. Implementar contrutor que recebe um valor do tipo Double
         * 1.1. Esse valor deve ser armazenado internamente e se chamar ValorAtual
         * 
         * 2. Alterar para que o método Soma utilize o valor atual da calculadora para realizar a operação.
         * 2.1. O Método deve receber por parâmetro um double, o qual deve ser utilizado na soma.
         * 2.2. O retorno do método deve ser o resultado da operação.
         * 
         * 3. Criar os métodos Subtracao, Divisao e Multiplicacao com o mesmo funcionamento do Soma.
         */

        public double Soma()
        {
            return 0;
        }
    }

    internal class Metodos
    {
        public static void Executar()
        {
            // Executar Calculadora em Cadeia
            // Pedir valor inicial na primeira vez
            // Pedir para o usuário o valor
            // Pedir para o usuário a operação.
            // Apresentar resultado
        }
    }
}
