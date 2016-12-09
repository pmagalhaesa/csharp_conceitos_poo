using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaApplication
{
    static class Helper
    {
        static int posicao;
        static Conta[] vetContas;

        static Helper()
        {
            posicao = 0;
            vetContas = new Conta[999999999];
        }

        public static int getPosicao()
        {
            return posicao;
        }

        public static void setPosicao(int posicao2)
        {
            posicao = posicao2;
        }

        public static Conta[] getContas()
        {
            return vetContas;
        }

        public static void addConta(Conta conta)
        {
            vetContas[posicao] = conta;
        }

        public static Conta getConta(string numConta)
        {
            Conta conta = null;
            for (int i = 0; i < vetContas.Length; i++)
            {
                if (vetContas[i].getNumConta() == numConta)
                {
                    return vetContas[i];
                }
            }
            return conta;
        }

    }
}
