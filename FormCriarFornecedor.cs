using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class FormCriarFornecedor : Form
    {
        private GradientBackground gradientBackground;

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
                endereco += $"{textBoxCompleFornecedor.Text}, ";
                endereco += $"Nº{textBoxNumFornecedor.Text}, ";
                endereco += $"{textBoxCompleFornecedor.Text}, ";
                endereco += $"{textBoxCidadeFornecedor.Text} - {textBoxUFFornecedor.Text}, ";
                endereco += $"CEP: {textBoxCEPFornecedor.Text} ";
                return endereco;
            }
        }

        public FormCriarFornecedor()
        {
            InitializeComponent();

            gradientBackground = new GradientBackground(
                Color.FromArgb(199, 213, 237),
                Color.FromArgb(241, 206, 215),
                0.14f, 0.95f,
                90F
            );

            this.Paint += new PaintEventHandler(FormCriarFornecedor_Paint);
        }

        private void FormCriarFornecedor_Paint(object sender, PaintEventArgs e)
        {
            gradientBackground.ApplyGradient(e, this.ClientRectangle);
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
