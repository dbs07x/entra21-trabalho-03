using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class MedicoService : IMedicoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM medicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Medico medico)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO medicos (nome, data_nascimento, cpf, crm, uf, telefone, email) VALUES (@NOME, @DATA_NASCIMENTO, @CPF, @CRM, @UF, @TELEFONE, @EMAIL);";
            comando.Parameters.AddWithValue("@NOME", medico.Nome);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", medico.DataNascimento);
            comando.Parameters.AddWithValue("@CPF", medico.Cpf);
            comando.Parameters.AddWithValue("@CRM", medico.Crm);
            comando.Parameters.AddWithValue("@UF", medico.Uf);
            comando.Parameters.AddWithValue("@TELEFONE", medico.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", medico.Email);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(Medico medico)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText =@"UPDATE medicos
SET nome = @NOME, data_nascimento = @DATA_NASCIMENTO, cpf = @CPF, crm = @CRM, uf = @UF, telefone = @TELEFONE, email = @EMAIL
WHERE id = @ID";
            comando.Parameters.AddWithValue("@NOME", medico.Nome);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", medico.DataNascimento);
            comando.Parameters.AddWithValue("@CPF", medico.Cpf);
            comando.Parameters.AddWithValue("@CRM", medico.Crm);
            comando.Parameters.AddWithValue("@UF", medico.Uf);
            comando.Parameters.AddWithValue("@TELEFONE", medico.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", medico.Email);
            comando.Parameters.AddWithValue("@ID", medico.Id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Medico ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, data_nascimento, cpf, crm, uf, telefone, email
FROM medicos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var registro = tabelaEmMemoria.Rows[0];

            var medico = new Medico();

            medico.Nome = registro["nome"].ToString();
            medico.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
            medico.Cpf = registro["cpf"].ToString();
            medico.Crm = registro["crm"].ToString();
            medico.Uf = registro["uf"].ToString();
            medico.Telefone = registro["telefone"].ToString();
            medico.Email = registro["email"].ToString();

            conexao.Close();

            return medico;
        }

        public List<Medico> ObterTodos()
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT id, nome, data_nascimento, cpf, crm, uf, telefone, email
FROM medicos";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var medicos = new List<Medico>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var medico = new Medico();
                medico.Id = Convert.ToInt32(registro["id"]);
                medico.Nome = registro["nome"].ToString();
                medico.DataNascimento = Convert.ToDateTime(registro["data_nascimento"]);
                medico.Cpf = registro["cpf"].ToString();
                medico.Crm = registro["crm"].ToString();
                medico.Uf = registro["uf"].ToString();
                medico.Telefone = registro["telefone"].ToString();
                medico.Email = registro["email"].ToString();

                medicos.Add(medico);
            }

            comando.Connection.Close();

            return medicos;
        }
    }
}
