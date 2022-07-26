using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            SqlConnection conexao = new SqlConnection();

            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Douglas\Source\Repos\dbs07x\entra21-trabalho-03\Entra21-trabalho-03.SistemaDeGerenciamentoLaboratorial\Database\Database.mdf;Integrated Security=True";

            conexao.ConnectionString = connectionString;

            conexao.Open();

            return conexao;
        }
    }
}
