using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.Atividades
{
    class MediaAlunos
    {
        // pedir ao usuario o nome, idade e escola do aluno
        // pedir a nota de cada matéria e fazer a média 
        // apresentar o resultado ao usuário
        public static void Executar()
        {
            // informações do aluno
            Console.WriteLine("Informe o nome do aluno");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Informe a idade do aluno");
            int idadeAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Informa a escola do aluno");
            string escolaAluno = Console.ReadLine();

            // notas do aluno
            Console.WriteLine("Informe a nota da matéria de Português");
            int notaPortugues = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de Matemática");
            int notaMatematica = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de Ciências");
            int notaCiências = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de Geográfia");
            int notaGeografia = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de História");
            int notaHistoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de Inglês");
            int notaIngles = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a nota da matéria de Educação Física");
            int notaEFisica = int.Parse(Console.ReadLine());

            // calculando a média
            var soma = (notaPortugues + notaMatematica + notaCiências + notaGeografia + notaHistoria + notaIngles + notaEFisica);
            int media = soma / 7;

           // apresentando o resultado ao usuário
           if (media >= 7)
           {
                Console.WriteLine("Parabéns! " + nomeAluno + " Você está Aprovado!");
           }
           else if (media < 7 && media >= 5)
           {
                Console.WriteLine(nomeAluno + " você está de Recuperação, estude um pouco mais.");
           }
           else 
           {
                Console.WriteLine("O aluno" + nomeAluno + " não atingiu a média e está Reprovado.");
           }
        }
    }
}
