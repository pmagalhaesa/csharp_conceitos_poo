using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContaApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSaldo formulario = new FormularioSaldo(txtConta.Text);
            formulario.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioCliente formulario = new FormularioCliente();
            formulario.Show();
        }

        private void mnGeral_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioSaque formulario = new FormularioSaque(txtConta.Text);
            formulario.ShowDialog();
        }

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioDeposito formulario = new FormularioDeposito(txtConta.Text);
            formulario.ShowDialog();
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormularioTransferencia formulario = new FormularioTransferencia(txtConta.Text);
            formulario.ShowDialog();
        }
        static void lerContas(Conta[] vetContas, string nomeArquivo)
        {
            //verifica se o arquivo existe
            if (File.Exists(nomeArquivo))
            {
                StreamReader arq = new StreamReader(nomeArquivo);
                string linha;
                string[] partesLinha;
                int contContas = 0;
                int qtOperacoes = 0;
                int tamVetLinha = 0;

                Conta conta;

                /* partesLinha: array composto pelos campos do arquivo
                 * partesLinha[0] - num da conta
                 * parteslinha[1] - titular
                 * parteslinha[2] - cpf
                 * parteslinha[3] - qtda de operacoes
                 * parteslinha[4]  a parteslinha[n-1] -  operacoes:
                 *   D:deposito
                 *   S:saque
                 *   T:transferencia
                 */

                //verifica fim de arquivo
                while (!arq.EndOfStream)
                {
                    linha = arq.ReadLine();
                    //divide a linha em várias strings, tendo como base o ';' e coloca no array partesLinha
                    partesLinha = linha.Split(';');

                    //cria uma conta com parâmetros: num conta, titular, saldo, cpf
                    string numConta = partesLinha[0];
                    string nome = partesLinha[1];
                    string cpf = partesLinha[2];
                    Cliente cli = new Cliente();
                    //    Conta x = new Conta(0, nome, cpf, 1, numConta);
                    cli.setCpf(cpf);
                    cli.setNome(nome);
                    conta = new Conta(0, cli, 1, numConta);
                    vetContas[contContas] = conta;

                    //tamanho do vetor partesLinha
                    tamVetLinha = partesLinha.Length;

                    //obtem a quantidade de operacoes
                    qtOperacoes = int.Parse(partesLinha[3]);

                    //Uma forma de limitar o for para caminhar no vetor linha:
                    //Pq i inicia em 4? Desse índice em diante, são apresentadas as operações
                    //qtOperacoes + 4: corresponde ao tamanho do vetor partesLinha criado automaticamente com split
                    // 4 é a qtda de campos anteriores as operacoes. A esse valor soma-se a qtda de operações especificada
                    //para obter o tamanho do vetor.  
                    //for (int i = 4; i < qtOperacoes + 4; i++)

                    for (int i = 4; i < tamVetLinha; i++)
                    {
                        //ler o primeiro caractere da string correspondente à operacao+valor
                        //Ex: D200,00 - isso é igual a D=deposito de R$200,00
                        char tipoOp = partesLinha[i][0];
                        //Obtém a substring a partir do índice 1 até o final
                        double valor = Double.Parse(partesLinha[i].Substring(1));
                        //para saber mais:
                        //https://msdn.microsoft.com/en-us/library/system.string.substring(v=vs.110).aspx

                        /*if (tipoOp == 'D')
                            vetContas[contContas].deposito(valor);
                        else
                            vetContas[contContas].saque(valor);*/
                    }
                    contContas++;
                }
                arq.Close();
            }
            else
                Console.WriteLine("Arquivo não existe");
        }

        private void importarArquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
