
namespace Northwind.Win
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MostraTudo = new System.Windows.Forms.Button();
            this.BuscaPorPais = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // MostraTudo
            // 
            this.MostraTudo.Location = new System.Drawing.Point(788, 78);
            this.MostraTudo.Name = "MostraTudo";
            this.MostraTudo.Size = new System.Drawing.Size(100, 43);
            this.MostraTudo.TabIndex = 0;
            this.MostraTudo.Text = "Exibir todos os clientes";
            this.MostraTudo.UseVisualStyleBackColor = true;
            this.MostraTudo.Click += new System.EventHandler(this.MostraTudo_Click);
            // 
            // BuscaPorPais
            // 
            this.BuscaPorPais.Location = new System.Drawing.Point(682, 78);
            this.BuscaPorPais.Name = "BuscaPorPais";
            this.BuscaPorPais.Size = new System.Drawing.Size(100, 43);
            this.BuscaPorPais.TabIndex = 1;
            this.BuscaPorPais.Text = "Buscar";
            this.BuscaPorPais.UseVisualStyleBackColor = true;
            this.BuscaPorPais.Click += new System.EventHandler(this.BuscaPorPais_Click);
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(284, 177);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(100, 43);
            this.Inserir.TabIndex = 2;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(284, 226);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(100, 43);
            this.Excluir.TabIndex = 3;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.Location = new System.Drawing.Point(276, 9);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(233, 45);
            this.logo.TabIndex = 4;
            this.logo.Text = "NORTHWIND";
            this.logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(55, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(55, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(223, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "País:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(439, 94);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(223, 20);
            this.txtPais.TabIndex = 10;
            this.txtPais.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // dtClientes
            // 
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Location = new System.Drawing.Point(390, 127);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.Size = new System.Drawing.Size(498, 181);
            this.dtClientes.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1171, 464);
            this.Controls.Add(this.dtClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Inserir);
            this.Controls.Add(this.BuscaPorPais);
            this.Controls.Add(this.MostraTudo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MostraTudo;
        private System.Windows.Forms.Button BuscaPorPais;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtClientes;
    }
}

