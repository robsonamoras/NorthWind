using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace NorthWind.DAL
{
    public class Conexao
    {
        private SqlConnection conn;
        private static readonly string StringConexao = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        private static Conexao _instancia;

        // Singleton
        public static Conexao Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Conexao();
                }
                return _instancia;
            }
        }
        private Conexao()
        {
            conn = new SqlConnection(StringConexao);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn.Close();
            }
        }

        public SqlConnection GetConexao()
        {
            return this.conn;
        }
    }
}
