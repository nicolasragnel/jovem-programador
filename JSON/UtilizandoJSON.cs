using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AulasCSharp.JSON
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Nacionalidade { get; set; }

        public Pessoa(string nome, string idade, string nacionalidade)
        {
            Nome = nome;
            Idade = idade;
            Nacionalidade = nacionalidade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}. Idade: {Idade}. Nacionalidade: {Nacionalidade}";
        }
    }

    internal class UtilizandoJSON
    {
        public static void Executar()
        {
            var controle = true;
            List<Pessoa> pessoas = new List<Pessoa>();

            do
            {
                Console.WriteLine("Informe o nome ou SAIR para sair.");
                var nome = Console.ReadLine();

                if (nome.ToUpper() == "SAIR")
                {
                    break;
                }

                Console.WriteLine("Informe a idade.");
                var idade = Console.ReadLine();
                Console.WriteLine("Informe a nacionalidade.");
                var nacionalidade = Console.ReadLine();

                pessoas.Add(new Pessoa(nome, idade, nacionalidade));
            } while (controle);

            Console.WriteLine(JsonConvert.SerializeObject(pessoas));
        }

        public static void LerJson()
        {
            string textoArquivo = new StreamReader(@"C:\Users\marco\Downloads\CursoProgramacaoCSharp (2)\AulasCSharp\JSON\OrigemDeDados\DadosJSON.txt").ReadToEnd();
            List<Pessoa> pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(textoArquivo);

            foreach(var valor in pessoas)
            {
                Console.WriteLine(valor.ToString());
            }
        }
    }
}
