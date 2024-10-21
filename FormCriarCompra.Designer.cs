namespace MultiplasJanelas
{
    partial class FormCriarCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownDesconto = new NumericUpDown();
            textBoxPrecoUnitario = new TextBox();
            textBoxValorTotal = new TextBox();
            textBoxTotalComDesconto = new TextBox();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            buttonOk = new Button();
            buttonCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Fornecedores:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 0;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = " Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 151);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 180);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 0;
            label7.Text = "Total Com Desconto:";
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Cursor = Cursors.Hand;
            numericUpDownQuantidade.Location = new Point(133, 66);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(171, 23);
            numericUpDownQuantidade.TabIndex = 3;
            numericUpDownQuantidade.ValueChanged += numericUpDownQuantidade_ValueChanged;
            // 
            // numericUpDownDesconto
            // 
            numericUpDownDesconto.Cursor = Cursors.Hand;
            numericUpDownDesconto.ForeColor = Color.Green;
            numericUpDownDesconto.Location = new Point(133, 95);
            numericUpDownDesconto.Name = "numericUpDownDesconto";
            numericUpDownDesconto.Size = new Size(171, 23);
            numericUpDownDesconto.TabIndex = 4;
            numericUpDownDesconto.ValueChanged += numericUpDownDesconto_ValueChanged;
            // 
            // textBoxPrecoUnitario
            // 
            textBoxPrecoUnitario.BackColor = Color.FromArgb(71, 84, 114);
            textBoxPrecoUnitario.BorderStyle = BorderStyle.None;
            textBoxPrecoUnitario.ForeColor = Color.White;
            textBoxPrecoUnitario.Location = new Point(133, 123);
            textBoxPrecoUnitario.Name = "textBoxPrecoUnitario";
            textBoxPrecoUnitario.ReadOnly = true;
            textBoxPrecoUnitario.Size = new Size(171, 16);
            textBoxPrecoUnitario.TabIndex = 0;
            // 
            // textBoxValorTotal
            // 
            textBoxValorTotal.BackColor = Color.FromArgb(71, 84, 114);
            textBoxValorTotal.BorderStyle = BorderStyle.None;
            textBoxValorTotal.ForeColor = Color.White;
            textBoxValorTotal.Location = new Point(133, 153);
            textBoxValorTotal.Name = "textBoxValorTotal";
            textBoxValorTotal.ReadOnly = true;
            textBoxValorTotal.Size = new Size(171, 16);
            textBoxValorTotal.TabIndex = 0;
            // 
            // textBoxTotalComDesconto
            // 
            textBoxTotalComDesconto.BackColor = Color.FromArgb(71, 84, 114);
            textBoxTotalComDesconto.BorderStyle = BorderStyle.None;
            textBoxTotalComDesconto.ForeColor = Color.White;
            textBoxTotalComDesconto.Location = new Point(133, 182);
            textBoxTotalComDesconto.Name = "textBoxTotalComDesconto";
            textBoxTotalComDesconto.ReadOnly = true;
            textBoxTotalComDesconto.Size = new Size(171, 16);
            textBoxTotalComDesconto.TabIndex = 0;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.Cursor = Cursors.Hand;
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(133, 9);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(171, 23);
            comboBoxProduto.TabIndex = 1;
            comboBoxProduto.SelectedIndexChanged += comboBoxProduto_SelectedIndexChanged;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.Cursor = Cursors.Hand;
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(133, 38);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(171, 23);
            comboBoxFornecedor.TabIndex = 2;
            // 
            // buttonOk
            // 
            buttonOk.BackColor = Color.FromArgb(71, 84, 114);
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.FlatAppearance.BorderSize = 0;
            buttonOk.FlatStyle = FlatStyle.Flat;
            buttonOk.ForeColor = Color.White;
            buttonOk.Location = new Point(148, 235);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = false;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(71, 84, 114);
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.FlatAppearance.BorderSize = 0;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = Color.White;
            buttonCancelar.Location = new Point(229, 235);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // FormCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 286);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(textBoxTotalComDesconto);
            Controls.Add(textBoxValorTotal);
            Controls.Add(textBoxPrecoUnitario);
            Controls.Add(numericUpDownDesconto);
            Controls.Add(numericUpDownQuantidade);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.No;
            Name = "FormCriarCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCriarCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDesconto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownDesconto;
        private TextBox textBoxPrecoUnitario;
        private TextBox textBoxValorTotal;
        private TextBox textBoxTotalComDesconto;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private Button buttonOk;
        private Button buttonCancelar;
    }
}