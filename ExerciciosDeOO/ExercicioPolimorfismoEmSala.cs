using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ExerciciosDeOO
{
    public class ListSala
    {
        private List<string> _List = new List<string>();

        public int CountAux { get; private set; }

        private int _Count = 0;
        public int Count
        {
            get
            {
                return _Count;
            }
        }

        public void Add(string valor)
        {
            _List.Add(valor);
            _Count++;
        }
    }

    internal abstract class Alimento
    {
        public abstract string Nome { get; }
        string Proteina { get; set; }
        string Gordura { get; set; }
        string Carbo { get; set; }
        string Calorias { get; set; }

        public virtual string ListarAlimento()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"O alimento {Nome} possui as seguintes caracteristicas: ");
            sb.AppendLine($"Gordura: %{Gordura}");
            sb.AppendLine($"Carbo: %{Carbo}");
            sb.AppendLine($"Proteina: %{Proteina}");

            return sb.ToString();
        }
    }
    internal abstract class Doce : Alimento
    {

    }
    internal abstract class Salgado : Alimento
    {

    }
    internal class Brigadeiro : Doce
    {
        public override string Nome => "Brigadeiro";
    }
    internal class Pastel : Salgado
    {
        public override string Nome => "Pastel";

        public override string ListarAlimento()
        {
            var sb = new StringBuilder(base.ListarAlimento());
            sb.AppendLine("Pastel é muito bom!");
            return sb.ToString();
        }
    }



    internal abstract class MeioComunicacao
    {
        public string Mensagem { get; set; }
        public abstract void EntregarMensagem();
    }
    internal abstract class SemFio : MeioComunicacao
    {
        public bool TemSinal { get; set; }
    }
    internal abstract class Fisico : MeioComunicacao
    {
        public string Destino { get; set; }
    }
    internal class Internet : SemFio
    {
        public override void EntregarMensagem()
        {
            Console.WriteLine("Mensagem recebida!");
        }
    }
    internal class Carta : Fisico
    {
        public override void EntregarMensagem()
        {
            Console.WriteLine("O carteiro entregou a carta...");
        }
    }

    public class ExecutarPolimorfismoEmSala
    {
        public static void Executar()
        {
            List<Alimento> alimentos = new List<Alimento>();
            alimentos.Add(new Brigadeiro());
            alimentos.Add(new Brigadeiro());
            alimentos.Add(new Brigadeiro());
            alimentos.Add(new Brigadeiro());

            alimentos.Add(new Pastel());
            alimentos.Add(new Pastel());
            alimentos.Add(new Pastel());

            List<Doce> doces = new List<Doce>();
            List<Salgado> salgados = new List<Salgado>();

            foreach (var alimento in alimentos)
            {
                if (alimento is Salgado)
                {
                    salgados.Add(alimento as Salgado);
                }

                if (alimento is Doce)
                {
                    doces.Add(alimento as Doce);
                }
            }

            Console.WriteLine($"Quantidade de doces armazenados: {doces.Count}.");
            Console.WriteLine("Tipos de doces na lista: ");

            var lDoces = new List<string>();
            foreach (var doce in doces)
            {
                if (lDoces.Contains(doce.Nome))
                {
                    continue;
                }

                lDoces.Add(doce.Nome);
                Console.WriteLine(doce.ListarAlimento());
            }

            Console.WriteLine($"Quantidade de salgados armazenados: {salgados.Count}.");
            Console.WriteLine("Tipos de doces na lista: ");

            var lSalgados = new List<string>();
            foreach (var salgado in salgados.Distinct())
            {
                if (lSalgados.Contains(salgado.Nome))
                {
                    continue;
                }

                lSalgados.Add(salgado.Nome);
                Console.WriteLine(salgado.ListarAlimento());
            }

            List<MeioComunicacao> meios = new List<MeioComunicacao>();
            meios.Add(new Carta());
            meios.Add(new Internet());

            foreach(var meio in meios)
            {
                meio.EntregarMensagem();
            }
        }
    }
}
