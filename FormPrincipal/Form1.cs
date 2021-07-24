using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWind.DAL;

namespace Northwind.Win
{
    public partial class Form1 : Form
    {
        ClienteDal dal;
        public Form1()
        {
            InitializeComponent();
           dal = new ClienteDal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void MostraTudo_Click(object sender, EventArgs e)
        {
            try
            {
               
                DataTable clientes = dal.ListarClientes();
                dtClientes.DataSource = clientes;
                

            } catch (Exception ex)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
