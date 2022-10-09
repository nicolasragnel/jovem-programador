using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ClassesEMetodos
{
    internal class ParametrosOutERef
    {
        public static bool TryParce(string valor, out double valorTraduzido)
        {
            var resultado = true;
            valorTraduzido = 0;

            try
            {
                valorTraduzido = double.Parse(valor);
            }
            // ele pega toda e qualquer exception
            catch
            {
                resultado = false;
                // return false;
            }

            return resultado;
        }

        //                                 Marco               MARCO 
        public static void Executar(string entrada, out string saida) {
            saida = entrada.ToUpper();
        }

        public static void ExecutarDiferente(ref string entrada)
        {
            entrada = entrada.ToUpper();
        }
    }
}
