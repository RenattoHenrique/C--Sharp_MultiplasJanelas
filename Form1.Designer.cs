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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            buttonAdicionarProd = new Button();
            buttonRemoverProd = new Button();
            dataGridView1 = new DataGridView();
            buttonViewProdutos = new Button();
            buttonViewClientes = new Button();
            buttonViewVendas = new Button();
            buttonViewFornecedores = new Button();
            buttonViewCompras = new Button();
            panel1 = new Panel();
            buttonInicio = new Button();
            button7 = new Button();
            buttonAdicionarFornecedores = new Button();
            buttonRemoverClient = new Button();
            buttonRemoverComp = new Button();
            buttonAdicionarCompra = new Button();
            buttonAdicionarClient = new Button();
            button1 = new Button();
            button2 = new Button();
            fechar = new PictureBox();
            minimize = new PictureBox();
            maximize = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionarProd
            // 
            buttonAdicionarProd.BackColor = Color.Transparent;
            buttonAdicionarProd.Cursor = Cursors.Hand;
            buttonAdicionarProd.FlatAppearance.BorderSize = 0;
            buttonAdicionarProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonAdicionarProd.FlatStyle = FlatStyle.Flat;
            buttonAdicionarProd.ForeColor = Color.White;
            buttonAdicionarProd.Location = new Point(0, 363);
            buttonAdicionarProd.Name = "buttonAdicionarProd";
            buttonAdicionarProd.Size = new Size(182, 25);
            buttonAdicionarProd.TabIndex = 0;
            buttonAdicionarProd.Text = "Adicionar Produtos";
            buttonAdicionarProd.UseVisualStyleBackColor = false;
            buttonAdicionarProd.Click += buttonAdicionarProd_Click;
            // 
            // buttonRemoverProd
            // 
            buttonRemoverProd.BackColor = Color.Transparent;
            buttonRemoverProd.Cursor = Cursors.Hand;
            buttonRemoverProd.FlatAppearance.BorderSize = 0;
            buttonRemoverProd.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonRemoverProd.FlatStyle = FlatStyle.Flat;
            buttonRemoverProd.ForeColor = Color.White;
            buttonRemoverProd.Location = new Point(0, 394);
            buttonRemoverProd.Name = "buttonRemoverProd";
            buttonRemoverProd.Size = new Size(182, 25);
            buttonRemoverProd.TabIndex = 1;
            buttonRemoverProd.Text = "Remover Produtos";
            buttonRemoverProd.UseVisualStyleBackColor = false;
            buttonRemoverProd.Click += buttonRemoverProd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(71, 84, 114);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(191, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(536, 470);
            dataGridView1.TabIndex = 2;
            // 
            // buttonViewProdutos
            // 
            buttonViewProdutos.Anchor = AnchorStyles.Top;
            buttonViewProdutos.BackColor = Color.Transparent;
            buttonViewProdutos.Cursor = Cursors.Hand;
            buttonViewProdutos.FlatAppearance.BorderSize = 0;
            buttonViewProdutos.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonViewProdutos.FlatStyle = FlatStyle.Flat;
            buttonViewProdutos.ForeColor = Color.White;
            buttonViewProdutos.Image = Properties.Resources.produto;
            buttonViewProdutos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewProdutos.Location = new Point(0, 327);
            buttonViewProdutos.Name = "buttonViewProdutos";
            buttonViewProdutos.Size = new Size(182, 32);
            buttonViewProdutos.TabIndex = 4;
            buttonViewProdutos.Text = "Produtos";
            buttonViewProdutos.UseVisualStyleBackColor = false;
            buttonViewProdutos.Click += buttonViewProdutos_Click;
            // 
            // buttonViewClientes
            // 
            buttonViewClientes.Anchor = AnchorStyles.Top;
            buttonViewClientes.BackColor = Color.Transparent;
            buttonViewClientes.Cursor = Cursors.Hand;
            buttonViewClientes.FlatAppearance.BorderSize = 0;
            buttonViewClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonViewClientes.FlatStyle = FlatStyle.Flat;
            buttonViewClientes.ForeColor = Color.White;
            buttonViewClientes.Image = Properties.Resources.cliente;
            buttonViewClientes.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewClientes.Location = new Point(0, 425);
            buttonViewClientes.Name = "buttonViewClientes";
            buttonViewClientes.Size = new Size(182, 32);
            buttonViewClientes.TabIndex = 5;
            buttonViewClientes.Text = "Clientes";
            buttonViewClientes.UseVisualStyleBackColor = false;
            buttonViewClientes.Click += buttonViewClientes_Click;
            // 
            // buttonViewVendas
            // 
            buttonViewVendas.Anchor = AnchorStyles.Top;
            buttonViewVendas.BackColor = Color.Transparent;
            buttonViewVendas.Cursor = Cursors.Hand;
            buttonViewVendas.FlatAppearance.BorderSize = 0;
            buttonViewVendas.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonViewVendas.FlatStyle = FlatStyle.Flat;
            buttonViewVendas.ForeColor = Color.White;
            buttonViewVendas.Image = Properties.Resources.venda;
            buttonViewVendas.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewVendas.Location = new Point(0, 227);
            buttonViewVendas.Name = "buttonViewVendas";
            buttonViewVendas.Size = new Size(182, 32);
            buttonViewVendas.TabIndex = 6;
            buttonViewVendas.Text = "Vendas";
            buttonViewVendas.UseVisualStyleBackColor = false;
            buttonViewVendas.Click += buttonViewVendas_Click;
            // 
            // buttonViewFornecedores
            // 
            buttonViewFornecedores.Anchor = AnchorStyles.Top;
            buttonViewFornecedores.BackColor = Color.Transparent;
            buttonViewFornecedores.Cursor = Cursors.Hand;
            buttonViewFornecedores.FlatAppearance.BorderSize = 0;
            buttonViewFornecedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonViewFornecedores.FlatStyle = FlatStyle.Flat;
            buttonViewFornecedores.ForeColor = Color.White;
            buttonViewFornecedores.Image = Properties.Resources.fornecedor;
            buttonViewFornecedores.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewFornecedores.Location = new Point(0, 525);
            buttonViewFornecedores.Name = "buttonViewFornecedores";
            buttonViewFornecedores.Size = new Size(182, 32);
            buttonViewFornecedores.TabIndex = 7;
            buttonViewFornecedores.Text = "Fornecedores";
            buttonViewFornecedores.UseVisualStyleBackColor = false;
            buttonViewFornecedores.Click += buttonViewFornecedores_Click;
            // 
            // buttonViewCompras
            // 
            buttonViewCompras.Anchor = AnchorStyles.Top;
            buttonViewCompras.BackColor = Color.Transparent;
            buttonViewCompras.Cursor = Cursors.Hand;
            buttonViewCompras.FlatAppearance.BorderSize = 0;
            buttonViewCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonViewCompras.FlatStyle = FlatStyle.Flat;
            buttonViewCompras.ForeColor = Color.Transparent;
            buttonViewCompras.Image = Properties.Resources.compra;
            buttonViewCompras.ImageAlign = ContentAlignment.MiddleLeft;
            buttonViewCompras.Location = new Point(0, 127);
            buttonViewCompras.Name = "buttonViewCompras";
            buttonViewCompras.Size = new Size(182, 32);
            buttonViewCompras.TabIndex = 8;
            buttonViewCompras.Text = "Compras";
            buttonViewCompras.UseVisualStyleBackColor = false;
            buttonViewCompras.Click += buttonViewCompras_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 84, 114);
            panel1.Controls.Add(buttonInicio);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(buttonAdicionarFornecedores);
            panel1.Controls.Add(buttonRemoverClient);
            panel1.Controls.Add(buttonRemoverComp);
            panel1.Controls.Add(buttonAdicionarCompra);
            panel1.Controls.Add(buttonAdicionarClient);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(buttonViewFornecedores);
            panel1.Controls.Add(buttonViewCompras);
            panel1.Controls.Add(buttonRemoverProd);
            panel1.Controls.Add(buttonAdicionarProd);
            panel1.Controls.Add(buttonViewVendas);
            panel1.Controls.Add(buttonViewProdutos);
            panel1.Controls.Add(buttonViewClientes);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 625);
            panel1.TabIndex = 9;
            // 
            // buttonInicio
            // 
            buttonInicio.BackgroundImage = Properties.Resources.image;
            buttonInicio.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.Location = new Point(50, 31);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(70, 65);
            buttonInicio.TabIndex = 14;
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 594);
            button7.Name = "button7";
            button7.Size = new Size(182, 25);
            button7.TabIndex = 16;
            button7.Text = "Remover Fornecedor";
            button7.UseVisualStyleBackColor = false;
            // 
            // buttonAdicionarFornecedores
            // 
            buttonAdicionarFornecedores.BackColor = Color.Transparent;
            buttonAdicionarFornecedores.Cursor = Cursors.Hand;
            buttonAdicionarFornecedores.FlatAppearance.BorderSize = 0;
            buttonAdicionarFornecedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonAdicionarFornecedores.FlatStyle = FlatStyle.Flat;
            buttonAdicionarFornecedores.ForeColor = Color.White;
            buttonAdicionarFornecedores.Location = new Point(0, 563);
            buttonAdicionarFornecedores.Name = "buttonAdicionarFornecedores";
            buttonAdicionarFornecedores.Size = new Size(182, 25);
            buttonAdicionarFornecedores.TabIndex = 15;
            buttonAdicionarFornecedores.Text = "Adicionar Fornecedor";
            buttonAdicionarFornecedores.UseVisualStyleBackColor = false;
            buttonAdicionarFornecedores.Click += buttonAdicionarFornecedores_Click;
            // 
            // buttonRemoverClient
            // 
            buttonRemoverClient.BackColor = Color.Transparent;
            buttonRemoverClient.Cursor = Cursors.Hand;
            buttonRemoverClient.FlatAppearance.BorderSize = 0;
            buttonRemoverClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonRemoverClient.FlatStyle = FlatStyle.Flat;
            buttonRemoverClient.ForeColor = Color.White;
            buttonRemoverClient.Location = new Point(0, 494);
            buttonRemoverClient.Name = "buttonRemoverClient";
            buttonRemoverClient.Size = new Size(182, 25);
            buttonRemoverClient.TabIndex = 14;
            buttonRemoverClient.Text = "Remover Cliente";
            buttonRemoverClient.UseVisualStyleBackColor = false;
            buttonRemoverClient.Click += buttonRemoverClient_Click;
            // 
            // buttonRemoverComp
            // 
            buttonRemoverComp.BackColor = Color.Transparent;
            buttonRemoverComp.Cursor = Cursors.Hand;
            buttonRemoverComp.FlatAppearance.BorderSize = 0;
            buttonRemoverComp.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonRemoverComp.FlatStyle = FlatStyle.Flat;
            buttonRemoverComp.ForeColor = Color.White;
            buttonRemoverComp.Location = new Point(0, 196);
            buttonRemoverComp.Name = "buttonRemoverComp";
            buttonRemoverComp.Size = new Size(182, 25);
            buttonRemoverComp.TabIndex = 12;
            buttonRemoverComp.Text = "Remover Compra";
            buttonRemoverComp.UseVisualStyleBackColor = false;
            buttonRemoverComp.Click += buttonRemoverComp_Click;
            // 
            // buttonAdicionarCompra
            // 
            buttonAdicionarCompra.BackColor = Color.Transparent;
            buttonAdicionarCompra.Cursor = Cursors.Hand;
            buttonAdicionarCompra.FlatAppearance.BorderSize = 0;
            buttonAdicionarCompra.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonAdicionarCompra.FlatStyle = FlatStyle.Flat;
            buttonAdicionarCompra.ForeColor = Color.White;
            buttonAdicionarCompra.Location = new Point(0, 165);
            buttonAdicionarCompra.Name = "buttonAdicionarCompra";
            buttonAdicionarCompra.Size = new Size(182, 25);
            buttonAdicionarCompra.TabIndex = 11;
            buttonAdicionarCompra.Text = "Adicionar Compra";
            buttonAdicionarCompra.UseVisualStyleBackColor = false;
            buttonAdicionarCompra.Click += buttonAdicionarCompra_Click;
            // 
            // buttonAdicionarClient
            // 
            buttonAdicionarClient.BackColor = Color.Transparent;
            buttonAdicionarClient.Cursor = Cursors.Hand;
            buttonAdicionarClient.FlatAppearance.BorderSize = 0;
            buttonAdicionarClient.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            buttonAdicionarClient.FlatStyle = FlatStyle.Flat;
            buttonAdicionarClient.ForeColor = Color.White;
            buttonAdicionarClient.Location = new Point(0, 463);
            buttonAdicionarClient.Name = "buttonAdicionarClient";
            buttonAdicionarClient.Size = new Size(182, 25);
            buttonAdicionarClient.TabIndex = 13;
            buttonAdicionarClient.Text = "Adicionar Cliente";
            buttonAdicionarClient.UseVisualStyleBackColor = false;
            buttonAdicionarClient.Click += buttonAdicionarClient_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 296);
            button1.Name = "button1";
            button1.Size = new Size(182, 25);
            button1.TabIndex = 10;
            button1.Text = "Remover Vendas";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(89, 105, 143);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 265);
            button2.Name = "button2";
            button2.Size = new Size(182, 25);
            button2.TabIndex = 9;
            button2.Text = "Adicionar Vendas";
            button2.UseVisualStyleBackColor = false;
            // 
            // fechar
            // 
            fechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fechar.BackColor = Color.Transparent;
            fechar.BackgroundImageLayout = ImageLayout.None;
            fechar.Cursor = Cursors.Hand;
            fechar.Image = Properties.Resources.cross;
            fechar.Location = new Point(714, 12);
            fechar.Name = "fechar";
            fechar.Size = new Size(24, 24);
            fechar.SizeMode = PictureBoxSizeMode.Zoom;
            fechar.TabIndex = 10;
            fechar.TabStop = false;
            fechar.Click += fechar_Click;
            // 
            // minimize
            // 
            minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimize.BackColor = Color.Transparent;
            minimize.BackgroundImageLayout = ImageLayout.None;
            minimize.Cursor = Cursors.Hand;
            minimize.Image = Properties.Resources.images1;
            minimize.Location = new Point(654, 12);
            minimize.Name = "minimize";
            minimize.Size = new Size(24, 24);
            minimize.SizeMode = PictureBoxSizeMode.Zoom;
            minimize.TabIndex = 11;
            minimize.TabStop = false;
            minimize.Click += minimize_Click;
            // 
            // maximize
            // 
            maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maximize.BackColor = Color.Transparent;
            maximize.Cursor = Cursors.Hand;
            maximize.Image = Properties.Resources.janela_maximizada;
            maximize.Location = new Point(684, 12);
            maximize.Name = "maximize";
            maximize.Size = new Size(24, 24);
            maximize.SizeMode = PictureBoxSizeMode.Zoom;
            maximize.TabIndex = 12;
            maximize.TabStop = false;
            maximize.Click += maximize_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Faustino1;
            pictureBox1.Location = new Point(191, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(538, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 625);
            Controls.Add(maximize);
            Controls.Add(minimize);
            Controls.Add(fechar);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionarProd;
        private Button buttonRemoverProd;
        private DataGridView dataGridView1;
        private Button buttonViewProdutos;
        private Button buttonViewClientes;
        private Button buttonViewVendas;
        private Button buttonViewFornecedores;
        private Button buttonViewCompras;
        private Panel panel1;
        private PictureBox fechar;
        private Button button1;
        private Button button2;
        private Button buttonRemoverComp;
        private Button buttonAdicionarCompra;
        private Button button7;
        private Button buttonAdicionarFornecedores;
        private Button buttonRemoverClient;
        private Button buttonAdicionarClient;
        private PictureBox minimize;
        private PictureBox maximize;
        private Button buttonInicio;
        private PictureBox pictureBox1;
    }
}
