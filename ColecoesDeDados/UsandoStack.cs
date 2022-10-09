using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class UsandoStack
    {
        public static void Executar()
        {
            var pilha = new Stack<string>();
            pilha.Push("Marco");
            pilha.Push("Poliana");
            pilha.Push("Gustavo");
            pilha.Push("Denis");
            pilha.Push("Thayse");

            // Retornar o último da fila, mas ele continua lá.
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Count());

            // Remover e retonar o último da fila.
            Console.WriteLine(pilha.Pop());
            Console.WriteLine(pilha.Count());

            foreach (var valor in pilha)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine(pilha.Count());
        }
    }
}
