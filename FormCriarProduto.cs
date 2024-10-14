namespace MultiplasJanelas
{
    public partial class FormCriarProduto : Form
    {
        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.textBoxFabricante.Text; } }
        public decimal precoCompra { get { return this.inputPrecoCompra.Value; } }
        public decimal precoVenda { get { return this.InputPrecoVenda.Value; } }

      

        public FormCriarProduto()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormCriarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
