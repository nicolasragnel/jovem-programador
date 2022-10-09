using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodos
{
    public class Carro
    {
        public string Marca = string.Empty;
        public string Modelo = string.Empty;
        public int Ano;

        public Carro() { }
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine("=-= Relatório de Veículo  =-=");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine($"Marca: {Marca}");
            sb.AppendLine($"Modelo: {Modelo}");
            sb.AppendLine($"Ano: {Ano}");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            return sb.ToString();
        }
    }

    internal class Contrutores
    {
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Marca = "Fiat";
            carro1.Modelo = "Uno";
            carro1.Ano = 83;

            Console.WriteLine("Marca: {0}. Modelo: {1}. Ano: {2}.", carro1.Marca, carro1.Modelo, carro1.Ano);

            Console.WriteLine(carro1.ToString());

            Carro carro2 = new Carro("Volkswagem", "Fusca", 85);
            Console.WriteLine("Marca: {0}. Modelo: {1}. Ano: {2}.", carro2.Marca, carro2.Modelo, carro2.Ano);
            Console.WriteLine(carro2.ToString());
        }
    }
}
