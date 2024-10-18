using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplasJanelas
{
    public partial class FormCriarCompra : Form
    {
        public FormCriarCompra(BindingList<Fornecedor> fornecedores, BindingList<Produto> produtos)
        {
            InitializeComponent();
            Fornecedores = fornecedores;
            comboBoxFornecedor.DataSource = Fornecedores;
            comboBoxFornecedor.ValueMember = "Id";
            comboBoxFornecedor.DisplayMember = "NomeEmpresa";

            Produtos = produtos;
            comboBoxProduto.DataSource = Produtos;
            comboBoxProduto.ValueMember = "Id";
            comboBoxProduto.DisplayMember = "Nome";
        }

        public BindingList<Produto> Produtos { get; }
        public BindingList<Fornecedor> Fornecedores { get; }
    }
}
