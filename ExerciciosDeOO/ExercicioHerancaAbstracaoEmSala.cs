using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ExerciciosDeOO
{
    public enum TipoCombustivel
    {
        Gasolina,
        Diesel,
        Alcool,
        Querosene,
        Gas
    }

    public interface IVeiculo { }
    public interface IEletrico { }
    public interface IUsaCombustivel
    {
        TipoCombustivel Combustivel { get; }
    }

    public abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public string Composicao { get; set; }
        public abstract double VelocidadeMaxima { get; }

        public Veiculo(string modelo, double peso, string cor, string composicao) { 
            Modelo = modelo;
            Cor = cor;
            Peso = peso;
            Composicao = composicao;
        }

        public abstract void Locomover();
    }
    public abstract class Terrestre : Veiculo
    {
        protected Terrestre(string modelo, double peso, string cor, string composicao) : base(modelo, peso, cor, composicao)
        {
        }

        public abstract int QtdRodas { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Informações do {Modelo}");
            sb.AppendLine($"Cor: {Cor}");
            sb.AppendLine($"Composição: {Composicao}");
            sb.AppendLine($"Velocidade Máxima: {VelocidadeMaxima}");
            sb.AppendLine($"Quantidade de rodas: {QtdRodas}");

            return sb.ToString();
        }
    }
    public abstract class Aereo : Veiculo
    {
        protected Aereo(string modelo, double peso, string cor) : base(modelo, peso, cor, "Fibra")
        {
        }

        public double AlturaMaxima { get; set; }
    }
    public abstract class Aquatico : Veiculo
    {
        protected Aquatico(string modelo, double peso, string cor) : base(modelo, peso, cor, "Fibra")
        {
        }

        public bool PodeSubmergir { get; set; }
    }

    public abstract class Carro : Terrestre
    {
        protected Carro(string modelo, double peso, string cor, string composicao) : base(modelo, peso, cor, composicao)
        {
        }

        public override int QtdRodas => 4;
        public override void Locomover()
        {
            Console.WriteLine("Andando em 4 rodas...");
        }
    }
    public abstract class Moto : Terrestre
    {
        protected Moto(string modelo, double peso, string cor, string composicao) : base(modelo, peso, cor, composicao)
        {
        }

        public override int QtdRodas => 2;

        public override void Locomover()
        {
            Console.WriteLine("Andando em 2 rodas...");
        }
    }

    public class Z1000RR : Moto
    {
        public override double VelocidadeMaxima => 299;
        public Z1000RR(string cor) : base("Z1000 RR", 200, cor, "Aluminio e Fibra")
        {
        }

    }

    public class Kombi : Carro
    {
        public Kombi(string cor) : base("Kombi", 1500, cor, "Metal")
        {
        }

        public override double VelocidadeMaxima => 54;
    }

    //public abstract class Barco : Aquatico
    //{
    //}
    //public abstract class Jestski : Aquatico
    //{
    //}
    //public abstract class Helicoptero : Aereo
    //{
    //}
    //public abstract class Aviao : Aereo
    //{
    //}
}