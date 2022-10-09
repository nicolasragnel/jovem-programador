using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    enum Genero { Macho, Femea }
    enum NaturezaAlimentar { Carnivoro, Herbivoro, Onivoro }

    class Mamifero
    {
        public string Nome { get; set; }
        public string NomeCientifico { get; set; }

        public string Habitat { get; set; }
        public Genero Genero { get; set; }
        public NaturezaAlimentar Alimentacao { get; set; }

        public Mamifero(string nomeCientifico, string nome, Genero genero)
        {
            NomeCientifico = nomeCientifico;
            Nome = nome;
            Genero = genero;
            // this.Genero = Genero;
        }
    }

    internal class UtilizandoObjetos
    {
        public static void Executar()
        {
            var gato = new Mamifero("Felis catus", "Gato", Genero.Macho);
            gato.Alimentacao = NaturezaAlimentar.Carnivoro;
            gato.Habitat = "Sofá";

            var egua = new Mamifero("Equus caballus", "Cavalo", Genero.Femea);
            egua.Alimentacao = NaturezaAlimentar.Herbivoro;
            egua.Habitat = "Planicie";

            var cao = new Mamifero("Canis lupus familiaris", "Cachorro", Genero.Macho)
            {
                Alimentacao = NaturezaAlimentar.Carnivoro,
                Habitat = "Matas e Florestas"
            };
        }
    }
}
