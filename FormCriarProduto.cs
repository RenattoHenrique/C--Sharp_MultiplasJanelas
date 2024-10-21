using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class FormCriarProduto : Form
    {
        private GradientBackground gradientBackground;

        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.textBoxFabricante.Text; } }
        public decimal precoCompra { get { return this.inputPrecoCompra.Value; } }
        public decimal precoVenda { get { return this.InputPrecoVenda.Value; } }

        public FormCriarProduto()
        {
            InitializeComponent();

            gradientBackground = new GradientBackground(
                Color.FromArgb(199, 213, 237),
                Color.FromArgb(241, 206, 215),
                0.14f, 0.95f,
                90F
            );

            this.Paint += new PaintEventHandler(FormCriarProduto_Paint);

        }

        private void FormCriarProduto_Paint(object sender, PaintEventArgs e)
        {
            gradientBackground.ApplyGradient(e, this.ClientRectangle);
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
    }
}
