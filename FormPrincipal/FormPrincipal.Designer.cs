
namespace Northwind.Win
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.MostraTudo = new System.Windows.Forms.Button();
            this.BuscaPorPais = new System.Windows.Forms.Button();
            this.Inserir = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNomeDoContato = new System.Windows.Forms.Label();
            this.lblCargoDoContato = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCargoDoContato = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.tabSistema = new System.Windows.Forms.TabControl();
            this.tabCadastrar = new System.Windows.Forms.TabPage();
            this.txtCadastrarPais = new System.Windows.Forms.TextBox();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.txtPais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.tabSistema.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MostraTudo
            // 
            resources.ApplyResources(this.MostraTudo, "MostraTudo");
            this.MostraTudo.Name = "MostraTudo";
            this.MostraTudo.UseVisualStyleBackColor = true;
            this.MostraTudo.Click += new System.EventHandler(this.MostraTudo_Click);
            // 
            // BuscaPorPais
            // 
            resources.ApplyResources(this.BuscaPorPais, "BuscaPorPais");
            this.BuscaPorPais.Name = "BuscaPorPais";
            this.BuscaPorPais.UseVisualStyleBackColor = true;
            this.BuscaPorPais.Click += new System.EventHandler(this.BuscaPorPais_Click);
            // 
            // Inserir
            // 
            resources.ApplyResources(this.Inserir, "Inserir");
            this.Inserir.Name = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            // 
            // Excluir
            // 
            resources.ApplyResources(this.Excluir, "Excluir");
            this.Excluir.Name = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            // 
            // txtNomeContato
            // 
            resources.ApplyResources(this.txtNomeContato, "txtNomeContato");
            this.txtNomeContato.Name = "txtNomeContato";
            // 
            // txtNomeCliente
            // 
            resources.ApplyResources(this.txtNomeCliente, "txtNomeCliente");
            this.txtNomeCliente.HideSelection = false;
            this.txtNomeCliente.Name = "txtNomeCliente";
            // 
            // txtCodigoCliente
            // 
            resources.ApplyResources(this.txtCodigoCliente, "txtCodigoCliente");
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            // 
            // dtClientes
            // 
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dtClientes, "dtClientes");
            this.dtClientes.Name = "dtClientes";
            // 
            // lblEmpresa
            // 
            resources.ApplyResources(this.lblEmpresa, "lblEmpresa");
            this.lblEmpresa.Name = "lblEmpresa";
            // 
            // lblNomeDoContato
            // 
            resources.ApplyResources(this.lblNomeDoContato, "lblNomeDoContato");
            this.lblNomeDoContato.Name = "lblNomeDoContato";
            // 
            // lblCargoDoContato
            // 
            resources.ApplyResources(this.lblCargoDoContato, "lblCargoDoContato");
            this.lblCargoDoContato.Name = "lblCargoDoContato";
            // 
            // lblCodigo
            // 
            resources.ApplyResources(this.lblCodigo, "lblCodigo");
            this.lblCodigo.Name = "lblCodigo";
            // 
            // txtCargoDoContato
            // 
            resources.ApplyResources(this.txtCargoDoContato, "txtCargoDoContato");
            this.txtCargoDoContato.Name = "txtCargoDoContato";
            // 
            // lblLogradouro
            // 
            resources.ApplyResources(this.lblLogradouro, "lblLogradouro");
            this.lblLogradouro.Name = "lblLogradouro";
            // 
            // txtLogradouro
            // 
            resources.ApplyResources(this.txtLogradouro, "txtLogradouro");
            this.txtLogradouro.Name = "txtLogradouro";
            // 
            // txtCidade
            // 
            resources.ApplyResources(this.txtCidade, "txtCidade");
            this.txtCidade.Name = "txtCidade";
            // 
            // lblCidade
            // 
            resources.ApplyResources(this.lblCidade, "lblCidade");
            this.lblCidade.Name = "lblCidade";
            // 
            // lblEstado
            // 
            resources.ApplyResources(this.lblEstado, "lblEstado");
            this.lblEstado.Name = "lblEstado";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtCEP
            // 
            resources.ApplyResources(this.txtCEP, "txtCEP");
            this.txtCEP.Name = "txtCEP";
            // 
            // lblTelefone
            // 
            resources.ApplyResources(this.lblTelefone, "lblTelefone");
            this.lblTelefone.Name = "lblTelefone";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // lblCEP
            // 
            resources.ApplyResources(this.lblCEP, "lblCEP");
            this.lblCEP.Name = "lblCEP";
            // 
            // lblCelular
            // 
            resources.ApplyResources(this.lblCelular, "lblCelular");
            this.lblCelular.Name = "lblCelular";
            // 
            // txtCelular
            // 
            resources.ApplyResources(this.txtCelular, "txtCelular");
            this.txtCelular.Name = "txtCelular";
            // 
            // tabSistema
            // 
            this.tabSistema.Controls.Add(this.tabCadastrar);
            this.tabSistema.Controls.Add(this.tabConsultar);
            resources.ApplyResources(this.tabSistema, "tabSistema");
            this.tabSistema.Name = "tabSistema";
            this.tabSistema.SelectedIndex = 0;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabCadastrar.Controls.Add(this.txtCadastrarPais);
            this.tabCadastrar.Controls.Add(this.txtNomeCliente);
            this.tabCadastrar.Controls.Add(this.Excluir);
            this.tabCadastrar.Controls.Add(this.txtCelular);
            this.tabCadastrar.Controls.Add(this.Inserir);
            this.tabCadastrar.Controls.Add(this.txtNomeContato);
            this.tabCadastrar.Controls.Add(this.lblCelular);
            this.tabCadastrar.Controls.Add(this.txtCodigoCliente);
            this.tabCadastrar.Controls.Add(this.lblCEP);
            this.tabCadastrar.Controls.Add(this.lblTelefone);
            this.tabCadastrar.Controls.Add(this.lblEmpresa);
            this.tabCadastrar.Controls.Add(this.textBox3);
            this.tabCadastrar.Controls.Add(this.lblNomeDoContato);
            this.tabCadastrar.Controls.Add(this.label2);
            this.tabCadastrar.Controls.Add(this.lblCargoDoContato);
            this.tabCadastrar.Controls.Add(this.txtCEP);
            this.tabCadastrar.Controls.Add(this.lblCodigo);
            this.tabCadastrar.Controls.Add(this.lblEstado);
            this.tabCadastrar.Controls.Add(this.txtCargoDoContato);
            this.tabCadastrar.Controls.Add(this.textBox1);
            this.tabCadastrar.Controls.Add(this.txtLogradouro);
            this.tabCadastrar.Controls.Add(this.lblCidade);
            this.tabCadastrar.Controls.Add(this.lblLogradouro);
            this.tabCadastrar.Controls.Add(this.txtCidade);
            resources.ApplyResources(this.tabCadastrar, "tabCadastrar");
            this.tabCadastrar.Name = "tabCadastrar";
            // 
            // txtCadastrarPais
            // 
            resources.ApplyResources(this.txtCadastrarPais, "txtCadastrarPais");
            this.txtCadastrarPais.Name = "txtCadastrarPais";
            // 
            // tabConsultar
            // 
            this.tabConsultar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabConsultar.Controls.Add(this.txtPais);
            this.tabConsultar.Controls.Add(this.dtClientes);
            this.tabConsultar.Controls.Add(this.MostraTudo);
            this.tabConsultar.Controls.Add(this.BuscaPorPais);
            resources.ApplyResources(this.tabConsultar, "tabConsultar");
            this.tabConsultar.Name = "tabConsultar";
            // 
            // txtPais
            // 
            resources.ApplyResources(this.txtPais, "txtPais");
            this.txtPais.Name = "txtPais";
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.tabSistema.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabCadastrar.PerformLayout();
            this.tabConsultar.ResumeLayout(false);
            this.tabConsultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostraTudo;
        private System.Windows.Forms.Button BuscaPorPais;
        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNomeDoContato;
        private System.Windows.Forms.Label lblCargoDoContato;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCargoDoContato;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TabControl tabSistema;
        private System.Windows.Forms.TabPage tabCadastrar;
        private System.Windows.Forms.TabPage tabConsultar;
        private System.Windows.Forms.TextBox txtCadastrarPais;
        private System.Windows.Forms.TextBox txtPais;
    }
}

