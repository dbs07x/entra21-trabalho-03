using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Exames
{
    public partial class ExameListagemForm : Form
    {
        internal readonly ExameService _exameService;

        public ExameListagemForm()
        {
            InitializeComponent();

            _exameService = new ExameService();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var examePesquisa = textBoxNome.Text.Trim();

            var exames = _exameService.ObterTodosFiltrando(examePesquisa);

            dataGridView1.Rows.Clear();

            for (int i = 0; i < exames.Count; i++)
            {
                var exame = exames[i];

                dataGridView1.Rows.Add(new object[]
                {

                    exame.Id,
                    exame.Nome,
                    exame.Preco,
                    exame.Instrucoes,
                    exame.Medico.Nome
                });
            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrarForm = new ExameCadastroEdicaoForm();
            cadastrarForm.ShowDialog();

            PreencherDataGridView();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum exame cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum exame selecionado");

                return;
            }

            var desejaApagar = MessageBox.Show("Deseja realmente apagar", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (desejaApagar == DialogResult.No)
                return;

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                _exameService.Apagar(idRegistro);

                MessageBox.Show("Registro apagado com sucesso");

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
                MessageBox.Show("Nenhum exame cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum exame selecionado");

                return;
            }

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                var exame = _exameService.ObterPorId(idRegistro);

                var exameForm = new ExameCadastroEdicaoForm(exame);

                exameForm.ShowDialog();

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
