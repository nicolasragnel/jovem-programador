using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    public class DadosContato
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }

    internal class UsandoDictionary
    {
        public static Dictionary<int, List<string>> Pessoas = new Dictionary<int, List<string>>();



        public static void Executar()
        {
            Dictionary<string, DadosContato> Agenda = new Dictionary<string, DadosContato>();

            var contato1 = new DadosContato()
            {
                Nome = "Marco",
                Endereco = "Estrada de tijolos de ouro",
                Email = "marco@Marco.com.br",
                Numero = "9999-8888",
            };

            var contato2 = new DadosContato()
            {
                Nome = "Fulaninho",
                Endereco = "Estrada de tijolos de ouro",
                Email = "Fulaninho@Marco.com.br",
                Numero = "9999-8877",
            };

            var contato3 = new DadosContato()
            {
                Nome = "Peltrano",
                Endereco = "Estrada de tijolos de ouro",
                Email = "Peltrano@Marco.com.br",
                Numero = "9999-8866",
            };


            Agenda.Add(contato1.Numero, contato1);
            Agenda.Add(contato2.Numero, contato2);
            Agenda.Add(contato3.Numero, contato3);

            Console.WriteLine(Agenda["9999-8888"].ToString());
        }

        public static void AdicionarPessoas()
        {
            var controle = true;

            do
            {
                Console.WriteLine("Informe seu nome");
                var nome = Console.ReadLine() ?? String.Empty;

                if (nome.ToLower() == "sair")
                {
                    break;
                }

                Console.WriteLine("Informe seu ano de nascimento.");
                int.TryParse(Console.ReadLine(), out int ano);


                if (!Pessoas.ContainsKey(ano))
                {
                    Pessoas.Add(ano, new List<string>());
                }

                Pessoas[ano].Add(nome);

            } while (controle);
        }

        public static void ListarAmiguinhos()
        {
            Console.Clear();
            var sb = new StringBuilder();

            foreach (var valor in Pessoas)
            {
                sb.AppendLine($"Pessoas nascidas em {valor.Key}");
                sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                var count = 1;
                foreach (var valorLista in valor.Value)
                {
                    sb.AppendLine($"{count}. {valorLista}");
                    count++;
                }
                sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                sb.AppendLine(string.Empty);
            }

            Console.WriteLine(sb.ToString());
        }

        static Dictionary<int, List<string>> filmesPorAno = new Dictionary<int, List<string>>()
            {
                {2015, new List<string>() { "Perdido em Marte", "O REGRESSO" } },
                {2014, new List<string>() { "As Above, So Below", "Corações de Ferro" } },
                {2001, new List<string>() { "Harry Potter e a preda" } },
                {2019, new List<string>() { "Avengers: Endgame" } },
                {2021, new List<string>() { "Encanto" } },
                {2005, new List<string>() { "Orgulho e preconceito" } },
                {2022, new List<string>() { "Minions 2: A Origem de Gru 2022" } },
                {2010, new List<string>() { "Shutter Island" } },
                {2000, new List<string>() { "Pokemon" } },
                {1993, new List<string>() { "O Estranho Mundo De Jack" } },
                {2017, new List<string>() { "Até o ultimo Homem" } },
                {2004, new List<string>() { "Howl's Moving Castle" } },
                {2002, new List<string>() { "A era do gelo" } },
                {1980, new List<string>() { "Lagoa Azul" } },
            };

        public static void ListarFilmes(int anoLancamento)
        {
            Console.WriteLine(String.Join(',', filmesPorAno[anoLancamento]));
        }
    }
}
