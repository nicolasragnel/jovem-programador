using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    enum DiaSemana { 
        Domingo = 1,
        Segunda = 2,
        Terça = 3,
        Quarta = 4,
        Quinta = 5,
        Sexta = 6,
        Sabado = 7,
    }

    enum MesAno
    {
        Janeiro,
        Fevereiro,
        Março,
        Abril,
        Maio,
        Junho,
        Julho,
        Agosto,
        Setembro,
        Outubro,
        Novembro,
        Dezembro
    }

    internal class Enumeradores
    {
        public static void Executar(int diaSemana)
        {
            // diaSemana.GetHashCode() > Traz o identificador numérico do Enumerador.
            // Console.WriteLine($"O código do dia da semana '{diaSemana.ToString()} é '{diaSemana.GetHashCode()}'.'");


            //var ehSexta = DiaSemana.Sexta.ToString() == "Sexta";

            var valor = (DiaSemana)diaSemana;
            string valorString;

            switch (valor)
            {
                case DiaSemana.Domingo:
                    valorString = DiaSemana.Domingo.ToString();
                    break;
                case DiaSemana.Segunda:
                    valorString = DiaSemana.Segunda.ToString();
                    break;
                case DiaSemana.Terça:
                    valorString = DiaSemana.Terça.ToString();
                    break;
                case DiaSemana.Quarta:
                    valorString = DiaSemana.Quarta.ToString();
                    break;
                case DiaSemana.Quinta:
                    valorString = DiaSemana.Quinta.ToString();
                    break;
                case DiaSemana.Sexta:
                    valorString = DiaSemana.Sexta.ToString();
                    break;
                case DiaSemana.Sabado:
                    valorString = DiaSemana.Sabado.ToString();
                    break;
                default:
                    valorString = "Vish... Nem sei";
                    break;
            }

            Console.WriteLine($"Hoje é {valorString}");
        }
    }
}
