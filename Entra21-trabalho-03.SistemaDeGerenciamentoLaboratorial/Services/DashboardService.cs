using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class DashboardService : IDashboardService
    {
        public int ObterQuantidadeTabelas(string tabela)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = $"SELECT COUNT(id) AS quantidade FROM {tabela};";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var row = tabelaEmMemoria.Rows[0];

            var quantidade = Convert.ToInt32(row["quantidade"]);

            return quantidade;
        }
    }
}
