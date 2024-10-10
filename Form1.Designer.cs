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
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.Location = new Point(12, 12);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(125, 27);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.Text = "Adicionar";
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Cursor = Cursors.Hand;
            buttonRemover.Location = new Point(180, 12);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(125, 27);
            buttonRemover.TabIndex = 1;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.Cursor = Cursors.IBeam;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 53);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 409);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 473);
            Controls.Add(listBox1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private ListBox listBox1;
    }
}
