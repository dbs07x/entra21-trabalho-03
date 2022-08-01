using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class PlanoService : IPlanoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM planos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Plano plano)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO planos (nome, abrangencia, acomodacao, coparticipacao," +
                " preco ) " +
                "VALUES (@NOME, @ABRANGENCIA, @ACOMODACAO, @COPARTICIPACAO ,@PRECO);";

            comando.Parameters.AddWithValue("@NOME", plano.Nome);
            comando.Parameters.AddWithValue("@ABRANGENCIA", plano.Abrangencia);
            comando.Parameters.AddWithValue("@ACOMODACAO", plano.Acomodacao);
            comando.Parameters.AddWithValue("@COPARTICIPACAO", plano.Coparticipacao / 100);
            comando.Parameters.AddWithValue("@PRECO", plano.Preco);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Plano plano)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE planos SET 
nome = @NOME,
abrangencia = @ABRANGENCIA,
acomodacao = @ACOMODACAO,
coparticipacao = @COPARTICIPACAO,
preco = @PRECO
WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", plano.Id);
            comando.Parameters.AddWithValue("@NOME", plano.Nome);
            comando.Parameters.AddWithValue("@ABRANGENCIA", plano.Abrangencia);
            comando.Parameters.AddWithValue("@ACOMODACAO", plano.Acomodacao);
            comando.Parameters.AddWithValue("@COPARTICIPACAO", plano.Coparticipacao);
            comando.Parameters.AddWithValue("@PRECO", plano.Preco);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Plano ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome , abrangencia , acomodacao, coparticipacao, " +
                " preco FROM planos WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            var registro = dataTable.Rows[0];

            var plano = new Plano();

            plano.Id = Convert.ToInt32(registro["id"]);
            plano.Nome = registro["nome"].ToString();
            plano.Abrangencia = registro["abrangencia"].ToString();
            plano.Acomodacao = registro["acomodacao"].ToString();
            plano.Coparticipacao = Convert.ToDecimal(registro["coparticipacao"].ToString());
            plano.Preco = Convert.ToDecimal(registro["preco"].ToString());

            conexao.Close();

            return plano;
        }

        public List<Plano> ObterTodosFiltrando(string planoPesquisa)
        {

            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome',
p.acomodacao AS 'acomodacao',
p.abrangencia AS 'abrangencia',
p.coparticipacao AS 'coparticipacao',
p.preco AS 'preco'
FROM planos AS p
WHERE nome LIKE @NOME";
            comando.Parameters.AddWithValue("@NOME", $"{planoPesquisa}%");

            var dataTable = new DataTable();
            dataTable.Load(comando.ExecuteReader());

            var planos = new List<Plano>();

            for (int i = 0; i < dataTable.Rows.Count; i++) 
            {

                var registro = dataTable.Rows[i];

                var plano = new Plano();
                plano.Id = Convert.ToInt32(registro["id"]);
                plano.Nome = registro["nome"].ToString();
                plano.Abrangencia = registro["abrangencia"].ToString();
                plano.Acomodacao = registro["acomodacao"].ToString();
                plano.Preco = Convert.ToDecimal(registro["preco"]);
                plano.Coparticipacao = Convert.ToDecimal(registro["coparticipacao"]);

                planos.Add(plano);
            }

            return planos;

        }
    }
}
