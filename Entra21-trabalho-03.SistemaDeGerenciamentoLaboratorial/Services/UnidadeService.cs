using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class UnidadeService : IUnidadeService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM unidades WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Cadastrar(Unidade unidade)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO unidades (nome, cep, logradouro, bairro, cidade, uf) VALUES (@NOME, @CEP, @LOGRADOURO, @BAIRRO, @CIDADE, @UF);";
            comando.Parameters.AddWithValue("@NOME", unidade.Nome);
            comando.Parameters.AddWithValue("@CEP", unidade.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", unidade.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", unidade.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", unidade.Cidade);
            comando.Parameters.AddWithValue("@UF", unidade.Uf);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Unidade unidade)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE unidades SET nome = @NOME, cep = @CEP, logradouro = @LOGRADOURO, bairro = @BAIRRO, cidades = @CIDADE, uf = @UF WHERE id = @ID;";
            comando.Parameters.AddWithValue("@NOME", unidade.Nome);
            comando.Parameters.AddWithValue("@CEP", unidade.Cep);
            comando.Parameters.AddWithValue("@LOGRADOURO", unidade.Logradouro);
            comando.Parameters.AddWithValue("@BAIRRO", unidade.Bairro);
            comando.Parameters.AddWithValue("@CIDADE", unidade.Cidade);
            comando.Parameters.AddWithValue("@UF", unidade.Uf);
            comando.Parameters.AddWithValue("@ID", unidade.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public Unidade ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cep, logradouro, bairro, cidade, uf FROM unidades WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var registro = tabelaEmMemoria.Rows[0];

            var unidade = new Unidade();

            unidade.Nome = registro["nome"].ToString();
            unidade.Cep = registro["cep"].ToString();
            unidade.Logradouro = registro["logradouro"].ToString();
            unidade.Bairro = registro["bairro"].ToString();
            unidade.Cidade = registro["cidade"].ToString();
            unidade.Uf = registro["uf"].ToString();

            conexao.Close();

            return unidade;
        }

        public List<Unidade> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "SELECT id, nome, cep, logradouro, bairro, cidade, uf FROM unidades;";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidades = new List<Unidade>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var unidade = new Unidade();
                unidade.Nome = registro["nome"].ToString();
                unidade.Cep = registro["cep"].ToString();
                unidade.Logradouro = registro["logradouro"].ToString();
                unidade.Bairro = registro["bairro"].ToString();
                unidade.Cidade = registro["cidade"].ToString();
                unidade.Uf = registro["uf"].ToString();

                unidades.Add(unidade);
            }
            conexao.Close();

            return unidades;
        }
    }
}
