using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MultiplasJanelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> Produtos { get; set; }
        public BindingList<Cliente> Clientes { get; set; }
        public BindingList<Fornecedor> Fornecedores { get; set; }
        public BindingList<Venda> Vendas { get; set; }
        public BindingList<Compra> Compras { get; set; }

        private GradientBackground _gradientBackground;

        public Form1()
        {
            InitializeComponent();
            InitializeDataBindings();
            InitializeGradientBackground();

        }

        private void InitializeDataBindings()
        {
            Produtos = new BindingList<Produto>();
            Clientes = new BindingList<Cliente>();
            Fornecedores = new BindingList<Fornecedor>();
            Vendas = new BindingList<Venda>();
            Compras = new BindingList<Compra>();
            dataGridView1.Visible = false;
        }

        private void InitializeGradientBackground()
        {
            _gradientBackground = new GradientBackground(
                Color.FromArgb(199, 213, 237),
                Color.FromArgb(241, 206, 215),
                0.14f, 0.95f,
                90F
            );
            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            _gradientBackground.ApplyGradient(e, ClientRectangle);
        }

        private void buttonAdicionarProd_Click(object sender, EventArgs e)
        {
            buttonViewProdutos_Click(sender, e);

            FormCriarProduto fcp = new FormCriarProduto();
            if (fcp.ShowDialog() == DialogResult.OK)
            {
                var produto = new Produto
                {
                    Id = Produtos.Count == 0 ? 1 : Produtos.Max(x => x.Id) + 1,
                    Nome = fcp.nomeProduto,
                    Fabricante = fcp.nomeFabricante,
                    PrecoCompra = fcp.precoCompra,
                    PrecoVenda = fcp.precoVenda
                };
                Produtos.Add(produto);
            }
        }

        private void buttonRemoverProd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Produtos)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonRemoverClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Clientes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Clientes.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonRemoverForn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Fornecedores)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Fornecedores.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonAdicionarCompra_Click(object sender, EventArgs e)
        {
            buttonViewCompras_Click(sender, e);

            if (Fornecedores.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Fornecedores antes de efetuar uma compra.");
                return;
            }

            if (Produtos.Count == 0)
            {
                MessageBox.Show("Você Precisa Cadastrar Produtos antes de efetuar uma compra.");
                return;
            }

            FormCriarCompra fcc = new FormCriarCompra(Fornecedores, Produtos);
            if (fcc.ShowDialog() == DialogResult.OK)
            {
                var compra = new Compra
                {
                    Id = Compras.Count == 0 ? 1 : Compras.Max(x => x.Id) + 1,
                    IdProduto = fcc.IdProduto,
                    IdFornecedor = fcc.IdFornecedor,
                    Quantidade = (int)fcc.Quantidade,
                    Desconto = fcc.Desconto,
                    DataCompra = DateTime.Now
                };
                Compras.Add(compra);
            }
        }

        private void buttonRemoverComp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == Compras)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Compras.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
            }
        }

        private void buttonViewCompras_Click(object sender, EventArgs e) { dataGridView1.DataSource = Compras; dataGridView1.Visible = true; }
        private void buttonViewVendas_Click(object sender, EventArgs e) { dataGridView1.DataSource = Vendas; dataGridView1.Visible = true; }
        private void buttonViewProdutos_Click(object sender, EventArgs e) { dataGridView1.DataSource = Produtos; dataGridView1.Visible = true; }
        private void buttonViewClientes_Click(object sender, EventArgs e) { dataGridView1.DataSource = Clientes; dataGridView1.Visible = true; }
        private void buttonViewFornecedores_Click(object sender, EventArgs e) { dataGridView1.DataSource = Fornecedores; dataGridView1.Visible = true; }


        private void buttonInicio_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click_1(object sender, EventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84) m.Result = (IntPtr)0x2;
        }

        private void buttonAdicionarVendas_Click(object sender, EventArgs e)
        {
            buttonViewVendas_Click(sender, e);
            {
                if (Clientes.Count == 0)
                {
                    MessageBox.Show("Você Precisa Cadastrar Clientes antes de efetuar uma venda.");
                    buttonViewClientes_Click(sender, e);

                    return;
                }

                if (Produtos.Count == 0)
                {
                    buttonViewCompras_Click(sender, e);
                    buttonAdicionarCompra_Click(sender, e);
                    return;
                }

                FormCriarVenda fcv = new FormCriarVenda(Clientes, Produtos);
                var resultado = fcv.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    Venda venda = new Venda();
                    if (Vendas.Count == 0) venda.Id = 1;
                    else venda.Id = Vendas.Max(x => x.Id) + 1;

                    venda.IdProduto = fcv.IdProduto;
                    venda.IdCliente = fcv.IdCliente;
                    venda.Quantidade = (int)fcv.Quantidade;
                    venda.Desconto = fcv.Desconto;
                    venda.DataVenda = DateTime.Now;

                    Vendas.Add(venda);
                }
            }
        }

        private void buttonRemoverVendas_Click(object sender, EventArgs e)
        {
            buttonViewVendas_Click(sender, e);
            if (dataGridView1.DataSource == Vendas)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Vendas.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }

            }
            else
            {
                MessageBox.Show("Nenhuma venda selecionado para remoção.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAdicionarFornecedor_Click_1(object sender, EventArgs e)
        {
            buttonViewFornecedores_Click(sender, e);

            FormCriarFornecedor fcf = new FormCriarFornecedor();
            var resultado = fcf.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (Fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = Fornecedores.Max(x => x.Id) + 1;

                fornecedor.NomeEmpresa = fcf.nomeFornecedor;
                fornecedor.NomeContato = fcf.NomeContFornecedor;
                fornecedor.Endereco = fcf.Endereco;
                fornecedor.Email = fcf.EmailFornecedor;
                fornecedor.Telefone = fcf.TelefoneFornecedor;
                Fornecedores.Add(fornecedor);
            }
        }

        private void buttonAdicionarCliente_Click_1(object sender, EventArgs e)
        {

            FormCriarCliente fcc = new FormCriarCliente();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Cliente cliente = new Cliente();

                if (Clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = Clientes.Max(x => x.Id) + 1;

                cliente.Nome = fcc.nomeCliente;
                cliente.Endereco = fcc.Endereco;
                cliente.Email = fcc.EmailCliente;
                cliente.Fone = fcc.TelefoneCliente;
                Clientes.Add(cliente);
            }
        }
    }
}
