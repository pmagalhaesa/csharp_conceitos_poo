using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ContaApplication
{
    class Conta
    {

        private float saldo;
        private Cliente titular;
        private int tipo;
        private string numConta;

        public Conta(float valor, Cliente cliente, int num, string numConta)
        {
            this.saldo = valor;
            this.titular = cliente;
            this.tipo = num;
            this.numConta = numConta;
        }

        public void setSaldo(float valor)
        {
            this.saldo = valor;
        }
        public float getSaldo()
        {
            return this.saldo;
        }

        public void setTitular(Cliente pessoa)
        {
            this.titular = pessoa;
        }
        public Cliente getTitular()
        {
            return this.titular;
        }

      
        public void setTipo(int tipoConta)
        {
            this.tipo = tipoConta;
        }

        public int getTipo()
        {
            return this.tipo;
        }
        public void setNumConta(string numConta)
        {
            this.numConta = numConta;
        }
        public string getNumConta()
        {
            return this.numConta;
        }
        public string getDadosConta()
        {
            return "\n Nome do titular: " + this.titular.getNome() + "\n Tipo da conta: " + this.tipo + "\n Saldo: " + this.saldo + "\n Numero da conta: " + this.numConta;
        }

        public bool sacar(float valorSaque)
        {
            if (valorSaque <= saldo)
            {
                this.saldo = saldo - valorSaque;
                return true;
            }
            return false;

        }

        public void depositar(float valorDeposito)
        {
            this.saldo = saldo + valorDeposito;
        }

        public bool transferir(float valorTransferido, Conta contaDestino)
        {
            if (this.sacar(valorTransferido))
            {
                contaDestino.depositar(valorTransferido);
                return true;
            }
            return false;
        }

        public static string lerArquivo(string caminhoArquivo)
        {
            string linha;
            ArrayList contas = new ArrayList();

            StreamReader reader = new StreamReader(caminhoArquivo);

            while ((linha = reader.ReadLine()) != null)
            {
                int qtdOperacoes;
                string[] conta = linha.Split(';');

                qtdOperacoes = int.Parse(conta[3]);
                string numConta = conta[0];
                string nome = conta[1];
                string cpf = conta[2];

            //    Conta x = new Conta(0, nome, cpf, 1, numConta);

                for (int i = 0; i < qtdOperacoes; i++)
                {

                }



                // contas.Add(x);


            }


            return "";

        }

    }
}
