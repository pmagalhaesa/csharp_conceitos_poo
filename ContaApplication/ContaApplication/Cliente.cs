using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaApplication
{
    class Cliente
    {
        private string nome;
        private int idade;
        private string rg;
        private string cpf;
        private string endereco;

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }


        public string getRg()
        {
            return this.rg;
        }

        public void setRg(string rg)
        {
            this.rg = rg;
        }


        public string getCpf()
        {

            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getEnd()
        {
            return this.endereco;
        }

        public void setEnd(string endereco)
        {

            this.endereco = endereco;
        }

        private bool maiorIdade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
          
        }























    }
}
