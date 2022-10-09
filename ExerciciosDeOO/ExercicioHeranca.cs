using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ExerciciosDeOO
{
    interface INadarEmCardume { }

    // Uma classe abstract não pode ser dado o new, ela pode somente ser herdada.
    public abstract class Animal
    {
        public abstract void Oxigenar();
        public abstract void Locomover();
    }

    public abstract class Peixe : Animal
    {
        public override void Locomover()
        {
            Console.WriteLine("Nadando igual peixe...");
        }

        public override void Oxigenar()
        {
            Console.WriteLine("Respirando enbaixo d'agua...");
        }
    }

    public abstract class Mamifero : Animal
    {
        public override void Oxigenar()
        {
            Console.WriteLine("Respirando normalmente...");
        }

        public void Amamentar()
        {
            Console.WriteLine("Amamentando...");
        }
    }

    public abstract class Ave : Animal
    {
        public void ColocarOvo()
        {
            Console.WriteLine("Colocando ovo...");
        }

        public override void Oxigenar()
        {
            Console.WriteLine("Respirando normalmente...");
        }

        public override void Locomover()
        {
            Console.WriteLine("Voando normalmente...");
        }
    }

    public class Cachorro : Mamifero
    {
        public override void Locomover()
        {
            Console.WriteLine("Andando em 4 patas...");
        }
    }

    public class Homem : Mamifero
    {
        public override void Locomover()
        {
            Console.WriteLine("Andando em 2 pernas...");
        }
    }

    public class Aguia : Ave
    {
    }

    public class BeijaFlor : Ave
    {
        public override void Locomover()
        {
            Console.WriteLine("Voando diferente...");
        }
    }

    public class Tilapia : Peixe, INadarEmCardume
    {
    }
}
