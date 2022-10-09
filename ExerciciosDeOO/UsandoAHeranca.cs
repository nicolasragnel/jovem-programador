using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ExerciciosDeOO
{
    internal class UsandoAHeranca
    {
        public static void Executar()
        {
            var veiculos = new List<Veiculo>();

            var z1000 = new Z1000RR("Branca");
            var kombi = new Kombi("Branca");

            veiculos.Add(z1000);
            veiculos.Add(kombi);

            foreach(var veiculo in veiculos)
            {
                Console.WriteLine(veiculo.ToString());
                veiculo.Locomover();

                Console.WriteLine($"É Moto: {veiculo is Moto}");
                Console.WriteLine($"É Carro: {veiculo is Carro}");
            }
        }
    }
}
