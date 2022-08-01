using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Database;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using System.Data;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services
{
    internal class AgendamentoService : IAgendamentoService
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "DELETE FROM agendamentos WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Cadastrar(Agendamento agendamento)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "INSERT INTO agendamentos (preco_exame, data_hora, id_paciente, id_exame, id_unidade) VALUES (@PRECO, @DATAHORA, @IDPACIENTE, @IDEXAME, @IDUNIDADE)";
            comando.Parameters.AddWithValue("@PRECO", agendamento.Preco);
            comando.Parameters.AddWithValue("@DATAHORA", agendamento.DataHora);
            comando.Parameters.AddWithValue("@IDPACIENTE", agendamento.Paciente.Id);
            comando.Parameters.AddWithValue("@IDEXAME", agendamento.Exame.Id);
            comando.Parameters.AddWithValue("@IDUNIDADE", agendamento.Unidade.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public void Editar(Agendamento agendamento)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = "UPDATE agendamentos SET preco_exame = @PRECO, data_hora = @DATAHORA, id_paciente = @IDPACIENTE, id_exame = @IDEXAME, id_unidade = @IDUNIDADE WHERE id = @ID;";
            comando.Parameters.AddWithValue("@ID", agendamento.Id);
            comando.Parameters.AddWithValue("@IDUNIDADE", agendamento.Unidade.Id); 
            comando.Parameters.AddWithValue("@PRECO", agendamento.Preco);
            comando.Parameters.AddWithValue("@DATAHORA", agendamento.DataHora);
            comando.Parameters.AddWithValue("@IDPACIENTE", agendamento.Paciente.Id);
            comando.Parameters.AddWithValue("@IDEXAME", agendamento.Exame.Id);

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        public Agendamento ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT 
a.id,
a.preco_exame,
a.data_hora,
p.id AS 'paciente_id',
p.nome AS 'nome_paciente',
pla.coparticipacao AS 'coparticipacao',
u.id AS 'unidade_id',
u.nome AS 'unidade_nome',
e.id AS 'exame_id',
e.nome AS 'exame_nome',
e.preco AS 'exame_preco',
m.nome AS 'medico_nome'
FROM agendamentos AS a
INNER JOIN pacientes AS p ON(a.id_paciente = p.id)
INNER JOIN exames AS e ON(a.id_exame = e.id)
INNER JOIN unidades AS u ON(a.id_unidade = u.id)
INNER JOIN planos AS pla ON(p.id_plano = pla.id)
INNER JOIN medicos AS m ON(e.id_medico = m.id)
WHERE a.id = @ID;";

            comando.Parameters.AddWithValue("@ID", id);

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var registro = tabelaEmMemoria.Rows[0];

            var agendamento = new Agendamento();

            agendamento.Id = Convert.ToInt32(registro["id"]);
            agendamento.Preco = Convert.ToDecimal(registro["preco_exame"]);
            agendamento.DataHora = Convert.ToDateTime(registro["data_hora"]);

            agendamento.Paciente = new Paciente();
            agendamento.Paciente.Id = Convert.ToInt32(registro["paciente_id"]);
            agendamento.Paciente.Nome = registro["nome_paciente"].ToString();

            agendamento.Exame = new Exame();
            agendamento.Exame.Id = Convert.ToInt32(registro["exame_id"]);
            agendamento.Exame.Nome = registro["exame_nome"].ToString();
            agendamento.Exame.Preco = Convert.ToDouble(registro["exame_preco"]);

            agendamento.Exame.Medico = new Medico();
            agendamento.Exame.Medico.Nome = registro["medico_nome"].ToString();

            agendamento.Unidade = new Unidade();
            agendamento.Unidade.Id = Convert.ToInt32(registro["unidade_id"]);
            agendamento.Unidade.Nome = registro["unidade_nome"].ToString();

            conexao.Close();

            return agendamento;
        }

        public List<Agendamento> ObterTodosFiltrando(string pacientePesquisa, string unidadePesquisa)
        {
            var conexao = new Conexao().Conectar();

            var comando = conexao.CreateCommand();

            comando.CommandText = @"SELECT 
a.id,
a.preco_exame,
a.data_hora,
p.id AS 'paciente_id',
p.nome AS 'nome_paciente',
pla.coparticipacao AS 'coparticipacao',
u.id AS 'unidade_id',
u.nome AS 'unidade_nome',
e.id AS 'exame_id',
e.nome AS 'exame_nome',
e.preco AS 'exame_preco',
m.nome AS 'medico_nome'
FROM agendamentos AS a
INNER JOIN pacientes AS p ON(a.id_paciente = p.id)
INNER JOIN exames AS e ON(a.id_exame = e.id)
INNER JOIN unidades AS u ON(a.id_unidade = u.id)
INNER JOIN planos AS pla ON(p.id_plano = pla.id)
INNER JOIN medicos AS m ON(e.id_medico = m.id)
WHERE p.nome LIKE @PACIENTEPESQUISA AND u.nome LIKE @UNIDADEPESQUISA";
            comando.Parameters.AddWithValue("@PACIENTEPESQUISA", $"%{pacientePesquisa}%");
            comando.Parameters.AddWithValue("@UNIDADEPESQUISA", $"%{unidadePesquisa}%");

            var tabelaEmMemoria = new DataTable();
            tabelaEmMemoria.Load(comando.ExecuteReader());

            var agendamentos = new List<Agendamento>();

            for (int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var registro = tabelaEmMemoria.Rows[i];

                var agendamento = new Agendamento();

                agendamento.Id = Convert.ToInt32(registro["id"]);
                agendamento.Preco = Convert.ToDecimal(registro["preco_exame"]);
                agendamento.DataHora = Convert.ToDateTime(registro["data_hora"]);

                agendamento.Paciente = new Paciente();
                agendamento.Paciente.Id = Convert.ToInt32(registro["paciente_id"]);
                agendamento.Paciente.Nome = registro["nome_paciente"].ToString();

                agendamento.Exame = new Exame();
                agendamento.Exame.Id = Convert.ToInt32(registro["exame_id"]);
                agendamento.Exame.Nome = registro["exame_nome"].ToString();
                agendamento.Exame.Preco = Convert.ToDouble(registro["exame_preco"]);

                agendamento.Exame.Medico = new Medico();
                agendamento.Exame.Medico.Nome = registro["medico_nome"].ToString();

                agendamento.Unidade = new Unidade();
                agendamento.Unidade.Id = Convert.ToInt32(registro["unidade_id"]);
                agendamento.Unidade.Nome = registro["unidade_nome"].ToString();

                agendamentos.Add(agendamento);
            }

            conexao.Close();

            return agendamentos;
        }
    }
}
