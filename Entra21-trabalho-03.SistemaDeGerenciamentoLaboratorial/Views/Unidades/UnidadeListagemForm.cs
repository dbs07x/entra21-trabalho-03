using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;
using System.Data.SqlClient;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Unidades
{
    public partial class UnidadeListagemForm : Form
    {
        internal readonly UnidadeService _unidadeService;

        public UnidadeListagemForm()
        {
            InitializeComponent();

            _unidadeService = new UnidadeService();
            
            PreencherDataGridView();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            var cadastrarForm = new UnidadeCadastroEdicaoForm();
            cadastrarForm.ShowDialog();

            PreencherDataGridView();
        }

        private void PreencherDataGridView()
        {
            var nomePesquisa = textBoxNome.Text.Trim();

            var unidades = _unidadeService.ObterTodosFiltrando(nomePesquisa);

            dataGridView1.Rows.Clear();

            for (int i = 0; i < unidades.Count; i++)
            {
                var unidade = unidades[i];

                dataGridView1.Rows.Add(new object[]
                {
                    
                    unidade.Id,
                    unidade.Nome,
                    unidade.Cep.Substring(0, 5) + "-" + unidade.Cep.Substring(4, 3),
                    unidade.Logradouro,
                    unidade.Bairro,
                    unidade.Cidade,
                    unidade.Uf
                });
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um cliente");
                return;
            }

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                var unidade = _unidadeService.ObterPorId(idRegistro);

                var unidadeForm = new UnidadeCadastroEdicaoForm(unidade);

                unidadeForm.ShowDialog();

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
                MessageBox.Show("Nenhum cliente cadastrado");

                return;
            }

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");

                return;
            }

            var desejaApagar = MessageBox.Show("Deseja realmente apagar", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (desejaApagar == DialogResult.No)
                return;

            var registro = dataGridView1.SelectedRows[0];

            var idRegistro = Convert.ToInt32(registro.Cells[0].Value);

            try
            {
                _unidadeService.Apagar(idRegistro);

                MessageBox.Show("Cliente apagado com sucesso");

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
