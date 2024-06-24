using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using static ContadeLuz.Consumidores;

namespace ContadeLuz
{
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }

        public class Conta
        {
            public string? Cgc { get; set; }
            public string? Tipo { get; set; }
            public Instalacao DadosInstalacao { get; set; }

            public class Instalacao
            {
                public string? Numero { get; set; }
                public Valor DadosConta { get; set; }

                public class Valor
                {
                    public string? Mesref { get; set; }
                    public string? Leitura { get; set; }
                }
            }
        }

        public class GerenciadorDeContas
        {
            private string caminhoArquivoJson;
            private List<Conta> contas;

            public GerenciadorDeContas(string caminhoArquivoJson)
            {
                this.caminhoArquivoJson = caminhoArquivoJson;
            }

            public void CadastrarConta(Conta conta)
            {
                try
                {
                    if (!File.Exists(caminhoArquivoJson))
                    {
                        File.WriteAllText(caminhoArquivoJson, "[]");
                    }

                    List<Conta> contas = LerContasDoArquivo() ?? new List<Conta>();

                    bool contaExiste = contas.Any(c =>
                        c.Cgc == conta.Cgc &&
                        c.DadosInstalacao.Numero == conta.DadosInstalacao.Numero &&
                        c.DadosInstalacao.DadosConta.Mesref == conta.DadosInstalacao.DadosConta.Mesref
                    );

                    if (contaExiste)
                    {
                        MessageBox.Show(
                            $"Cliente com CPF/CNPJ: {conta.Cgc}, Instalação: {conta.DadosInstalacao.Numero} no Período: {conta.DadosInstalacao.DadosConta.Mesref} já cadastrado.",
                            "Cadastro duplicado",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return;
                    }

                    contas.Add(conta);
                    string novoJson = JsonConvert.SerializeObject(contas, Formatting.Indented);
                    File.WriteAllText(caminhoArquivoJson, novoJson);

                    MessageBox.Show(
                        "Conta cadastrada com sucesso!",
                        "Cadastro OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Erro ao cadastrar cliente: {ex.Message}",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            public List<Conta> LerContasDoArquivo()
            {
                try
                {
                    if (!File.Exists(caminhoArquivoJson))
                    {
                        Console.WriteLine("Arquivo de contas nao existe");
                        return new List<Conta>();
                    }

                    string json = File.ReadAllText(caminhoArquivoJson);
                    return JsonConvert.DeserializeObject<List<Conta>>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao ler arquivo de contas: {ex.Message}");
                    return new List<Conta>();
                }
            }

            public double ConsultarConsumoUltimoMes(string cpfCnpj, string numeroInstalacao)
            {
                List<Conta> contas = LerContasDoArquivo();
                var conta = contas
                    .Where(c => c.Cgc == cpfCnpj && c.DadosInstalacao.Numero == numeroInstalacao)
                    .OrderByDescending(c => DateTime.ParseExact(c.DadosInstalacao.DadosConta.Mesref, "MM-yyyy", null))
                    .FirstOrDefault();

                return conta != null && double.TryParse(conta.DadosInstalacao.DadosConta.Leitura, out double leitura) ? leitura : 0;
            }

            public Conta ConsultarConta(string cpfCnpj)
            {
                List<Conta> contas = LerContasDoArquivo();

                Conta contaEncontrada = contas.FirstOrDefault(c => c.Cgc == cpfCnpj);

                return contaEncontrada;
            }

            public double ConsultarValorTotalContaUltimoMes(string cpfCnpj, string numeroInstalacao)
            {
                double consumo = ConsultarConsumoUltimoMes(cpfCnpj, numeroInstalacao);
                if (consumo == 0) return 0;

                List<Conta> contas = LerContasDoArquivo();
                var conta = contas
                    .Where(c => c.Cgc == cpfCnpj && c.DadosInstalacao.Numero == numeroInstalacao)
                    .OrderByDescending(c => DateTime.ParseExact(c.DadosInstalacao.DadosConta.Mesref, "MM-yyyy", null))
                    .FirstOrDefault();

                if (conta == null) return 0;

                double tarifa = conta.Tipo == "Residencial" ? 0.40 : 0.35;
                double valorConsumo = consumo * tarifa;
                double contribuicao = 9.25;
                double imposto = conta.Tipo == "Residencial" ? 0.30 : 0.18;

                double valorTotal = valorConsumo + contribuicao;
                double valorComImposto = valorTotal * (1 + imposto);

                return valorComImposto;
            }

            public double ConsultarValorContaSemImpostos(string cpfCnpj, string numeroInstalacao)
            {
                double consumo = ConsultarConsumoUltimoMes(cpfCnpj, numeroInstalacao);
                if (consumo == 0) return 0;

                List<Conta> contas = LerContasDoArquivo();
                var conta = contas
                    .Where(c => c.Cgc == cpfCnpj && c.DadosInstalacao.Numero == numeroInstalacao)
                    .OrderByDescending(c => DateTime.ParseExact(c.DadosInstalacao.DadosConta.Mesref, "MM-yyyy", null))
                    .FirstOrDefault();

                if (conta == null) return 0;

                double tarifa = conta.Tipo == "R" ? 0.40 : 0.35;
                double valorConsumo = consumo * tarifa;
                double contribuicao = 9.25;

                double valorSemImposto = valorConsumo + contribuicao;

                return valorSemImposto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string clienteJson = "clientes.json";
            string contasJson = "contas.json";

            GerenciadorDeClientes gerenciador = new GerenciadorDeClientes(clienteJson);
            GerenciadorDeContas geConta = new GerenciadorDeContas(contasJson);

            string cpfCnpj = txtCpfCnpj.Text;


            Cliente cliente = gerenciador.ConsultarCliente(cpfCnpj);

            if (cliente != null)
            {
                lblNome.Text = cliente.Nome;
                lblTipo.Text = cliente.Tipo == "R" ? "Residencial" : "Comercial";
                lblLog.Text = cliente.DadosEndereco.Logradouro;
                lblNumero.Text = cliente.DadosEndereco.Numero;
                lblBairro.Text = cliente.DadosEndereco.Bairro;
                lblCidade.Text = cliente.DadosEndereco.Cidade;
                lblUF.Text = cliente.DadosEndereco.Estado;
                lblCEP.Text = cliente.DadosEndereco.CEP;

                lblInstalacao.Text = cliente.Instalacao;
                lblCGC.Text = cliente.Cgc;

                btnCadConta.Enabled = true;

                Conta conta = geConta.ConsultarConta(cpfCnpj);
                if (conta != null)
                {
                    var contaMaisRecente = geConta.LerContasDoArquivo()
                        .Where(c => c.Cgc == cpfCnpj)
                        .OrderByDescending(c => DateTime.ParseExact(c.DadosInstalacao.DadosConta.Mesref, "MM-yyyy", null))
                        .FirstOrDefault();

                    if (contaMaisRecente != null)
                    {
                        txtMesRef.Text = contaMaisRecente.DadosInstalacao.DadosConta.Mesref;
                    }
                   
                }
                else
                {
                    MessageBox.Show(
                        $"Consumidor com CPJ/CNPJ {cpfCnpj} não possui contas cadastradas",
                        "Não Encontrado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }



                double consumoUltimoMes = geConta.ConsultarConsumoUltimoMes(cpfCnpj, cliente.Instalacao);
                double valorTotalUltimoMes = geConta.ConsultarValorTotalContaUltimoMes(cpfCnpj, cliente.Instalacao);
                double valorSemImpostoUltimoMes = geConta.ConsultarValorContaSemImpostos(cpfCnpj, cliente.Instalacao);

                txtConsumoUltimoMes.Text = consumoUltimoMes.ToString();
                txtValorUltimoMes.Text = valorTotalUltimoMes.ToString("C");
                txtValorSemImpostoUltimoMes.Text = valorSemImpostoUltimoMes.ToString("C");

            }
            else
            {
                MessageBox.Show(
                    $"Consumidor com CPJ/CNPJ {cpfCnpj} nao encontrado",
                    "Nao Encontrado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                lblNome.Text = "";
                lblTipo.Text = "";
                lblLog.Text = "";
                lblNumero.Text = "";
                lblBairro.Text = "";
                lblCidade.Text = "";
                lblUF.Text = "";
                lblCEP.Text = "";
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnCadConta_Click(object sender, EventArgs e)
        {
            CadContas cadContas = new CadContas(lblNome.Text, lblCGC.Text, lblTipo.Text, lblInstalacao.Text);
            cadContas.Show();
        }

        // Outros métodos...
    }
}
