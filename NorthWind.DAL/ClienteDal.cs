using System;
using NorthWind.Entities;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace NorthWind.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientes()
        {
            DataTable dt;
            SqlConnection conn = Conexao.Instancia.GetConexao();
            
            string str = @"Select * from Customers";
            SqlCommand sql = new SqlCommand(str, conn);
            sql.CommandType = CommandType.Text;
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql);

            dt = new DataTable();
            adapter.Fill(dt);
            conn.Close();

            return dt;
        }

        public DataTable ListarClientePorPais(string pais)
        {
            DataTable dt;
            
            SqlConnection conn = Conexao.Instancia.GetConexao();
            
            string str = @"SELECT CompanyName as Nome, Country as Pais, Address
	        FROM Customers
	        WHERE Country = @Country;";
            SqlCommand sql = new SqlCommand(str, conn);
            sql.CommandType = CommandType.Text;
            sql.Parameters.Add("@Country", SqlDbType.NVarChar).Value = pais;
            
            SqlDataAdapter adapter = new SqlDataAdapter(sql);

            dt = new DataTable();
            adapter.Fill(dt);
                
            //Aqui entra o grid
            
            return dt;
        }

        public DataTable BuscarClienteNome(string nome)
        {
            DataTable dt;

            SqlConnection conn = Conexao.Instancia.GetConexao();
            
            string str = @"SELECT * FROM Customers
	        WHERE CompanyName = @NomeCliente;";
            SqlCommand sql = new SqlCommand(str, conn);
            sql.CommandType = CommandType.Text;
            sql.Parameters.Add("@NomeCliente", SqlDbType.NVarChar).Value = nome;

            SqlDataAdapter adapter = new SqlDataAdapter(sql);

            dt = new DataTable();
            adapter.Fill(dt);
                
            
            return dt;
        }

        public bool AdicionarCliente(string id, string empresa, string nomeContato, string cargo,
                                     string logradouro, string cidade, string estado, string cep,
                                     string pais, string telefone, string celular)
        {
            SqlConnection conn = Conexao.Instancia.GetConexao();
            
            string str = @"INSERT INTO Customers 
            (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country,Phone, Fax)
            VALUES('@CustomerID', '@CompanyName', '@ContactName', '@ContactTitle', '@Address', '@City', '@Region', '@PostalCode', '@Country','@Phone', '@Fax' );";

            SqlCommand sql = new SqlCommand(str, conn);
            sql.CommandType = CommandType.Text;
            sql.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = id;
            sql.Parameters.Add("@CompanyName", SqlDbType.NVarChar).Value = empresa;
            sql.Parameters.Add("@ContactName", SqlDbType.NVarChar).Value = nomeContato;
            sql.Parameters.Add("@ContactTitle", SqlDbType.NVarChar).Value = cargo;
            sql.Parameters.Add("@Address", SqlDbType.NVarChar).Value = logradouro;
            sql.Parameters.Add("@City", SqlDbType.NVarChar).Value = cidade;
            sql.Parameters.Add("@Region", SqlDbType.NVarChar).Value = estado;
            sql.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = cep;
            sql.Parameters.Add("@Country", SqlDbType.NVarChar).Value = pais;
            sql.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = telefone;
            sql.Parameters.Add("@Fax", SqlDbType.NVarChar).Value = celular;

            sql.ExecuteNonQuery();
            
            return true;
        }

        public bool RemoverClientePorID(string id)
        {
            SqlConnection conn = Conexao.Instancia.GetConexao();
            
            string str = @"DELETE FROM Customers WHERE CustomerID = '@CustomerID';";

            SqlCommand sql = new SqlCommand(str, conn);
            sql.CommandType = CommandType.Text;

            sql.Parameters.Add("@CustomerID", SqlDbType.NVarChar).Value = id;

            sql.ExecuteNonQuery();
            
            return true;  
        }
    }
}
