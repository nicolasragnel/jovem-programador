using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProgramacaoCSharp.EstruturasDeControle
{
    public class EstruturaIf
    {
        const double NOTA_CORTE = 7.0;
        const double NOTA_REPROVACAO = 3.0;

        public static void Executar()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine("=-=-=-=-= Sistema de notas =-=-=-=-=");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine("------  Dados do aluno  ----------");

            Console.WriteLine("Informe o Nome:");
            sb.AppendLine($"- Nome: {Console.ReadLine()}");
            Console.WriteLine("Informe a Idade:");
            sb.AppendLine($"- Idade: {Console.ReadLine()}");
            Console.WriteLine("Informe a Escola:");
            sb.AppendLine($"- Escola: {Console.ReadLine()}");
            sb.AppendLine("-----------------------------------");

            Console.Clear();
            Console.WriteLine(sb.ToString());


            bool aprovado = false;

            Console.WriteLine("Informe a nota do aluno");
            double nota = double.Parse(Console.ReadLine() ?? "0");

            bool notaValida = nota <= 10 && nota >= 0;
            if (!notaValida)
            {
                Console.WriteLine("Essa nota é inválida!");
                Console.WriteLine("Pressione qualquer tecla para tentar novamente!");
                Console.ReadKey();

                Console.Clear();
                Executar();
            }

            if (nota >= NOTA_CORTE)
            {
                Console.WriteLine("Esse aluno foi aprovado!");
            }
            else if (nota > NOTA_REPROVACAO)
            {
                Console.WriteLine("Esse aluno está em recuperação");
            }
            else
            {
                Console.WriteLine("Esse aluno está reprovado");
            }

            //if (nota >= NOTA_CORTE)
            //{
            //    Console.WriteLine("Esse aluno foi aprovado!");
            //}
            //else
            //{
            //    if (nota <= NOTA_REPROVACAO)
            //    {
            //        Console.WriteLine("Esse aluno está reprovado");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Esse aluno está em recuperação");
            //    }
            //}


            // DRY Don't Repeat Yourself

            /*
             * Solicitar dados como: Nome, Idade, Escola e Nota;
             * Solicitar notas de mais materias (Pelo menos 5);
             * Gerar uma média geral.
             */
        }
    }
}
