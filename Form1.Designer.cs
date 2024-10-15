namespace MultiplasJanelas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAdicionar = new Button();
            buttonRemover = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            buttonViewProdutos = new Button();
            buttonViewClientes = new Button();
            buttonViewVendas = new Button();
            buttonViewFornecedores = new Button();
            buttonViewCompras = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.BackColor = Color.Transparent;
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.ForeColor = Color.Blue;
            buttonAdicionar.Location = new Point(12, 104);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(86, 25);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = false;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Cursor = Cursors.Hand;
            buttonRemover.ForeColor = Color.FromArgb(192, 0, 0);
            buttonRemover.Location = new Point(12, 135);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(86, 25);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(12, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 480);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.senai_logo_1__1_;
            pictureBox1.Location = new Point(197, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.Anchor = AnchorStyles.Top;
            buttonViewProdutos.Location = new Point(12, 66);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(86, 32);
            buttonViewProdutos.TabIndex = 4;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.UseVisualStyleBackColor = true;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.Anchor = AnchorStyles.Top;
            buttonViewClientes.Location = new Point(120, 66);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(86, 32);
            buttonViewClientes.TabIndex = 5;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.UseVisualStyleBackColor = true;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.Anchor = AnchorStyles.Top;
            buttonViewVendas.Location = new Point(235, 66);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(86, 32);
            buttonViewVendas.TabIndex = 6;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = true;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.Anchor = AnchorStyles.Top;
            buttonViewFornecedores.Location = new Point(341, 66);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(86, 32);
            buttonViewFornecedores.TabIndex = 7;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = true;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.Anchor = AnchorStyles.Top;
            buttonViewCompras.Location = new Point(454, 66);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(86, 32);
            buttonViewCompras.TabIndex = 8;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = true;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(566, 658);
            Controls.Add(buttonViewCompras);
            Controls.Add(buttonViewFornecedores);
            Controls.Add(buttonViewVendas);
            Controls.Add(buttonViewClientes);
            Controls.Add(buttonViewProdutos);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Button buttonViewProdutos;
        private Button buttonViewClientes;
        private Button buttonViewVendas;
        private Button buttonViewFornecedores;
        private Button buttonViewCompras;
    }
}
