using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ContadeLuz
{

    public partial class Consumidores : Form
    {
        static string tipoConsumidor = "";
        public Consumidores()
        {
            InitializeComponent();
        }

        public class Cliente
        {
            public string? Cgc { get; set; }
            public string? Nome { get; set; }
            public string? Tipo { get; set; }
            public string? Instalacao { get; set; }
            public Endereco DadosEndereco { get; set; }

            public class Endereco
            {
                public string? Logradouro { get; set; }
                public string? Numero { get; set; }
                public string? Bairro { get; set; }
                public string? Cidade { get; set; }
                public string? Estado { get; set; }
                public string? CEP { get; set; }
            }
        }
        public class GerenciadorDeClientes
        {
            private string caminhoArquivoJson; // Caminho do arquivo JSON para armazenar os dados

            public GerenciadorDeClientes(string caminhoArquivoJson)
            {
                this.caminhoArquivoJson = caminhoArquivoJson;
            }
            public string geraNumInstalacao()
            {
                Random random = new Random();
                int[] chave = new int[10];

                // Gerar cada número da chave
                for (int i = 0; i < 10; i++)
                {
                    chave[i] = random.Next(0, 10); // Gera números aleatórios de 0 a 9
                }

                // Converter array de int para string para formar a chave completa
                string chaveCompleta = string.Join("", chave);
                return chaveCompleta;
            }

            // Método para cadastrar um novo cliente
            public void CadastrarCliente(Cliente cliente)
            {
                try
                {
                    // Verifica se o arquivo JSON existe. Se não, cria um novo arquivo.
                    if (!File.Exists(caminhoArquivoJson))
                    {
                        File.WriteAllText(caminhoArquivoJson, "[]");
                    }

                    List<Cliente> clientes = LerClientesDoArquivo();

                    // Verifica se já existe um cliente com o mesmo CPF/CNPJ
                    if (clientes.Any(c => c.Cgc == cliente.Cgc))
                    {
                        MessageBox.Show(
                            $"Cliente com CPF/CNPJ {cliente.Cgc} já cadastrado",
                            "Cadastro duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }
                    else
                    {
                        // Adiciona o novo cliente à lista existente
                        clientes.Add(cliente);

                        // Serializa a lista atualizada para JSON
                        string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);

                        // Escreve o JSON de volta no arquivo
                        File.WriteAllText(caminhoArquivoJson, json);

                        MessageBox.Show(
                            $"Cliente {cliente.Cgc} - {cliente.Nome} foi salvo!",
                            "Cliente Salvo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }

                   
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately
                    MessageBox.Show(
                        $"Erro ao cadastrar cliente: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            public Cliente ConsultarCliente(string cpfCnpj)
            {
                List<Cliente> clientes = LerClientesDoArquivo();

                Cliente clienteEncontrado = clientes.FirstOrDefault(c => c.Cgc == cpfCnpj);

                return clienteEncontrado;
            }

            // Método para ler os dados de todos os clientes do arquivo JSON
            public List<Cliente> LerClientesDoArquivo()
            {
                try
                {
                    // Verifica se o arquivo JSON existe
                    if (!File.Exists(caminhoArquivoJson))
                    {
                        Console.WriteLine("Arquivo de clientes nao existe");
                        return new List<Cliente>(); // Retorna uma lista vazia se o arquivo não existir
                    }

                    // Lê o conteúdo do arquivo JSON e deserializa para uma lista de clientes
                    string json = File.ReadAllText(caminhoArquivoJson);
                    return JsonConvert.DeserializeObject<List<Cliente>>(json);
                }
                catch (Exception ex)
                {
                    // Registra o erro em um log ou exibe uma mensagem de erro para o usuário
                    Console.WriteLine($"Erro ao ler arquivo de clientes: {ex.Message}");
                    return new List<Cliente>(); // Retorna uma lista vazia em caso de erro
                }
            }
        }

        private bool valida_Nome()
        {
            if (textNome.Text.Trim().Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textCGC.Text.Length == 11)
            {
                radioButton1.Enabled = false;
                radioButton1.Checked = false;
                radioButton2.Enabled = true;
                radioButton2.Checked = true;
                tipoConsumidor = "R";
            }
            else if (textCGC.Text.Length == 14)
            {
                radioButton1.Enabled = true;
                radioButton1.Checked = true;
                radioButton2.Enabled = false;
                radioButton2.Checked = false;
                tipoConsumidor = "C";
            }
            else
            {
                MessageBox.Show(
                    "Informe um valor de CPF ou CNPJ válido!",
                    "CGC Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                textCGC.Focus();
            }
        }

        private void habilitaCampos()
        {
            textNome.Enabled = true;
            textCGC.Enabled = true;
            textLog.Enabled = true;
            textBairro.Enabled = true;
            textNum.Enabled = true;
            textCidade.Enabled = true;
            textCEP.Enabled = true;
            comboUF.Enabled = true;
            btnSalvar.Visible = true;
        }

        private void bloqueia_Campos()
        {
            textNome.Enabled = false;
            textCGC.Enabled = false;
            btnSalvar.Visible = false;
            textLog.Enabled = false;
            textBairro.Enabled = false;
            textNum.Enabled = false;
            textCidade.Enabled = false;
            textCEP.Enabled = false;
            comboUF.Enabled = false;
            radioButton1.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Enabled = false;
            radioButton2.Checked = false;
            textNome.Text = "";
            textCGC.Text = "";
            textLog.Text = "";
            textBairro.Text = "";
            textNum.Text = "";
            textCidade.Text = "";
            textCEP.Text = "";
            comboUF.Text = "";
        }
        private void limpa_Campos()
        {
            textNome.Text = "";
            //textCGC.Text = "";
            textLog.Text = "";
            textBairro.Text = "";
            textNum.Text = "";
            textCidade.Text = "";
            textCEP.Text = "";
            comboUF.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {   
            if (btnPesquisar.Visible == true)
            {
                btnPesquisar.Visible = false;
            }
            limpa_Campos();
            habilitaCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja salvar o cadastro?", "Confirma Cadastro", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if (valida_Nome() == false)
                {
                    MessageBox.Show(
                        "Informe um nome valido!",
                        "Nome Inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    textNome.Focus();
                }
                else
                {
                    string caminhoArquivoJson = "clientes.json";

                    // Cria um gerenciador de clientes
                    GerenciadorDeClientes gerenciador = new GerenciadorDeClientes(caminhoArquivoJson);

                    // Cria um novo cliente
                    Cliente cliente = new Cliente()
                    {
                        Cgc = textCGC.Text,
                        Nome = textNome.Text,
                        Tipo = tipoConsumidor,
                        Instalacao = gerenciador.geraNumInstalacao(),
                        DadosEndereco = new Cliente.Endereco()
                        {
                            Logradouro = textLog.Text,
                            Numero = textNum.Text,
                            Bairro = textBairro.Text,
                            Cidade = textCidade.Text,
                            Estado = comboUF.Text,
                            CEP = textCEP.Text,
                        }
                    };

                    // Cadastra o cliente no arquivo JSON
                    gerenciador.CadastrarCliente(cliente);

                  
                    bloqueia_Campos();
                }
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            limpa_Campos();
            textCGC.Enabled = true;
            btnSalvar.Visible = false;
            btnPesquisar.Visible = true;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string arquivoJson = "clientes.json";

            GerenciadorDeClientes gerenciador = new GerenciadorDeClientes(arquivoJson);

            string cpfCnpj = textCGC.Text;
            Cliente cliente = gerenciador.ConsultarCliente(cpfCnpj);

            if (cliente != null)
            {
                habilitaCampos();
                btnConsultar.Visible = true;
                textNome.Text = cliente.Nome;
                textLog.Text = cliente.DadosEndereco.Logradouro;
                textNum.Text = cliente.DadosEndereco.Numero;
                textBairro.Text = cliente.DadosEndereco.Bairro;
                textCidade.Text = cliente.DadosEndereco.Cidade;
                comboUF.Text = cliente.DadosEndereco.Estado;
                textCEP.Text = cliente.DadosEndereco.CEP;

                textCGC.Enabled = false;
            } else {
                MessageBox.Show(
                    $"Consumidor com CPJ/CNPJ {cpfCnpj} nao encontrado",
                    "Nao Encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
