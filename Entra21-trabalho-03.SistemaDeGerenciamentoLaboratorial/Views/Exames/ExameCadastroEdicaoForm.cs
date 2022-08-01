using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Models;
using Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Services;

namespace Entra21_trabalho_03.SistemaDeGerenciamentoLaboratorial.Views.Exames
{
    public partial class ExameCadastroEdicaoForm : Form
    {
        private readonly int _idParaEditar;

        private readonly ExameService _exameService;

        private const int modoCadastro = -1;

        public ExameCadastroEdicaoForm()
        {
            InitializeComponent();

            _idParaEditar = modoCadastro;

            _exameService = new ExameService();

            PreencherComBoxMedico();
        }

        public ExameCadastroEdicaoForm(Exame exame) : this()
        {
            _idParaEditar = exame.Id;

            textBoxNome.Text = exame.Nome;
            textBoxPreco.Text = exame.Preco.ToString();
            textBoxInstrucoes.Text = exame.Instrucoes;

            for (int i = 0; i < comboBoxMedico.Items.Count; i++)
            {
                var medicoPercorrido = comboBoxMedico.Items[i] as Medico;

                if (medicoPercorrido.Id == exame.Medico.Id)
                {
                    comboBoxMedico.SelectedItem = medicoPercorrido;
                    break;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var exame = new Exame();
            exame.Nome = textBoxNome.Text.Trim();
            exame.Preco = Convert.ToDouble(textBoxPreco.Text.Trim());
            exame.Medico = comboBoxMedico.SelectedItem as Medico;
            exame.Instrucoes = textBoxInstrucoes.Text.Trim();

            if (ValidarInformacoes() == false)
                return;

            if (_idParaEditar == -1)
            {
                _exameService.Cadastrar(exame);

                MessageBox.Show("Exame cadastrado com sucesso");
                Close();
            }
            else
            {
                exame.Id = _idParaEditar;

                _exameService.Editar(exame);

                MessageBox.Show("Exame editado com sucesso");
                Close();
            }


        }

        private void PreencherComBoxMedico()
        {
            var medicoService = new MedicoService();
            var medicos = medicoService.ObterTodosFiltrando("");

            for (int i = 0; i < medicos.Count; i++)
            {
                var medico = medicos[i];
                comboBoxMedico.Items.Add(medico);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarInformacoes()
        {
            if (textBoxNome.Text.Trim().Length <= 3 || textBoxNome.Text.Trim().Length >= 30)
            {
                MessageBox.Show("O nome deve conter mais que 3 caracteres e menos que 30");
                textBoxNome.Focus();
                return false;
            }

            if (textBoxPreco.Text.Trim().Length > 9)
            {
                MessageBox.Show("O preço deve ser menor que R$99.999,99");
                textBoxPreco.Focus();
                return false;
            }

            if (comboBoxMedico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um médico");
                comboBoxMedico.Focus();
                return false;
            }

            if (textBoxNome.Text.Trim().Length >= 50)
            {
                MessageBox.Show("As instruções devem conter menor que 50 caracteres");
                textBoxNome.Focus();
                return false;
            }

            return true;
        }
    }
}
