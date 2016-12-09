using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2_ListaEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
                        int tam = 7;
            int qtda = 0;
            Lista lista = new Lista(tam);
            lista.add(1);
            lista.add(2);
            lista.add(2);
            lista.add(2);
            lista.add(2);
            lista.add(2);
            lista.add(2);
            lista.add(2);
            qtda = lista.getQtdaElem();
            if (qtda > 0)
            {
            for (int i = 0; i < qtda; i++)
            {
            Console.WriteLine("{0}o elemento: lista[{1}] = {2,10:D8}", (i + 1), i, lista.getElemento(i));
            }
            }
            Console.ReadKey();
        }
    }
}
