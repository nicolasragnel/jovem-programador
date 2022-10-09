using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.Fundamentos
{
    internal class UsandoDateTime
    {
        public static void Executar()
        {
            // Cria uma variável de data com a data Atual
            DateTime dateTime = DateTime.Now;

            var dateTime2 = new DateTime(year: 2022, month: 8, day: 25);
            Console.WriteLine(dateTime2.ToString());

            Console.WriteLine(dateTime2.Year);
            Console.WriteLine(dateTime2.Month);
            Console.WriteLine(dateTime2.Day);

            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine(DateTime.Today.ToString());

            var amanha = DateTime.Today.AddDays(1);
            var ontem = DateTime.Today.AddDays(-1);

            Console.WriteLine(ontem);
            Console.WriteLine(amanha);

            var hoje = DateTime.Today;
            Console.WriteLine(hoje.ToString("d"));
            Console.WriteLine(hoje.ToString("dd"));
            Console.WriteLine(hoje.ToString("ddd"));
            Console.WriteLine(hoje.ToString("dddd"));
            Console.WriteLine(hoje.ToString("D"));
            Console.WriteLine(hoje.ToString("g"));
            Console.WriteLine(hoje.ToString("G"));
            Console.WriteLine(hoje.ToString("MM/dd/yyyy"));
        }

        /* Objetivo
         * Criar marcações de ponto no console
         * 
         * Devem estar entre 7:50 e 8:10
         * Devem estar entre 11:50 e 12:10
         * Devem estar entre 12:50 e 13:40
         * Devem estar entre 17:30 e 18:10
         * 
         */

        public static void MarcacoesAleatorias(int qtd)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Relatório de ponto {DateTime.Today.ToString("dd/MM/yyyy")}");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            for (int i = 0; i < qtd; i++)
            {
                sb.AppendLine($"Colaborador: Funcionario_{i + 1}");
                sb.AppendLine("----------------");

                Random random = new Random();
                DateTime dataManha01 = new DateTime(1, 1, 1, 7, 50, 0);
                DateTime dataManha02 = new DateTime(1, 1, 1, 11, 50, 0);
                DateTime dataTarde01 = new DateTime(1, 1, 1, 12, 50, 0);
                DateTime dataTarde02 = new DateTime(1, 1, 1, 17, 30, 0);

                dataManha01 = dataManha01.AddMinutes(random.Next(0, 20));
                dataManha02 = dataManha02.AddMinutes(random.Next(0, 20));
                dataTarde01 = dataTarde01.AddMinutes(random.Next(0, 50));
                dataTarde02 = dataTarde02.AddMinutes(random.Next(0, 40));

                sb.AppendLine($"Marcações: {dataManha01.ToString("t")} {dataManha02.ToString("t")} {dataTarde01.ToString("t")} {dataTarde02.ToString("t")}");
                sb.AppendLine("----------------");
                sb.AppendLine(String.Empty);
            }

            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(sb.ToString());
        }
    }
}
