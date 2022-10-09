using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class UsandoQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Marco");
            fila.Enqueue("Poliana");
            fila.Enqueue("Gustavo");
            fila.Enqueue("Denis");
            fila.Enqueue("Thayse");

            // Retornar o primeiro da fila, mas ele continua lá.
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            // Remover e retonar o primeiro da fila.
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var valor in fila)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine(fila.Count);
        }
    }
}
