using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    public struct Alimento
    {
        public double Proteina { get; set; }
        public double Carboidrato { get; set; }
        public double Gordura { get; set; }

        public Alimento(double proteina, double carboidrato, double gordura)
        {
            Proteina = proteina;
            Carboidrato = carboidrato;
            Gordura = gordura;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Propriedades do alimento");
            sb.AppendLine($"Proteina: {Proteina}g");
            sb.AppendLine($"Carboidratos: {Carboidrato}g");
            sb.AppendLine($"Gordura: {Gordura}g");

            return sb.ToString();
        }
    }

    public class AlimentoClass
    {
        public double Proteina { get; set; }
        public double Carboidrato { get; set; }
        public double Gordura { get; set; }

        public AlimentoClass(double proteina, double carboidrato, double gordura)
        {
            Proteina = proteina;
            Carboidrato = carboidrato;
            Gordura = gordura;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Propriedades do alimento");
            sb.AppendLine($"Proteina: {Proteina}g");
            sb.AppendLine($"Carboidratos: {Carboidrato}g");
            sb.AppendLine($"Gordura: {Gordura}g");

            return sb.ToString();
        }
    }

    internal class ExemploStruct
    {
        public static void Executar()
        {
            var alimento1 = new Alimento(20, 20, 20);
            var alimento2 = alimento1;

            var alimento3 = new AlimentoClass(20, 20, 20);
            var alimento4 = alimento3;

            Console.WriteLine($"Alimento1: {alimento1.ToString()}");
            Console.WriteLine($"Alimento2: {alimento2.ToString()}");
            Console.WriteLine($"Alimento3: {alimento3.ToString()}");
            Console.WriteLine($"Alimento4: {alimento4.ToString()}");

            alimento2.Proteina = 30;
            alimento4.Proteina = 30;

            Console.WriteLine($"Alimento1: {alimento1.ToString()}");
            Console.WriteLine($"Alimento2: {alimento2.ToString()}");
            Console.WriteLine($"Alimento3: {alimento3.ToString()}");
            Console.WriteLine($"Alimento4: {alimento4.ToString()}");
        }
    }
}
