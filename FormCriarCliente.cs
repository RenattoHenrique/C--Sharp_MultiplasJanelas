namespace MultiplasJanelas
{
    public partial class FormCriarCliente : Form
    {
        public string nomeCliente { get { return this.textBoxNomeCliente.Text; } }
        public string TelefoneCliente { get { return this.textBoxTelefoneCliente.Text; } }
        public string EmailCliente { get { return this.textBoxEmailCliente.Text; } }

        public string Endereco
        {
            get {
                string endereco = "";
                endereco += $"({textBoxCompleCliente.Text}), ";
                endereco += $"({textBoxNumCliente}), ";
                endereco += $"({textBoxCompleCliente.Text}), ";
                endereco += $"({textBoxCidadeCliente} - {textBoxUFCliente}), ";
                endereco += $"CEP: ({textBoxCEPCliente}), ";
                return endereco;
            }
        }
        public FormCriarCliente()
        {
            InitializeComponent();
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
