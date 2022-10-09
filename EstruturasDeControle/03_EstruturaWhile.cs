using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolinha
{
    internal class EstruturaWhile
    {
        const int NUMERO_TENTATIVAS = 10;
        public static void Executar()
        {
            var objetoQuePegaNumeroAleatorio = new Random();
            var meuNumero = objetoQuePegaNumeroAleatorio.Next(0, 40);

            bool numeroEncontrado = false;
            int numeroTentativasFeitas = 0;
            int numeroTentativasRestantes = NUMERO_TENTATIVAS;
            var corPadraoConsole = Console.BackgroundColor;

            while (numeroTentativasRestantes >= 0 && !numeroEncontrado)
            {
                Console.WriteLine("Informe seu palpite: ");
                int.TryParse(Console.ReadLine(), out int entrada);

                numeroTentativasFeitas++;
                numeroTentativasRestantes--;


                if (meuNumero == entrada)
                {
                    numeroEncontrado = true;
                    Console.BackgroundColor = ConsoleColor.Green;

                    Console.WriteLine($"Parabéns, você acertou em {numeroTentativasFeitas} tentativas!");
                    Console.BackgroundColor = corPadraoConsole;
                }
                else if (entrada > meuNumero)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você errou, o seu número foi muito alto...");
                    Console.WriteLine($"Qtd tentativas restantes: {(NUMERO_TENTATIVAS - numeroTentativasFeitas)}.");
                    Console.BackgroundColor = corPadraoConsole;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Você errou, o seu número foi muito baixo...");
                    Console.WriteLine($"Qtd tentativas restantes: {(NUMERO_TENTATIVAS - numeroTentativasFeitas)}.");
                    Console.BackgroundColor = corPadraoConsole;
                }
            }

            Console.WriteLine("Você deseja jogar novamente? Sim(Y) Não(N)");
            var resposta = Console.ReadLine()?.ToUpper();
            if (resposta == "Y")
            {
                Console.Clear();
                Executar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("FIM DE JOGO!");
            }

            //while (controle && numeroTentativasFeitas < NUMERO_TENTATIVAS)
            //{
            //    Console.WriteLine("Informe seu palpite: ");
            //    int.TryParse(Console.ReadLine(), out int entrada);

            //    if (controle)
            //    {
            //        if (entrada == meuNumero)
            //        {
            //            Console.WriteLine($"Parabéns, você acertou em {numeroTentativasFeitas} tentativas!");
            //            controle = false;
            //        }
            //        else if (meuNumero > entrada)
            //        {
            //            Console.WriteLine("Você errou, o seu número foi muito baixo...");
            //            Console.WriteLine($"Qtd tentativas restantes: {(NUMERO_TENTATIVAS - (numeroTentativasFeitas + 1))}.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Você errou, o seu número foi muito alto...");
            //            Console.WriteLine($"Qtd tentativas restantes: {(NUMERO_TENTATIVAS - (numeroTentativasFeitas + 1))}.");
            //        }
            //    }

            //    numeroTentativasFeitas++;

            //    if (numeroTentativasFeitas + 1 > NUMERO_TENTATIVAS)
            //    {
            //        controle = true;
            //        Console.WriteLine("Você não possuim mais tentativas restantes...");
            //    }
            //}
        }
    }
}
