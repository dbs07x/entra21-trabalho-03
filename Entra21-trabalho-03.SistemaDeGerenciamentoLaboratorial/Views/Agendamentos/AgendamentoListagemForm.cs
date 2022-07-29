using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;
using System.Globalization;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Agendamentos
{
    public partial class AgendamentoListagemForm : Form
    {
        internal readonly AgendamentoService _agendamentoService;

        public AgendamentoListagemForm()
        {
            InitializeComponent();

            _agendamentoService = new AgendamentoService();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var pacientePesquisa = textBoxNomePaciente.Text.Trim();
            var unidadePesquisa = textBoxUnidade.Text.Trim();

            var agendamentos = _agendamentoService.ObterTodosFiltrando(pacientePesquisa, unidadePesquisa);

            dataGridView1.Rows.Clear();

            var cultura = new CultureInfo("pt-BR");
            cultura.NumberFormat.NumberDecimalSeparator = ",";
            cultura.NumberFormat.CurrencyGroupSeparator = ".";
            cultura.NumberFormat.NumberDecimalDigits = 2;

            for (int i = 0; i < agendamentos.Count; i++)
            {
                var agendamento = agendamentos[i];

                dataGridView1.Rows.Add(new object[]
                {
                    agendamento.Id,
                    agendamento.DataHora.ToString("dd/mm/yyy HH:mm"),
                    string.Format(cultura, "R$ {0:N}", agendamento.Preco),
                    agendamento.Paciente.Nome,
                    agendamento.Exame.Nome,
                    agendamento.Unidade.Nome,
                    agendamento.Exame.Medico.Nome
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrarForm = new AgendamentoCadastroEdicaoForm();
            cadastrarForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento selecionado");

                return;
            }

            var desejaApagar = MessageBox.Show("Deseja realmente apagar", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (desejaApagar == DialogResult.No)
                return;

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                _agendamentoService.Apagar(idRegistro);

                MessageBox.Show("Cliente apagado com sucesso");

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível apagar esse registro");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum agendamento selecionado");

                return;
            }

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                var agendamento = _agendamentoService.ObterPorId(idRegistro);

                var agendamentoForm = new AgendamentoCadastroEdicaoForm(agendamento);

                agendamentoForm.ShowDialog();

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível buscar por esse registro");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }
    }
}

