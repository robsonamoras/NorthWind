using System;
using System.Data;
using System.Windows.Forms;
using NorthWind.DAL;

namespace Northwind.Win
{
    public partial class frmPrincipal : Form
    {
        ClienteDal dal;
        public frmPrincipal()
        {
            InitializeComponent();
            dal = new ClienteDal();
        }

        private void MostraTudo_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable clientes = dal.ListarClientes();
                dtClientes.DataSource = clientes;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscaPorPais_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbtPais.Checked == true)
                {
                    DataTable clientes = dal.ListarClientePorPais(txtPais.Text);
                    dtClientes.DataSource = clientes;
                }
                else if(rbtCliente.Checked == true)
                {
                    DataTable clientes = dal.BuscarClienteNome(txtPais.Text);
                    dtClientes.DataSource = clientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                dal.RemoverClientePorID(txtCodigoCliente.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtClientes_DoubleClick(object sender, EventArgs e)
        {
            int linhaAtual = dtClientes.CurrentRow.Index;

            try
            {
                txtCodigoCliente.Text = dtClientes[0, linhaAtual].Value.ToString(); // pega o id
                txtNomeCliente.Text = dtClientes[1, linhaAtual].Value.ToString(); // nome
                txtNomeContato.Text = dtClientes[2, linhaAtual].Value.ToString(); //
                txtCargoDoContato.Text = dtClientes[3, linhaAtual].Value.ToString(); //
                txtLogradouro.Text = dtClientes[4, linhaAtual].Value.ToString(); //
                txtCidade.Text = dtClientes[5, linhaAtual].Value.ToString();
                txtEstado.Text = dtClientes[6, linhaAtual].Value.ToString(); //
                txtCEP.Text = dtClientes[7, linhaAtual].Value.ToString(); //
                txtCadastrarPais.Text = dtClientes[8, linhaAtual].Value.ToString(); //
                txtTelefone.Text = dtClientes[9, linhaAtual].Value.ToString(); //
                txtCelular.Text = dtClientes[10, linhaAtual].Value.ToString(); //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tabCadastrar.Show();
            tabSistema.SelectTab(tabCadastrar);
        }

        private void rbtCliente_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
        }

        private void rbtPais_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPais.Enabled = true;
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                dal.AdicionarCliente(txtCodigoCliente.Text, txtNomeCliente.Text, txtNomeContato.Text,
                    txtCargoDoContato.Text, txtLogradouro.Text, txtCidade.Text, txtEstado.Text,
                    txtCEP.Text, txtCadastrarPais.Text, txtTelefone.Text, txtCelular.Text);
                
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LimparCampos()
        {
            txtCodigoCliente.Clear();
            txtNomeCliente.Clear();
            txtNomeContato.Clear();
            txtCargoDoContato.Clear();
            txtLogradouro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtCEP.Clear();
            txtCadastrarPais.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
        }
    }
}