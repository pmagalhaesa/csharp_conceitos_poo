using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2_ListaEncapsulamento
{
    class Lista
    {
        private int qtdAdd = 0;
        private int[] elementos;
        //quantidade de elementos da lista
        private int qtdaElem;
        public Lista(int tamLista)
        {
            elementos = new int[tamLista];          
            qtdaElem = 0;
        }
        public int getQtdaElem()
        {
            return qtdaElem;
        }
        //Adiciona um elemento na lista
        public void add(int elem)
        {
            if (qtdAdd < elementos.Length) { 
                elementos[qtdaElem] = elem;
                qtdaElem++;
            }
            qtdAdd++;
        }
        public int getElemento(int i)
        {
            if (i > elementos.Length)
            {
                Console.Write("Posição vetor não existe!");
                return -1;
            }
            return elementos[i];
        }
        public void imprimeLista()
        {
            if (this.qtdaElem > 0)
            {
                for (int i = 0; i < this.qtdaElem; i++)
                {
                    Console.WriteLine("{0}o elemento: lista[{1}] = {2,10:D8}", (i + 1), i, this.getElemento(i));
                }
            }

        }


    }

}
