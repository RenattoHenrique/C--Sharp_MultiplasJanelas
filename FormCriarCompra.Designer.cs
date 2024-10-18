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
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBoxProduto = new ComboBox();
            comboBoxFornecedor = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 0;
            label2.Text = "Fornecedores:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 99);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 0;
            label4.Text = "Desconto (%):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 121);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 0;
            label5.Text = " Preço Unitário:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 151);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 0;
            label6.Text = "Valor Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 180);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 0;
            label7.Text = "Total Com Desconto:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(133, 66);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(133, 95);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(171, 23);
            numericUpDown2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlDarkDark;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(133, 123);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ControlDarkDark;
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(133, 153);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ControlDarkDark;
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(133, 182);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 2;
            // 
            // comboBoxProduto
            // 
            comboBoxProduto.FormattingEnabled = true;
            comboBoxProduto.Location = new Point(133, 9);
            comboBoxProduto.Name = "comboBoxProduto";
            comboBoxProduto.Size = new Size(171, 23);
            comboBoxProduto.TabIndex = 3;
            // 
            // comboBoxFornecedor
            // 
            comboBoxFornecedor.FormattingEnabled = true;
            comboBoxFornecedor.Location = new Point(133, 38);
            comboBoxFornecedor.Name = "comboBoxFornecedor";
            comboBoxFornecedor.Size = new Size(171, 23);
            comboBoxFornecedor.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(148, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(229, 235);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormCriarCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 286);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxFornecedor);
            Controls.Add(comboBoxProduto);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCriarCompra";
            Text = "FormCriarCompra";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBoxProduto;
        private ComboBox comboBoxFornecedor;
        private Button button1;
        private Button button2;
    }
}