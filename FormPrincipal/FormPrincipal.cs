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
                DataTable clientes = dal.ListarClientePorPais(txtPais.Text);
                dtClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}