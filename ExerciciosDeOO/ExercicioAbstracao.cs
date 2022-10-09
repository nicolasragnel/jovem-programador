using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ExerciciosDeOO
{
    public class Cor
    {
        string Nome;
    }

    public class Pokebola {
        string Diametro { get; set; }
        string Peso { get; set; }
        string Composicao { get; set; }
        List<Cor> Cores { get; set; }
    }

    public class Multimetro
    {
        string Dimencoes;
        string Peso;
        string Cor;
        string marca;
        string modelo;
        string CodigoDeBarra;

        void MedirTensao() { }
        void MedirCorrente() { }
        void MedirResistencia() { }
        void TestarTransistor() { }
    }
}
