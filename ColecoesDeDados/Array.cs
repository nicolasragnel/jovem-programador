using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class Array
    {
        public static void Executar()
        {
            // Obrigatório informar o tamanho do Array.
            string[] alunos = new string[3];
            alunos[0] = "Pedrinho";
            alunos[1] = "Joãozinho";
            alunos[2] = "Fulaninho";

            // Percorre os dados armazenados.
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            // Soma com foreach.
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            // Somar com for.
            for (int i = 0; i < notas.Length; i++)
            {
                somatorio += notas[i];
            }

            // Obtenção de média.
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
