using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodos
{
    public class Escritorio
    {
        private static Impressora _Impressora = null;
        public static Impressora Impressora {
            get {
                if (_Impressora == null)
                {
                    _Impressora = new Impressora();
                }

                return _Impressora;
            }
        }
    }

    public class Impressora
    {
        private bool _Ligada = false;

        private void Ligar()
        {
            Thread.Sleep(2000);
            _Ligada = true;
        }

        public void Imprimir(string text)
        {
            if (!_Ligada)
            {
                Ligar();
            }

            Console.WriteLine(text);
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public Impressora Impressora {
            get {
                return new Impressora();
            }
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }
    }

    public class Calculadoraa
    {
        public double UltimoValor1 { get; set; }
        public double UltimoValor2 { get; set; }

        public static double UltimoValorStatic1 { get; set; }
        public static double UltimoValorStatic2 { get; set; }

        public double Soma(double valor1, double valor2)
        {
            UltimoValor1 = valor1;
            UltimoValor2 = valor2;

            return valor1 + valor2;
        }

        // Dá erro. Por mais que não é ligado a uma instância, ele continua sendo um membro da Classe.
        // Membros com o mesmo Nome (Identificador) e Assinatura não podem coexistir.
        //public static double Soma(double valor1, double valor2)

        public static double SomaStatic(double valor1, double valor2)
        {
            UltimoValorStatic1 = valor1;
            UltimoValorStatic2 = valor2;

            return valor1 + valor2;
        }
    }

    internal class MetodosEstaticos
    {
        public static void ExecutarImpressora()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Eduardo"));
            pessoas.Add(new Pessoa("Michelle"));
            pessoas.Add(new Pessoa("Denis"));
            pessoas.Add(new Pessoa("Thayse"));

            var tempoInicial = DateTime.Now;
            foreach(var pessoa in pessoas)
            {
                pessoa.Impressora.Imprimir(pessoa.Nome);
            }
            var tempoFinal = DateTime.Now;
            Console.WriteLine($"Tempo decorrido: {tempoFinal - tempoInicial}");

            List<Pessoa> pessoas2 = new List<Pessoa>();
            pessoas2.Add(new Pessoa("Eduardo"));
            pessoas2.Add(new Pessoa("Michelle"));
            pessoas2.Add(new Pessoa("Denis"));
            pessoas2.Add(new Pessoa("Thayse"));

            tempoInicial = DateTime.Now;
            foreach(var pessoa in pessoas2)
            {
                Escritorio.Impressora.Imprimir(pessoa.Nome);
            }
            tempoFinal = DateTime.Now;
            Console.WriteLine($"Tempo decorrido (Estático): {tempoFinal - tempoInicial}");
        }

        public static void Executar()
        {
            Calculadoraa calculadoraa = new Calculadoraa();

            Console.WriteLine(calculadoraa.Soma(1, 2));
            // Não é possível utilizar pq o static não é compatível com uma chamada através de uma instância.
            // Console.WriteLine(calculadoraa.SomaStatic(1, 2));

            // Não é possível utilizar o método comum pq ele precisa ser consumido através de uma instância.
            // Console.WriteLine(Calculadoraa.Soma(1, 2));
            Console.WriteLine(Calculadoraa.SomaStatic(1, 2));

            Console.WriteLine(string.Empty);

            calculadoraa = new Calculadoraa();
            Calculadoraa calculadoraa2 = new Calculadoraa();

            Console.WriteLine($"Soma 1: {calculadoraa.Soma(12, 17)}");
            Console.WriteLine($"Soma 2: {calculadoraa2.Soma(36, 35)}");

            Console.WriteLine($"Último valor 1 (Primeira): {calculadoraa.UltimoValor1}");
            Console.WriteLine($"Último valor 2 (Primeira): {calculadoraa.UltimoValor2}");

            Console.WriteLine($"Último valor 1 (Segunda): {calculadoraa2.UltimoValor1}");
            Console.WriteLine($"Último valor 2 (Segunda): {calculadoraa2.UltimoValor2}");

            Console.WriteLine(String.Empty);
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine(String.Empty);

            Console.WriteLine($"Soma 1: {Calculadoraa.SomaStatic(12, 17)}");
            Console.WriteLine($"Último valor 1 (Primeira): {Calculadoraa.UltimoValorStatic1}");
            Console.WriteLine($"Último valor 2 (Primeira): {Calculadoraa.UltimoValorStatic2}");

            Console.WriteLine($"Soma 2: {Calculadoraa.SomaStatic(36, 35)}");
            Console.WriteLine($"Último valor 1 (Primeira): {Calculadoraa.UltimoValorStatic1}");
            Console.WriteLine($"Último valor 2 (Primeira): {Calculadoraa.UltimoValorStatic2}");
        }
    }
}
