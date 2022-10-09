using System;
using System.Collections.Generic;
using System.Text;

namespace CursoProgramacaoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar() {
            string nome = "Celta";
            string marca = "Chevrolet";
            double preco = 28_000.00;

            Console.WriteLine("Hoje em dia o " + nome + " da "
                + marca + " tá custando R$" + preco + ".");
            Console.WriteLine("Hoje em dia o {0} da {1} tá custando {2}.", nome, marca, preco);
            Console.WriteLine(String.Format("Hoje em dia o {0} da {1} tá custando {2}.", nome, marca, preco));
            Console.WriteLine($"A {marca} é meio cara!");
            Console.WriteLine($"A parcelinha em 36 tá: R$ {preco / 36}! E eu nem botei juros!!!");
        }
    }
}
