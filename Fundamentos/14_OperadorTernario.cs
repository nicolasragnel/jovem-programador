using System;
using System.Collections.Generic;
using System.Text;

namespace CodigosCurso.Fundamentos
{
    class OperadorTernario2
    {
        public static void Executar() {
            var nota = 9.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento 
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
