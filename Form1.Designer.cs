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
            pictureFechar = new PictureBox();
            pictureMaximizar = new PictureBox();
            pictureMinimizar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureFechar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureMinimizar).BeginInit();
            SuspendLayout();
            // 
            // buttonAdicionar
            // 
            buttonAdicionar.Cursor = Cursors.Hand;
            buttonAdicionar.FlatAppearance.BorderSize = 0;
            buttonAdicionar.FlatStyle = FlatStyle.Flat;
            buttonAdicionar.Image = Properties.Resources.image1;
            buttonAdicionar.Location = new Point(12, 66);
            buttonAdicionar.Name = "buttonAdicionar";
            buttonAdicionar.Size = new Size(186, 65);
            buttonAdicionar.TabIndex = 0;
            buttonAdicionar.UseVisualStyleBackColor = true;
            buttonAdicionar.Click += buttonAdicionar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Cursor = Cursors.Hand;
            buttonRemover.FlatAppearance.BorderSize = 0;
            buttonRemover.FlatStyle = FlatStyle.Flat;
            buttonRemover.Image = Properties.Resources.imagen;
            buttonRemover.Location = new Point(221, 66);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(186, 65);
            buttonRemover.TabIndex = 1;
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.GradientActiveCaption;
            listBox1.Cursor = Cursors.IBeam;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 142);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(395, 229);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureFechar
            // 
            pictureFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureFechar.Cursor = Cursors.Hand;
            pictureFechar.Image = Properties.Resources.desligar1;
            pictureFechar.Location = new Point(383, 12);
            pictureFechar.Name = "pictureFechar";
            pictureFechar.Size = new Size(23, 36);
            pictureFechar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFechar.TabIndex = 3;
            pictureFechar.TabStop = false;
            pictureFechar.Click += pictureFechar_Click;
            // 
            // pictureMaximizar
            // 
            pictureMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureMaximizar.Cursor = Cursors.Hand;
            pictureMaximizar.Image = Properties.Resources.minimizar;
            pictureMaximizar.Location = new Point(350, 12);
            pictureMaximizar.Name = "pictureMaximizar";
            pictureMaximizar.Size = new Size(23, 36);
            pictureMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMaximizar.TabIndex = 3;
            pictureMaximizar.TabStop = false;
            pictureMaximizar.Click += pictureBox2_Click;
            // 
            // pictureMinimizar
            // 
            pictureMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureMinimizar.Cursor = Cursors.Hand;
            pictureMinimizar.Image = Properties.Resources.remover;
            pictureMinimizar.Location = new Point(317, 12);
            pictureMinimizar.Name = "pictureMinimizar";
            pictureMinimizar.Size = new Size(23, 36);
            pictureMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureMinimizar.TabIndex = 3;
            pictureMinimizar.TabStop = false;
            pictureMinimizar.Click += pictureMinimizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(419, 503);
            Controls.Add(pictureMinimizar);
            Controls.Add(pictureMaximizar);
            Controls.Add(pictureFechar);
            Controls.Add(listBox1);
            Controls.Add(buttonRemover);
            Controls.Add(buttonAdicionar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureFechar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureMinimizar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdicionar;
        private Button buttonRemover;
        private ListBox listBox1;
        private PictureBox pictureFechar;
        private PictureBox pictureMaximizar;
        private PictureBox pictureMinimizar;
    }
}
