namespace MultiplasJanelas
{
    partial class FormCriarProduto
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
            buttonOk = new Button();
            buttonCancelar = new Button();
            labelPrecodeVenda = new Label();
            labelFabricante = new Label();
            labelPrecodeCompra = new Label();
            labelNomedoProduto = new Label();
            inputPrecoCompra = new NumericUpDown();
            InputPrecoVenda = new NumericUpDown();
            textBoxNome = new TextBox();
            textBoxFabricante = new TextBox();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // buttonOk
            // 
            buttonOk.Cursor = Cursors.Hand;
            buttonOk.Location = new Point(32, 170);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 5;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Cursor = Cursors.Hand;
            buttonCancelar.Location = new Point(186, 170);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelPrecodeVenda
            // 
            labelPrecodeVenda.AutoSize = true;
            labelPrecodeVenda.Location = new Point(32, 117);
            labelPrecodeVenda.Name = "labelPrecodeVenda";
            labelPrecodeVenda.Size = new Size(88, 15);
            labelPrecodeVenda.TabIndex = 0;
            labelPrecodeVenda.Text = "Preço de Venda";
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.Location = new Point(32, 58);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(62, 15);
            labelFabricante.TabIndex = 0;
            labelFabricante.Text = "Fabricante";
            // 
            // labelPrecodeCompra
            // 
            labelPrecodeCompra.AutoSize = true;
            labelPrecodeCompra.Location = new Point(32, 88);
            labelPrecodeCompra.Name = "labelPrecodeCompra";
            labelPrecodeCompra.Size = new Size(99, 15);
            labelPrecodeCompra.TabIndex = 0;
            labelPrecodeCompra.Text = "Preço de Compra";
            // 
            // labelNomedoProduto
            // 
            labelNomedoProduto.AutoSize = true;
            labelNomedoProduto.Location = new Point(32, 29);
            labelNomedoProduto.Name = "labelNomedoProduto";
            labelNomedoProduto.Size = new Size(103, 15);
            labelNomedoProduto.TabIndex = 0;
            labelNomedoProduto.Text = "Nome do Produto";
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.Cursor = Cursors.Hand;
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            inputPrecoCompra.ForeColor = Color.Green;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(141, 84);
            inputPrecoCompra.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(120, 25);
            inputPrecoCompra.TabIndex = 3;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // InputPrecoVenda
            // 
            InputPrecoVenda.Cursor = Cursors.Hand;
            InputPrecoVenda.DecimalPlaces = 2;
            InputPrecoVenda.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            InputPrecoVenda.ForeColor = Color.FromArgb(192, 0, 0);
            InputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            InputPrecoVenda.Location = new Point(141, 113);
            InputPrecoVenda.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            InputPrecoVenda.Name = "InputPrecoVenda";
            InputPrecoVenda.Size = new Size(120, 25);
            InputPrecoVenda.TabIndex = 4;
            InputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // textBoxNome
            // 
            textBoxNome.Cursor = Cursors.IBeam;
            textBoxNome.ForeColor = Color.Black;
            textBoxNome.Location = new Point(141, 25);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(120, 23);
            textBoxNome.TabIndex = 1;
            textBoxNome.TextChanged += textBoxNome_TextChanged;
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Cursor = Cursors.IBeam;
            textBoxFabricante.ForeColor = Color.Black;
            textBoxFabricante.Location = new Point(141, 54);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(120, 23);
            textBoxFabricante.TabIndex = 2;
            // 
            // FormCriarProduto
            // 
            AcceptButton = buttonOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            CancelButton = buttonCancelar;
            ClientSize = new Size(284, 212);
            Controls.Add(textBoxFabricante);
            Controls.Add(textBoxNome);
            Controls.Add(InputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(labelNomedoProduto);
            Controls.Add(labelPrecodeCompra);
            Controls.Add(labelFabricante);
            Controls.Add(labelPrecodeVenda);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonOk);
            Name = "FormCriarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCriarProduto";
            Load += FormCriarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk;
        private Button buttonCancelar;
        private Label labelPrecodeVenda;
        private Label labelFabricante;
        private Label labelPrecodeCompra;
        private Label labelNomedoProduto;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown InputPrecoVenda;
        private TextBox textBoxNome;
        private TextBox textBoxFabricante;
    }
}