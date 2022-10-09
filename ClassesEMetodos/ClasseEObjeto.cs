using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEMetodos
{
    public class Calculadora
    {
        // Método não estático (static), exige uma instância.
        public int Soma(int a, int b)
        {
            return a + b;
        }

        // Método não estático (static), exige uma instância.
        public int Subtracao(int a, int b)
        {
            return a - b;
        }
    }

    internal class ClasseEObjeto
    {
        public void ExecutarNormal()
        {
            Executar();
        }

        public static void Executar()
        {
            // Dá erro pq o método é estático => Inacessível através da instância.
            //var teste = new ClasseEObjeto();
            //teste.Executar();



            // Clausula new, instancia um objeto.
            // Instância da classe Calculadora => Objeto
            var calculadora = new Calculadora();

            Console.WriteLine(calculadora.Soma(5, 5));
            Console.WriteLine(calculadora.Soma(6, 5));
            Console.WriteLine(calculadora.Soma(508, 23));
            Console.WriteLine(calculadora.Soma(89, 742));

            Console.WriteLine(calculadora.Subtracao(89, 742));
        }
    }
}
