using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulasCSharp.ColecoesDeDados
{
    internal class UsandoArrayList
    {
        public static void Executar()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(12);
            arrayList.Add("string");
            arrayList.Add(true);
            arrayList.Add(10.5);

            foreach(var item in arrayList)
            {
                Console.WriteLine($"O valor é {item} e ele é do tipo {item.GetType()}");
            }
        }
    }
}
