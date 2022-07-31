using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Medicos
{
    public partial class MedicoListagemForm : Form
    {
        internal readonly MedicoService _medicoService;

        public MedicoListagemForm()
        {
            InitializeComponent();

            _medicoService = new MedicoService();

            PreencherDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrarForm = new MedicoCadastroEdicaoForm();
            cadastrarForm.ShowDialog();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var nomePesquisa = textBoxNome.Text.Trim();

            var medicos = _medicoService.ObterTodosFiltrando(nomePesquisa);

            dataGridView1.Rows.Clear();

            for (int i = 0; i < medicos.Count; i++)
            {
                var medico = medicos[i];

                dataGridView1.Rows.Add(new object[]
                {

                    medico.Id,
                    medico.Nome,
                    medico.DataNascimento,
                    medico.Cpf.Substring(0, 3) + "." + medico.Cpf.Substring(2, 3) + "." + medico.Cpf.Substring(5, 3) + "-" + medico.Cpf.Substring(8, 2),
                    medico.Crm,
                    medico.Uf,
                    medico.Telefone.Substring(0, 0) + "(" + medico.Telefone.Substring(0, 2) + ")" + medico.Telefone.Substring(2,1) + " " + medico.Telefone.Substring(3, 4) + "-" + medico.Telefone.Substring(7, 4),
                    medico.Email
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum médico cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um médico");
                return;
            }

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                var medico = _medicoService.ObterPorId(idRegistro);

                var medicoForm = new MedicoCadastroEdicaoForm(medico);

                medicoForm.ShowDialog();

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível buscar por esse registro");
            }
        }
        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum médico cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum médico selecionado");

                return;
            }

            var desejaApagar = MessageBox.Show("Deseja realmente apagar", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (desejaApagar == DialogResult.No)
                return;

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                _medicoService.Apagar(idRegistro);

                MessageBox.Show("Registro apagado com sucesso");

                PreencherDataGridView();
            }
            catch (SqlException)
            {
                MessageBox.Show("Não foi possível apagar esse registro");
            }
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDataGridView();
        }

    }
}
