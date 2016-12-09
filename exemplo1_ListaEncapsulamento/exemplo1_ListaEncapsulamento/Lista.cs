using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo1_ListaEncapsulamento
{
    class Lista
    {
        public int[] elementos;
        public int qtdaElem; //quantidade de elementos da lista
        public Lista(int tamLista)
        {
            elementos = new int[tamLista];
            qtdaElem = 0;
        }
    }
}
