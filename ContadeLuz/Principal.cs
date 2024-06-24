namespace ContadeLuz
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void itemConsumidores_Click(object sender, EventArgs e)
        {
            Consumidores consumidores = new Consumidores();
            consumidores.Show();
        }

        private void itemContas_Click(object sender, EventArgs e)
        {
            Contas contas = new Contas();
            contas.Show();
        }
    }
}
