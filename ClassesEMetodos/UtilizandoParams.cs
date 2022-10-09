using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    internal class UtilizandoParams
    {
        public static double Soma(params double[] numeros)
        {
            double resultado = 0;

            foreach(var valor in numeros)
            {
                resultado += valor;
            }

            return resultado;
        }
    }
}
