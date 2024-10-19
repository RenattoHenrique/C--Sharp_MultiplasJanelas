namespace MultiplasJanelas
{
    public partial class FormCriarFornecedor : Form
    {
        public string nomeFornecedor { get { return this.textBoxNomeFornecedor.Text; } }
        public string CNPJFornecedor { get { return this.textBoxCNPJFornecedor.Text; } }
        public string NomeContFornecedor { get { return this.textBoxNomeContFornecedor.Text; } }
        public string TelefoneFornecedor { get { return this.textBoxTelefoneFornecedor.Text; } }
        public string EmailFornecedor { get { return this.textBoxEmailFornecedor.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"({textBoxCompleFornecedor.Text}), ";
                endereco += $"({textBoxNumFornecedor}), ";
                endereco += $"({textBoxCompleFornecedor.Text}), ";
                endereco += $"({textBoxCidadeFornecedor} - {textBoxUFFornecedor}), ";
                endereco += $"CEP: ({textBoxCEPFornecedor}), ";
                return endereco;
            }
        }

        public FormCriarFornecedor()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
