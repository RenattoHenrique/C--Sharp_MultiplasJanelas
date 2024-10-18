using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class Form1 : Form
    {

        public BindingList<Produto> produtos { get; set; }
        public BindingList<Cliente> clientes { get; set; }
        public BindingList<Fornecedor> fornecedores { get; set; }
        public BindingList<Venda> vendas { get; set; }
        public BindingList<Compra> compras { get; set; }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            clientes = new BindingList<Cliente>();
            fornecedores = new BindingList<Fornecedor>();
            vendas = new BindingList<Venda>();
            compras = new BindingList<Compra>();
            this.dataGridView1.Visible = false;



            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30)); // Define a região com cantos arredondados
        }

        private void buttonAdicionarProd_Click(object sender, EventArgs e)
        {
            FormCriarProduto fcp = new FormCriarProduto();
            var resulta = fcp.ShowDialog();
            if (resulta == DialogResult.OK)
            {
                Produto produto = new Produto();
                if (produtos.Count == 0) produto.Id = 1;
                else produto.Id = produtos.Max(x => x.Id) + 1;
                produto.Nome = fcp.nomeProduto;
                produto.Fabricante = fcp.nomeFabricante;
                produto.PrecoCompra = fcp.precoCompra;
                produto.PrecoVenda = fcp.precoVenda;

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
                Cliente cliente = new Cliente();

                if (clientes.Count == 0) cliente.Id = 1;
                else cliente.Id = clientes.Max(x => x.Id) + 1;

                cliente.nome = fcc.Name;
                cliente.endereco = fcc.Endereco;
                cliente.email = fcc.EmailCliente;
                cliente.fone = fcc.TelefoneCliente;

                clientes.Add(cliente);
            }
        }

        private void buttonRemoverClient_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonAdicionarFornecedores_Click(object sender, EventArgs e)
        {
            FormCriarFornecedor fcc = new FormCriarFornecedor();
            var resultado = fcc.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Fornecedor fornecedor = new Fornecedor();

                if (fornecedores.Count == 0) fornecedor.Id = 1;
                else fornecedor.Id = fornecedores.Max(x => x.Id) + 1;

                fornecedor.nome = fcc.nomeFornecedor;
                fornecedor.endereco = fcc.Endereco;
                fornecedor.email = fcc.EmailFornecedor;
                fornecedor.fone = fcc.TelefoneFornecedor;

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

    }
}
