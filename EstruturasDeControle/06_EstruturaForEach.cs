using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeControle
{
    internal class EstruturaForEach
    {
        public static void Executar()
        {
            var nome = "Marco Antonio Angelo";
            foreach (var value in nome)
            {
                char result = value;
                if (value == 'a' || value == 'e' || value == 'i' || value == 'o' || value == 'u')
                {
                    result = 'X';
                }
                Console.Write(result);
            }

            var list = new List<int>() { 101, 2022, 36 };
            foreach (var value in list)
            {
                Console.WriteLine($"Valor: {value}");
            }
        }
    }
}
