using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class PacienteService : IPacienteService
    {
        public void Apagar(int id)
        {

            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM pacientes WHERE id = @ID";


            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Cadastrar(Paciente paciente)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO pacientes (nome, data_nascimento, cpf, " +
                "telefone, email, id_plano) " +
                "VALUES (@NOME, @DATA_NASCIMENTO, @CPF, @TELEFONE, @EMAIL, @IDPLANO);";

            comando.Parameters.AddWithValue("@NOME", paciente.Nome);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", paciente.Data_nascimento);
            comando.Parameters.AddWithValue("@CPF", paciente.Cpf);
            comando.Parameters.AddWithValue("@TELEFONE", paciente.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", paciente.Email);
            comando.Parameters.AddWithValue("@IDPLANO", paciente.Plano.Id);

            comando.ExecuteNonQuery();
    
            comando.Connection.Close();
        }

        public void Editar(Paciente paciente)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"UPDATE pacientes SET 
                nome = @NOME, data_nascimento = @DATA_NASCIMENTO, cpf = @CPF,
                telefone = @TELEFONE, email = @EMAIL, id_plano = @IDPLANO WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", paciente.Id);
            comando.Parameters.AddWithValue("@NOME", paciente.Nome);
            comando.Parameters.AddWithValue("@DATA_NASCIMENTO", paciente.Data_nascimento);
            comando.Parameters.AddWithValue("@CPF", paciente.Cpf);
            comando.Parameters.AddWithValue("@TELEFONE", paciente.Telefone);
            comando.Parameters.AddWithValue("@EMAIL", paciente.Email);
            comando.Parameters.AddWithValue("@IDPLANO", paciente.Plano.Id);


            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public Paciente ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome',
p.data_nascimento AS 'data_nascimento',
p.cpf AS 'cpf',
p.id AS 'editora_id',
p.telefone AS 'telefone',
p.email AS 'email',
p.id_plano AS 'id_plano',
pl.nome AS 'nome_plano',
pl.coparticipacao AS 'coparticipacao'
FROM pacientes AS p
INNER JOIN planos AS pl ON(p.id_plano = pl.id)
WHERE p.id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();
            
            dataTable.Load(comando.ExecuteReader());
            
            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var paciente = new Paciente();
            paciente.Id = Convert.ToInt32(registro["id"]);
            paciente.Nome = registro["nome"].ToString();
            paciente.Data_nascimento = Convert.ToDateTime(registro["data_nascimento"]);
            paciente.Cpf = registro["cpf"].ToString();
            paciente.Email = registro["email"].ToString();
            paciente.Telefone = registro["telefone"].ToString();

            paciente.Plano = new Plano();
            paciente.Plano.Id = Convert.ToInt32(registro["id_plano"]);
            paciente.Plano.Nome = registro["nome_plano"].ToString();
            paciente.Plano.Coparticipacao = Convert.ToDecimal(registro["coparticipacao"]);

            conexao.Close();

            return paciente;
        }

        public List<Paciente> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT
p.id AS 'id',
p.nome AS 'nome',
p.data_nascimento AS 'data_nascimento',
p.cpf AS 'cpf',
p.id AS 'editora_id',
p.telefone AS 'telefone',
p.email AS 'email',
p.id_plano,
pl.nome AS 'nome_plano',
pl.coparticipacao AS 'coparticipacao'
FROM pacientes AS p
INNER JOIN planos AS pl ON(p.id_plano = pl.id)";
            
            var tabelaEmMemoria = new DataTable();
            
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var pacientes = new List<Paciente>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];
                var paciente = new Paciente();
                paciente.Id = Convert.ToInt32(registro["id"]);
                paciente.Nome = registro["nome"].ToString();
                paciente.Data_nascimento = Convert.ToDateTime(registro["data_nascimento"]);
                paciente.Cpf = registro["cpf"].ToString();
                paciente.Email = registro["email"].ToString();
                paciente.Telefone = registro["telefone"].ToString();

                paciente.Plano = new Plano();
                paciente.Plano.Nome = registro["nome_plano"].ToString();
                paciente.Plano.Coparticipacao = Convert.ToDecimal(registro["coparticipacao"]);

                pacientes.Add(paciente);
            }

            return pacientes;
        }
    }
}
