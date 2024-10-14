
using System.ComponentModel;

namespace MultiplasJanelas
{
    public partial class Form1 : Form
    {
        public BindingList<Produto> produtos {  get; set; }
        public Form1()
        {
            InitializeComponent();
            produtos = new BindingList<Produto>();
            this.dataGridView1.DataSource = produtos;   
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
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

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                produtos.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }
    }
}
