using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class FormCriarCliente : Form
    {
        private GradientBackground gradientBackground;

        public string nomeCliente { get { return this.textBoxNomeCliente.Text; } }
        public string TelefoneCliente { get { return this.textBoxTelefoneCliente.Text; } }
        public string EmailCliente { get { return this.textBoxEmailCliente.Text; } }

        public string Endereco
        {
            get
            {
                string endereco = "";
                endereco += $"{textBoxCompleCliente.Text}, ";
                endereco += $"Nº{textBoxNumCliente.Text}, ";
                endereco += $"{textBoxCidadeCliente.Text} - {textBoxUFCliente.Text}, ";
                endereco += $"CEP: {textBoxCEPCliente.Text} ";
                return endereco;
            }
        }

        public FormCriarCliente()
        {
            InitializeComponent();

            gradientBackground = new GradientBackground(
                Color.FromArgb(199, 213, 237),
                Color.FromArgb(241, 206, 215),
                0.14f, 0.95f,
                90F
            );

            this.Paint += new PaintEventHandler(FormCriarCliente_Paint);
        }

        private void FormCriarCliente_Paint(object sender, PaintEventArgs e)
        {
            gradientBackground.ApplyGradient(e, this.ClientRectangle);
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
