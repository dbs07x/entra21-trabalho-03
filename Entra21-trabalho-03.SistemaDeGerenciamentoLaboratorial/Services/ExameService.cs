using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class ExameService : IExameService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM exames WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Exame exame)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"INSERT INTO exames (nome, preco, instrucoes, id_medico)
VALUES (@NOME, @PRECO, @INSTRUCOES, @ID_MEDICO);";
            comando.Parameters.AddWithValue("@NOME", exame.Nome);
            comando.Parameters.AddWithValue("@PRECO", exame.Preco);
            comando.Parameters.AddWithValue("@INSTRUCOES", exame.Instrucoes);
            comando.Parameters.AddWithValue("@ID_MEDICO", exame.Medico.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Exame exame)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"UPDATE exames
SET nome = @NOME, preco = @PRECO, instrucoes = @INSTRUCOES, id_medico = @ID_MEDICO
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", exame.Nome);
            comando.Parameters.AddWithValue("@PRECO", exame.Preco);
            comando.Parameters.AddWithValue("@INSTRUCOES", exame.Instrucoes);
            comando.Parameters.AddWithValue("@ID_MEDICO", exame.Medico.Id);
            comando.Parameters.AddWithValue("@ID", exame.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Exame ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
e.id,
e.nome,
e.preco,
e.instrucoes,
e.id_medico,
m.nome AS nome_medico
FROM exames AS e
INNER JOIN medicos AS m ON(e.id_medico = m.id)
WHERE e.id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var registro = tabelaEmMemoria.Rows[0];

            var exame = new Exame();

            exame.Nome = registro["nome"].ToString();
            exame.Preco = Convert.ToDouble(registro["preco"]);
            exame.Instrucoes = registro["instrucoes"].ToString();

            exame.Medico = new Medico();
            exame.Medico.Id = Convert.ToInt32(registro["id_medico"]);
            exame.Medico.Nome = registro["nome_medico"].ToString();

            conexao.Close();

            return exame;
        }

        public List<Exame> ObterTodosFiltrando(string examePesquisa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
e.id, 
e.nome, 
e.preco, 
e.instrucoes, 
e.id_medico,
m.nome AS nome_medico
FROM exames AS e
INNER JOIN medicos AS m ON(e.id_medico = m.id)
WHERE m.id LIKE @MEDICOPESQUISA";
            comando.Parameters.AddWithValue("@MEDICOPESQUISA", $"%{examePesquisa}%");

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var exames = new List<Exame>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var exame = new Exame();

                exame.Id = Convert.ToInt32(registro["id"]);
                exame.Nome = registro["nome"].ToString();
                exame.Preco = Convert.ToDouble(registro["preco"]);
                exame.Instrucoes = registro["instrucoes"].ToString();

                exame.Medico = new Medico();
                exame.Medico.Id = Convert.ToInt32(registro["id_medico"]);

                exames.Add(exame);
            }

            comando.Connection.Close();

            return exames;
        }
    }
}
