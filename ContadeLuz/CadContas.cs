using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ContadeLuz.Consumidores;
using static ContadeLuz.Contas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ContadeLuz
{
    public partial class CadContas : Form
    {
        public string cgc;
        public string tipo;
        public CadContas(string Nome, string Cgc, string Tipo, string Instalacao)
        {
            InitializeComponent();
            label1.Text = Nome;
            label2.Text = Instalacao;
            cgc = Cgc;
            tipo = Tipo;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void limpaCadastro()
        {
            numMesRef.Value = 1;
            txtLeitura.Text = "";
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            string caminhoArquivoJson = "contas.json";

            // Cria um gerenciador de contas
            GerenciadorDeContas gerenciador = new GerenciadorDeContas(caminhoArquivoJson);

            if (txtLeitura.Text.Trim().Length == 0) {
                MessageBox.Show
                    ("Valor de Leitura nao foi informado",
                    "Informe a leitura",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtLeitura.Focus();
                return;
            }

            // Cria uma nova conta
            Conta conta = new Conta()
            {
                Cgc = cgc,
                Tipo = tipo,
                DadosInstalacao = new Conta.Instalacao()
                {
                    Numero = label2.Text,
                    DadosConta = new Conta.Instalacao.Valor()
                    {
                        Mesref = numMesRef.Value.ToString().Length == 1
                        ? "0" + numMesRef.Value.ToString() + "-" + DateTime.Now.ToString("yyyy")
                        : numMesRef.Value.ToString() + "-" + DateTime.Now.ToString("yyyy"),
                        Leitura = txtLeitura.Text,
                    }
                }
            };

            gerenciador.CadastrarConta(conta);

            
            limpaCadastro();
            this.Close();
        }
    }
}
