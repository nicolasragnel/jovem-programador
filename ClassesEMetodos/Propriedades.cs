using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodos
{
    public enum TipoConta { Corrente, Poupanca, Salario }
    public class ContaBancaria
    {
        // Field da class... Geralmente não são públicos.
        // public string Numero;
        public string Numero { get; set; } = string.Empty;
        public TipoConta Tipo { get; set; }

        private double _SaldoConta = 0;
        public double SaldoConta {
            get {
                return _SaldoConta;
            }
        }

        // Lambda
        // get { return CalcularMensalidade(); }
        public double ValorMensalidade { get => CalcularMensalidade(); }

        public ContaBancaria(string numero, TipoConta tipo)
        {
            Numero = numero;
            Tipo = tipo;
            _SaldoConta = BuscarValorEmContaNaBaseDeDados();
        }

        public string PegarExtrato()
        {
            var sb = new StringBuilder();

            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine("=-=-  EXTRATO DA CONTA  -=-=");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            sb.AppendLine($"Número: {Numero}");
            sb.AppendLine($"Tipo: {Tipo}");
            sb.AppendLine($"Saldo: {SaldoConta}");
            sb.AppendLine($"Mensalidade: {ValorMensalidade}");
            sb.AppendLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

            return sb.ToString();
        }

        private double BuscarValorEmContaNaBaseDeDados()
        {
            var random = new Random();
            return (double)random.NextDouble();
        }

        private double CalcularMensalidade()
        {
            var random = new Random();
            double valorMensalidade = random.Next(8, 20);

            switch (Tipo)
            {
                case TipoConta.Corrente:
                    valorMensalidade *= 1.40;
                    break;
                case TipoConta.Poupanca:
                    valorMensalidade *= 0.60;
                    break;
                case TipoConta.Salario:
                    valorMensalidade = 0;
                    break;
            }

            return valorMensalidade;
        }
    }

    internal class Propriedades
    {
        public static void Executar()
        {
            var conta1 = new ContaBancaria("896547-5", TipoConta.Corrente);
            var conta2 = new ContaBancaria("948126-2", TipoConta.Salario);
            var conta3 = new ContaBancaria("268561-7", TipoConta.Poupanca);

            Console.WriteLine(conta1.PegarExtrato());
            Console.WriteLine(conta2.PegarExtrato());
            Console.WriteLine(conta3.PegarExtrato());
        }
    }
}
