#nullable disable

using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MultiplasJanelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }

        private GradientBackground gradientBackground;

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.Visible = false;

            gradientBackground = new GradientBackground(
                Color.FromArgb(199, 213, 237),
                Color.FromArgb(241, 206, 215),
                0.14f, 0.95f,
                90F
            );

            this.Paint += new PaintEventHandler(Form1_Paint);

            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            gradientBackground.ApplyGradient(e, this.ClientRectangle);
        }

        private void buttonAdicionarProd_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resulta = fcp.ShowDialog();
            if (resulta == DialogResult.OK)
            {
                Produto produto = new Produto
                {
                    Id = produtos.Count == 0 ? 1 : produtos.Max(x => x.Id) + 1,
                    Nome = fcp.nomeProduto,
                    Fabricante = fcp.nomeFabricante,
                    PrecoCompra = fcp.precoCompra,
                    PrecoVenda = fcp.precoVenda
                };

                produtos.Add(produto);
            }
        }

        private void buttonRemoverProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridView1.SelectedRows[0].Index;
                    produtos.RemoveAt(selectedIndex);
                }
                else
                {
                    MessageBox.Show("Nenhum produto selecionado para remoção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Erro ao tentar remover o produto: o índice está fora do intervalo." +
                                "\nDetalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewProdutos_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = produtos; this.dataGridView1.Visible = true; }
        private void buttonViewClientes_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = clientes; this.dataGridView1.Visible = true; }
        private void buttonViewVendas_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = vendas; this.dataGridView1.Visible = true; }
        private void buttonViewFornecedores_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = fornecedores; this.dataGridView1.Visible = true; }
        private void buttonViewCompras_Click(object sender, EventArgs e) { this.dataGridView1.DataSource = compras; this.dataGridView1.Visible = true; }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonAdicionarClient_Click(object sender, EventArgs e)
        {
            FormCriarCliente fcc = new FormCriarCliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente
                {
                    Id = clientes.Count == 0 ? 1 : clientes.Max(x => x.Id) + 1,
                    nome = fcc.Name,
                    endereco = fcc.Endereco,
                    email = fcc.EmailCliente,
                    fone = fcc.TelefoneCliente
                };

                clientes.Add(cliente);
            }
        }

        private void buttonRemoverClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarFornecedores_Click(object sender, EventArgs e)
        {
            FormCriarFornecedor fcc = new FormCriarFornecedor();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    Id = fornecedores.Count == 0 ? 1 : fornecedores.Max(x => x.Id) + 1,
                    nome = fcc.nomeFornecedor,
                    endereco = fcc.Endereco,
                    email = fcc.EmailFornecedor,
                    fone = fcc.TelefoneFornecedor
                };

                fornecedores.Add(fornecedor);
            }
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)HTCAPTION;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void maximize_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            if (fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (produtos.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Produtos antes de efetuar uma compra.");
                return;
            }

            FormCriarCompra fcc = new FormCriarCompra(fornecedores, produtos);
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Compra compra = new Compra();
                if (compras.Count == 0) compra.Id = 1;
                else compra.Id = compras.Max(x => x.Id) + 1;

                compra.IdProduto = fcc.IdProduto;
                compra.IdFornecedor = fcc.IdFornecedor;
                compra.Quantidade = (int)fcc.Quantidade;
                compra.Desconto = fcc.Desconto;
                compra.DataCompra = DateTime.Now;

                compras.Add(compra);
            }
        }

        private void buttonRemoverComp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Visible = false;
        }
    }
}
