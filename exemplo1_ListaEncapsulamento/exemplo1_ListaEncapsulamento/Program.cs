using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1_ListaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
                    int tam = 7;
        Lista lista = new Lista(tam);
        lista.elementos[0] = 1;
        lista.qtdaElem++;
        lista.elementos[1] = 2;
        lista.qtdaElem++;
        if (lista.qtdaElem > 0)
        {
        for(int i = 0; i < lista.qtdaElem; i++)
        {
        Console.WriteLine("{0}o elemento: lista[{1}] = {2,10:D8}", (i+1), i, lista.elementos[i]);
        }
        }
        Console.ReadKey();
        }
    }
}
