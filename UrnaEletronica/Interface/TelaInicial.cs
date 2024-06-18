namespace Interface
{
    public partial class TelaInicial : Form
    {
        private TelaInicial formTelaPrincipal;
        private Gerenciamento formGerenciamento;
        private UrnaExecutivo formUrnaExecutivo;
        private UrnaLegislativo formUrnaLegislativo;
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            formUrnaLegislativo = new UrnaLegislativo();
            formUrnaLegislativo.FormClosed += LegisForm_FormClosed;
            formUrnaLegislativo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formGerenciamento = new Gerenciamento();
            formGerenciamento.FormClosed += (object? sender, FormClosedEventArgs e) => { formGerenciamento.Dispose(); this.Show(); };
            formGerenciamento.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formUrnaExecutivo = new UrnaExecutivo();
            formUrnaExecutivo.FormClosed += ExecForm_FormClosed;
            formUrnaExecutivo.Show();
            this.Hide();
        }

        private void ExecForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUrnaExecutivo.Dispose();
            this.Show();
        }

        private void LegisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUrnaLegislativo.Dispose();
            this.Show();
        }
    }
}